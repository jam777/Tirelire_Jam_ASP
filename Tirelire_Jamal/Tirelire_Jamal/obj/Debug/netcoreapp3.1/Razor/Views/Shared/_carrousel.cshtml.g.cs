#pragma checksum "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_carrousel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adcd88d0dcf35ec33a386ca135f69b2da6531fee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__carrousel), @"mvc.1.0.view", @"/Views/Shared/_carrousel.cshtml")]
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
#line 1 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\_ViewImports.cshtml"
using Tirelire_Jamal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\_ViewImports.cshtml"
using Tirelire_Jamal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adcd88d0dcf35ec33a386ca135f69b2da6531fee", @"/Views/Shared/_carrousel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d7c816e9aba37ca09835a49008e68de186ba53", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__carrousel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tirelire_Jamal.Models.Produit>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"bd-example row m-md-auto mb-md-0 mb-3\">\r\n    <div id=\"carouselExampleCaptions\" class=\"d-inline-block m-auto carousel  slide1\" data-ride=\"carousel\">\r\n        <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 6 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_carrousel.cshtml"
             for (int i = 0; i < Model.Count(); i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li data-target=\"#carouselExampleCaptions\" data-slide-to=");
#nullable restore
#line 8 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_carrousel.cshtml"
                                                                    Write(i);

#line default
#line hidden
#nullable disable
            BeginWriteAttribute("class", " class=\"", 400, "\"", 408, 0);
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 9 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_carrousel.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ol>\r\n\r\n        <div class=\"carousel-inner\">\r\n\r\n");
#nullable restore
#line 14 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_carrousel.cshtml"
               int cpt = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_carrousel.cshtml"
             foreach (var prodColor in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item\"");
            BeginWriteAttribute("id", " id=", 623, "", 644, 2);
            WriteAttributeValue("", 627, "carousse", 627, 8, true);
#nullable restore
#line 17 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_carrousel.cshtml"
WriteAttributeValue("", 635, cpt ++, 635, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a");
            BeginWriteAttribute("href", " href=", 669, "", 725, 1);
#nullable restore
#line 18 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_carrousel.cshtml"
WriteAttributeValue("", 675, Url.Action("Detail","Home",new {id=prodColor.Id}), 675, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=", 756, "", 777, 1);
#nullable restore
#line 19 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_carrousel.cshtml"
WriteAttributeValue("", 761, prodColor.Image, 761, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\" alt=\"...\">\r\n                    </a>\r\n                    <div class=\"carousel-caption d-none d-md-block\">\r\n                        <h5>");
#nullable restore
#line 22 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_carrousel.cshtml"
                       Write(prodColor.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_carrousel.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tirelire_Jamal.Models.Produit>> Html { get; private set; }
    }
}
#pragma warning restore 1591
