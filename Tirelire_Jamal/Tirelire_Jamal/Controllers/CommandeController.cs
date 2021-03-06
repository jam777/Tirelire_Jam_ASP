﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tirelire_Jamal.Models;
using Tirelire_Jamal.Repository;
using Tirelire_Jamal.Session;

namespace Tirelire_Jamal.Controllers
{
    [Authorize(Roles = "Client,Admin")]
    public class CommandeController : Controller
    {

        private IRepository<Produit> _repoProd;
        private IRepository<Commande> _repoCmd;
        private IRepository<Avis> _repoAvis;
        private ISessionTirelire _session;
        private readonly UserManager<Client> _userManager;

        public CommandeController(IRepository<Produit> repoProd, ISessionTirelire session, IRepository<Commande> repoCmd, UserManager<Client> userManager = null, IRepository<Avis> repoAvis = null)
        {
            _repoProd = repoProd;
            _repoCmd = repoCmd;
            _session = session;
            _userManager = userManager;
            _repoAvis = repoAvis;
        }

        /// <summary>
        /// Ajouter une commande
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Ajouter(Commande cmd)
        {
            //Session
            var panierSession = _session.deserialise();

            if (User.IsInRole("Admin"))
            {
                //Commande
                cmd.Date = panierSession.Cmd.Date;
                cmd.Idclient = _userManager.Users.First().Id;
                cmd.Status = "Préparée";
                //Les Détails Commandes
                foreach (var detail in panierSession.Cmd.DetailCommande)
                {
                    cmd.DetailCommande.Add(
                       detail
                    );
                }
                _repoCmd.Create(cmd);

                //AVIS

                foreach (var detail in cmd.DetailCommande)
                {
                    Avis avis = new Avis();
                    avis.Idcommande = cmd.Id;
                    avis.Idclient = cmd.Idclient;
                    avis.Idproduit = detail.Idproduit;
                    avis.Valide = true;
                    _repoAvis.Create(avis);
                }

                _session.clearSession();

                return RedirectToAction("Cmde", "Commande");
            }
            else
            {
                ViewBag.totalPanier = _session.totalPanier();
                ViewBag.message = "Vous n'avez pas les droits pour Commander";
                return View("_modalErreur");
            }
        }

        /// <summary>
        /// Afficher la vue Commande
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Cmde()
        {
            var user = await _userManager.GetUserAsync(User);
            var prods = _repoProd.FindAll().ToList();

            ViewBag.prods = prods;
            ViewBag.totalPanier = _session.totalPanier();
            ViewBag.Titre = "Liste des Commandes";

            return View(user);
        }
    }
}
