#pragma checksum "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5bff3989ab83305af6646eb4eb8fbecadb8dc49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5bff3989ab83305af6646eb4eb8fbecadb8dc49", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ffff724fe34f91470fb11811ab6f488238ce75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("_DashboardHeaderPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5bff3989ab83305af6646eb4eb8fbecadb8dc493846", async() => {
                WriteLiteral("\n\n    ");
#nullable restore
#line 10 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("_DashboardNavbarPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 12 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("_DashboardOverviewPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 14 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("_DashboardChartPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n   \n    ");
#nullable restore
#line 16 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("_DashboardTablePartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n  \n    ");
#nullable restore
#line 18 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("_DashboardScriptPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    \n");
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
