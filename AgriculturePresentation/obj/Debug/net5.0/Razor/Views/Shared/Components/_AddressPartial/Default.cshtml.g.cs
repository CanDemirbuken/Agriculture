#pragma checksum "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_AddressPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d42d434e67892ed5f8a2814bcaeaf24d85691ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__AddressPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_AddressPartial/Default.cshtml")]
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
#line 1 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_AddressPartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d42d434e67892ed5f8a2814bcaeaf24d85691ac", @"/Views/Shared/Components/_AddressPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ffff724fe34f91470fb11811ab6f488238ce75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__AddressPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Address>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \n<h3 class=\"tittle\">Bize Ulaşın</h3>\n<p class=\"heading-btm-w3ls\">Aşağıdaki form üzerinden bize mail gönderebilir veya telefonla arayabilirsiniz.</p>\n");
#nullable restore
#line 6 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_AddressPartial\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-3 contact-left\">\n    <h4>Bizim Adresimiz</h4>\n    <p>");
#nullable restore
#line 10 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_AddressPartial\Default.cshtml"
  Write(item.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</p>\n    <p>");
#nullable restore
#line 11 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_AddressPartial\Default.cshtml"
  Write(item.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</p>\n    <p>");
#nullable restore
#line 12 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_AddressPartial\Default.cshtml"
  Write(item.Description3);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</p>\n    <h4>Telefon Numaramız</h4>\n    <p>");
#nullable restore
#line 14 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_AddressPartial\Default.cshtml"
  Write(item.Description4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n");
#nullable restore
#line 16 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_AddressPartial\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
