#pragma checksum "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b1710232574418bee61b763accc67a0fdd61b98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__SocialMediaPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_SocialMediaPartial/Default.cshtml")]
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
#line 1 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b1710232574418bee61b763accc67a0fdd61b98", @"/Views/Shared/Components/_SocialMediaPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ffff724fe34f91470fb11811ab6f488238ce75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__SocialMediaPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n    <div class=\"w3l_header_right\">\n        <div class=\"w3ls-social-icons text-left\">\n");
#nullable restore
#line 6 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("class", " class=\"", 208, "\"", 227, 1);
#nullable restore
#line 8 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
WriteAttributeValue("", 216, item.Title, 216, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 228, "\"", 244, 1);
#nullable restore
#line 8 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
WriteAttributeValue("", 235, item.Url, 235, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 248, "\"", 266, 1);
#nullable restore
#line 8 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
WriteAttributeValue("", 256, item.Icon, 256, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\n");
#nullable restore
#line 9 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
