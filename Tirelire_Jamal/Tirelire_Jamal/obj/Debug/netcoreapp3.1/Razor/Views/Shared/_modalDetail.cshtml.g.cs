#pragma checksum "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_modalDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e958976c1b1133845f39140f51f8c6e934f5d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__modalDetail), @"mvc.1.0.view", @"/Views/Shared/_modalDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35e958976c1b1133845f39140f51f8c6e934f5d0", @"/Views/Shared/_modalDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d7c816e9aba37ca09835a49008e68de186ba53", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__modalDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tirelire_Jamal.Models.Produit>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Modal -->
<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-sm"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""exampleModalCenterTitle"">");
#nullable restore
#line 7 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_modalDetail.cshtml"
                                                                Write(Model.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <img");
            BeginWriteAttribute("src", " src=", 695, "", 712, 1);
#nullable restore
#line 13 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Shared\_modalDetail.cshtml"
WriteAttributeValue("", 700, Model.Image, 700, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"imgModalDetail\" class=\"w-100\" />\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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