#pragma checksum "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72c168123b043d71093b8a80365dec424eed15e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\_ViewImports.cshtml"
using Tirelire_Jamal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\_ViewImports.cshtml"
using Tirelire_Jamal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72c168123b043d71093b8a80365dec424eed15e7", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d7c816e9aba37ca09835a49008e68de186ba53", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tirelire_Jamal.ViewModels.DetailColorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAjouter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Detail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Slide.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = "Detail";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<span id=\"statusPanier\">");
#nullable restore
#line 7 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                   Write(ViewBag.statusAjoutPanier);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n<nav aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item active\" aria-current=\"page\">\r\n            ");
#nullable restore
#line 12 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
       Write(Html.ActionLink("Accueil", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n        <li class=\"breadcrumb-item active\" aria-current=\"page\">\r\n            Détail\r\n        </li>\r\n    </ol>\r\n</nav>\r\n\r\n\r\n\r\n");
            WriteLiteral("<div class=\"detail row justify-content-center mx-0\">\r\n");
            WriteLiteral(@"    <div class=""card mb-3 col-md-8"">
        <div class=""titre_visiteur mx-2 d-flex justify-content-between mb-3"">
            <div class=""titre"">
                Détail de l'article
            </div>
        </div>
        <div class=""row justify-content-center no-gutters"">
");
            WriteLiteral("            <div class=\"d-flex  py-4 col-sm-5 mb-3 \">\r\n");
            WriteLiteral("                <a data-toggle=\"modal\" data-target=\"#exampleModalCenter\" class=\"hoverImg m-auto\">\r\n\r\n                    <img");
            BeginWriteAttribute("src", " src=", 1081, "", 1106, 1);
#nullable restore
#line 37 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1086, Model.produit.Image, 1086, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"imgCard card-img d-block\" alt=\"imgProduit\">\r\n                    <div class=\"hoverImgBack\"></div>\r\n                    <div class=\"hoverDetail\">Agrandir</div>\r\n                </a>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 42 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
           Write(Html.Partial("_modalDetail", Model.produit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"info-panier col-sm-7 mb-3 \">\r\n\r\n");
            WriteLiteral("                <div class=\"card-body m-0 \">\r\n\r\n");
            WriteLiteral("                    <h4 class=\"card-title\">");
#nullable restore
#line 51 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                                      Write(Model.produit.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
            WriteLiteral(@"                    <table class=""table table-responsive-sm"">
                        <thead>
                            <tr>
                                <th scope=""col"">LxHxL(cm)</th>
                                <th scope=""col"">Poids</th>
                                <th scope=""col"">Frais</th>
                                <th scope=""col"">Prix</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td class=""long""> ");
#nullable restore
#line 65 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                                              Write(Model.produit.Longueur);

#line default
#line hidden
#nullable disable
            WriteLiteral("X");
#nullable restore
#line 65 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                                                                        Write(Model.produit.Hauteur);

#line default
#line hidden
#nullable disable
            WriteLiteral("X");
#nullable restore
#line 65 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                                                                                                 Write(Model.produit.Largeur);

#line default
#line hidden
#nullable disable
            WriteLiteral("</</td>\r\n                                <td class=\"poids\">");
#nullable restore
#line 66 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                                             Write(Model.produit.Poids);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg</td>\r\n                                <td class=\"frais\">");
#nullable restore
#line 67 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                                             Write(Model.produit.Frais);

#line default
#line hidden
#nullable disable
            WriteLiteral("€/kg</td>\r\n                                <td class=\"prix\">");
#nullable restore
#line 68 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                                            Write(Model.produit.Prix);

#line default
#line hidden
#nullable disable
            WriteLiteral("€</td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n\r\n");
            WriteLiteral(@"                    <div class=""descriptionDetail "">
                        <div class=""titre_visiteur  mx-2 d-flex justify-content-between mb-3"">
                            <div class=""titre"">
                                <div>
                                    <a class=""slide down"" data-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
                                        <span>Description</span>
                                    </a>
                                </div>

                                <div id=""texteSlide"">
                                    ");
#nullable restore
#line 84 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                               Write(Model.produit.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n");
#nullable restore
#line 90 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                      
                        int valeur;
                        valeur = (ViewBag.quantitePanier != 0) ? ViewBag.quantitePanier : 1;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72c168123b043d71093b8a80365dec424eed15e712758", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <div class=""quantite d-flex"">
                                <span class=""col-5"">Quantite</span>
                                <select class=""custom-select"" name=""quantite"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72c168123b043d71093b8a80365dec424eed15e713320", async() => {
                    WriteLiteral("&emsp;&emsp;&nbsp;");
#nullable restore
#line 101 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                                                                                  Write(valeur);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                                                WriteLiteral(valeur);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 102 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                                     for (int i = 1; i <= 10; i++)
                                    {
                                        if (i == valeur)
                                        {
                                            continue;
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72c168123b043d71093b8a80365dec424eed15e716209", async() => {
                    WriteLiteral("&emsp;&emsp;&nbsp;");
#nullable restore
#line 108 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                                                                                            Write(i);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                                           WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 109 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>

                            </div>
                            <button type=""submit"" id=""ajouterPanier"" class=""btn btn-info btn-lg mt-2 form-control"" name=""panier"">Ajouter au Panier</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 96 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
AddHtmlAttributeValue("", 3799, Url.Action("Ajouter", "Panier", new { id = Model.produit.Id }), 3799, 63, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 117 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
               Write(Html.Partial("_modalPanier", Model.produit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 124 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
     if (Model.colorProduit.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container carousseDetail  col-md-4"">
            <div class=""titre_visiteur mx-2 d-flex justify-content-between mb-3"">
                <div class=""titre"">
                    Article(s) de même couleur
                </div>
            </div>
            ");
#nullable restore
#line 131 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"
       Write(Html.Partial("_carrousel", Model.colorProduit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 133 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Home\Detail.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72c168123b043d71093b8a80365dec424eed15e722241", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72c168123b043d71093b8a80365dec424eed15e723341", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tirelire_Jamal.ViewModels.DetailColorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591