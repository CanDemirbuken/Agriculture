#pragma checksum "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_DashboardOverviewPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91d55851b59ed4bd5941611fba0dc6bac393fe5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__DashboardOverviewPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_DashboardOverviewPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91d55851b59ed4bd5941611fba0dc6bac393fe5d", @"/Views/Shared/Components/_DashboardOverviewPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ffff724fe34f91470fb11811ab6f488238ce75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__DashboardOverviewPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body dashboard-tabs p-0"">
                <ul class=""nav nav-tabs px-4"" role=""tablist"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" id=""overview-tab"" data-bs-toggle=""tab"" href=""#overview"" role=""tab"" aria-controls=""overview"" aria-selected=""true"">İstatistik 1</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""sales-tab"" data-bs-toggle=""tab"" href=""#sales"" role=""tab"" aria-controls=""sales"" aria-selected=""false"">İstatistik 2</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""purchases-tab"" data-bs-toggle=""tab"" href=""#purchases"" role=""tab"" aria-controls=""purchases"" aria-selected=""false"">Ekip Arkadaşlarımız ve Roller</a>
                    </li>
                </ul>
                <div class=""tab-content p");
            WriteLiteral(@"y-0 px-0"">
                    <div class=""tab-pane fade show active"" id=""overview"" role=""tabpanel"" aria-labelledby=""overview-tab"">
                        <div class=""d-flex flex-wrap justify-content-xl-between"">
                            <div class=""d-none d-xl-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-calendar-heart icon-lg me-3 text-primary""></i>
                                <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Tarih</small>
                                    <div class=""dropdown"">
                                        <a class=""btn btn-secondary dropdown-toggle p-0 bg-transparent border-0 text-dark shadow-none font-weight-medium"" href=""#"" role=""button"" id=""dropdownMenuLinkA"" data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                            <h5 class=""mb-0 d-inline-block"">");
#nullable restore
#line 25 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_DashboardOverviewPartial\Default.cshtml"
                                                                       Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                        </a>
                                        
                                    </div>
                                </div>
                            </div>
                            <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-currency-usd me-3 icon-lg text-danger""></i>
                                <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Çalışan Sayısı</small>
                                    <h5 class=""me-2 mb-0"">");
#nullable restore
#line 35 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_DashboardOverviewPartial\Default.cshtml"
                                                     Write(ViewBag.teamCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                </div>
                            </div>
                            <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-eye me-3 icon-lg text-success""></i>
                                <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Hizmet Sayısı</small>
                                    <h5 class=""me-2 mb-0"">");
#nullable restore
#line 42 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_DashboardOverviewPartial\Default.cshtml"
                                                     Write(ViewBag.serviceCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                </div>
                            </div>
                            <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-download me-3 icon-lg text-warning""></i>
                                <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Gelen Mesaj</small>
                                    <h5 class=""me-2 mb-0"">");
#nullable restore
#line 49 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_DashboardOverviewPartial\Default.cshtml"
                                                     Write(ViewBag.messageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                </div>
                            </div>
                            <div class=""d-flex py-3 border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-flag me-3 icon-lg text-danger""></i>
                                <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Bu Ay Gelen Mesaj</small>
                                    <h5 class=""me-2 mb-0"">");
#nullable restore
#line 56 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_DashboardOverviewPartial\Default.cshtml"
                                                     Write(ViewBag.currentMonthMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""sales"" role=""tabpanel"" aria-labelledby=""sales-tab"">
                        <div class=""d-flex flex-wrap justify-content-xl-between"">
                            <div class=""d-none d-xl-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-calendar-heart icon-lg me-3 text-primary""></i>
                                <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Start date</small>
                                    <div class=""dropdown"">
                                        <a class=""btn btn-secondary dropdown-toggle p-0 bg-transparent border-0 text-dark shadow-none font-weight-medium"" href=""#"" role=""button"" id=""dropdownMenuLinkA"" data-bs-toggle=""dropdown"" aria-ha");
            WriteLiteral(@"spopup=""true"" aria-expanded=""false"">
                                            <h5 class=""mb-0 d-inline-block"">26 Jul 2018</h5>
                                        </a>
                                        <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuLinkA"">
                                            <a class=""dropdown-item"" href=""#"">12 Aug 2018</a>
                                            <a class=""dropdown-item"" href=""#"">22 Sep 2018</a>
                                            <a class=""dropdown-item"" href=""#"">21 Oct 2018</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-download me-3 icon-lg text-warning""></i>
                                <div class=""d-flex flex-column justify-content-a");
            WriteLiteral(@"round"">
                                    <small class=""mb-1 text-muted"">Downloads</small>
                                    <h5 class=""me-2 mb-0"">2233783</h5>
                                </div>
                            </div>
                            <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-eye me-3 icon-lg text-success""></i>
                                <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Total views</small>
                                    <h5 class=""me-2 mb-0"">9833550</h5>
                                </div>
                            </div>
                            <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-currency-usd me-3 icon-lg text-danger""></i>
                              ");
            WriteLiteral(@"  <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Revenue</small>
                                    <h5 class=""me-2 mb-0"">$577545</h5>
                                </div>
                            </div>
                            <div class=""d-flex py-3 border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-flag me-3 icon-lg text-danger""></i>
                                <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Flagged</small>
                                    <h5 class=""me-2 mb-0"">3497843</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""purchases"" role=""tabpanel"" aria-labelledby=""purchases-tab"">
                        <div class");
            WriteLiteral(@"=""d-flex flex-wrap justify-content-xl-between"">
                            <div class=""d-none d-xl-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-calendar-heart icon-lg me-3 text-primary""></i>
                                <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Start date</small>
                                    <div class=""dropdown"">
                                        <a class=""btn btn-secondary dropdown-toggle p-0 bg-transparent border-0 text-dark shadow-none font-weight-medium"" href=""#"" role=""button"" id=""dropdownMenuLinkA"" data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                            <h5 class=""mb-0 d-inline-block"">26 Jul 2018</h5>
                                        </a>
                                        <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink");
            WriteLiteral(@"A"">
                                            <a class=""dropdown-item"" href=""#"">12 Aug 2018</a>
                                            <a class=""dropdown-item"" href=""#"">22 Sep 2018</a>
                                            <a class=""dropdown-item"" href=""#"">21 Oct 2018</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-currency-usd me-3 icon-lg text-danger""></i>
                                <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Bakliyat Yönetimi</small>
                                    <h5 class=""me-2 mb-0"">");
#nullable restore
#line 131 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_DashboardOverviewPartial\Default.cshtml"
                                                     Write(ViewBag.bakliyatYonetimi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                </div>
                            </div>
                            <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-eye me-3 icon-lg text-success""></i>
                                <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Ürün Pazarlama</small>
                                    <h5 class=""me-2 mb-0"">");
#nullable restore
#line 138 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_DashboardOverviewPartial\Default.cshtml"
                                                     Write(ViewBag.urunPazarlama);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                </div>
                            </div>
                            <div class=""d-flex border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-download me-3 icon-lg text-warning""></i>
                                <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Sü Üretici</small>
                                    <h5 class=""me-2 mb-0"">");
#nullable restore
#line 145 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_DashboardOverviewPartial\Default.cshtml"
                                                     Write(ViewBag.sutUretici);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                </div>
                            </div>
                            <div class=""d-flex py-3 border-md-right flex-grow-1 align-items-center justify-content-center p-3 item"">
                                <i class=""mdi mdi-flag me-3 icon-lg text-danger""></i>
                                <div class=""d-flex flex-column justify-content-around"">
                                    <small class=""mb-1 text-muted"">Gübre Yönetimi</small>
                                    <h5 class=""me-2 mb-0"">");
#nullable restore
#line 152 "C:\Users\yasar\OneDrive\Masaüstü\AgriculturePresentation-master\AgriculturePresentation\Views\Shared\Components\_DashboardOverviewPartial\Default.cshtml"
                                                     Write(ViewBag.gubreYonetimi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
