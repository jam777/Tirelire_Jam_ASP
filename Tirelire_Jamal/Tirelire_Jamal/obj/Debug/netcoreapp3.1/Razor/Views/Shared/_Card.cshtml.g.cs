#pragma checksum "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_Card.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4033ffcc517d81bd6acded55ca56e369e1417abb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Card), @"mvc.1.0.view", @"/Views/Shared/_Card.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4033ffcc517d81bd6acded55ca56e369e1417abb", @"/Views/Shared/_Card.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d7c816e9aba37ca09835a49008e68de186ba53", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Card : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tirelire_Jamal.Models.Produit>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"article col-sm-3 col-md-2 mx-0 p-2 text-center\">\r\n    <div class=\"card  px-0\">\r\n        <a class=\"hoverImg\"");
            BeginWriteAttribute("href", " href=", 157, "", 212, 1);
#nullable restore
#line 4 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_Card.cshtml"
WriteAttributeValue("", 163, Url.Action("Detail", "Home",new { id=Model.Id }), 163, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("src", " src=", 231, "", 248, 1);
#nullable restore
#line 5 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_Card.cshtml"
WriteAttributeValue("", 236, Model.Image, 236, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"imgCard w-100 d-block\" alt=\"image produit\">\r\n            <div class=\"hoverImgBack\"></div>\r\n            <div class=\"hoverDetail\">Voir détail</div>\r\n        </a>\r\n\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_Card.cshtml"
                              Write(Model.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h6>Prix : <span>");
#nullable restore
#line 12 "C:\Users\jamel\Desktop\Tirelire_Jam_Pagination\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_Card.cshtml"
                        Write(Model.Prix);

#line default
#line hidden
#nullable disable
            WriteLiteral("€</span></h6>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tirelire_Jamal.Models.Produit> Html { get; private set; }
    }
}
#pragma warning restore 1591
