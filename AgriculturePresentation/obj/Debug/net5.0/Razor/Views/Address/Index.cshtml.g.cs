#pragma checksum "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Address\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b8a2ec53125cba06635b6ab6f0e5e516a1b8b70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Address_Index), @"mvc.1.0.view", @"/Views/Address/Index.cshtml")]
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
#line 1 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Address\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8a2ec53125cba06635b6ab6f0e5e516a1b8b70", @"/Views/Address/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ffff724fe34f91470fb11811ab6f488238ce75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Address_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Address>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Address\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Adres Listesi</h4>
            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th>Açıklama 1</th>
                            <th>Açıklama 2</th>
                            <th>Açıklama 3</th>
                            <th>Açıklama 4</th>
                            <th>Güncelle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Address\Index.cshtml"
                         foreach (var item in Model)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 29 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Address\Index.cshtml"
                               Write(item.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 30 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Address\Index.cshtml"
                               Write(item.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 31 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Address\Index.cshtml"
                               Write(item.Description3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 32 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Address\Index.cshtml"
                               Write(item.Description4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1166, "\"", 1209, 2);
            WriteAttributeValue("", 1173, "/Address/EditAddress/", 1173, 21, true);
#nullable restore
#line 33 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Address\Index.cshtml"
WriteAttributeValue("", 1194, item.AddressID, 1194, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\n                            </tr>\n");
#nullable restore
#line 35 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Address\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n            <br />\n        </div>\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Address>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
