#pragma checksum "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bf9ab19ebe0c40cdcc4e894c31a366a221c8d3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf9ab19ebe0c40cdcc4e894c31a366a221c8d3b", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ffff724fe34f91470fb11811ab6f488238ce75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n\n");
#nullable restore
#line 10 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_HeadPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bf9ab19ebe0c40cdcc4e894c31a366a221c8d3b5075", async() => {
                WriteLiteral("\n\n    <!-- header -->\n    <div class=\"header\">\n        <div class=\"container\">\n            ");
#nullable restore
#line 17 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
       Write(await Component.InvokeAsync("_TopAddressPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n            ");
#nullable restore
#line 19 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
       Write(await Component.InvokeAsync("_SocialMediaPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n            <div class=\"clearfix\"> </div>\n        </div>\n    </div>\n\n    ");
#nullable restore
#line 25 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_NavbarPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <div class=""modal fade"" id=""myModal1"" tabindex=""-1"" role=""dialog"">
        <!-- Modal1 -->
        <div class=""modal-dialog"">
            <!-- Modal content-->
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    <h4>In Harvest</h4>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3bf9ab19ebe0c40cdcc4e894c31a366a221c8d3b6833", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <h5>ENVIRONMENT & SUSTAINABILITY</h5>
                    <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting.</p>
                </div>
            </div>
        </div>
    </div>

    ");
#nullable restore
#line 43 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_AboutPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 45 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_ServicePartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 47 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_TeamPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 49 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_AnnouncementPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 51 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_GalleryPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    <!--footer-->\n    <div class=\"contact-agile\" id=\"contact\">\n        <div class=\"container\">\n\n            ");
#nullable restore
#line 57 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
       Write(await Component.InvokeAsync("_AddressPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n            ");
#nullable restore
#line 59 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
       Write(await Html.PartialAsync("/Views/Default/SendMessage.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n    ");
#nullable restore
#line 62 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_MapPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    <div class=\"copy\">\n        <p>© ");
#nullable restore
#line 65 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
        Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(" In Harvest . Tüm hakları saklıdır | Design by <a href=\"http://w3layouts.com/\">W3layouts</a> </p>\n    </div>\n    <!-- js -->\n    ");
#nullable restore
#line 68 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Default\Index.cshtml"
Write(await Html.PartialAsync("/Views/Default/ScriptPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
