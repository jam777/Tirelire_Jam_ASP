﻿using System;
using System.Collections.Generic;

namespace Tirelire_Jamal.Models
{
    public partial class Adresse
    {
        public Adresse()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
        }

        public int Id { get; set; }
        public string AdLivraison { get; set; }
        public string AdFacturation { get; set; }

        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
