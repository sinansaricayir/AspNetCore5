#pragma checksum "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\NavbarNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f4f4af89bc9af72c71b86da9d13f18d2f40b5a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NavbarNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NavbarNotification/Default.cshtml")]
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
#line 1 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f4f4af89bc9af72c71b86da9d13f18d2f40b5a3", @"/Views/Shared/Components/NavbarNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NavbarNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<li class=""nav-item dropdown border-left"">
    <a class=""nav-link count-indicator dropdown-toggle"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
        <i class=""mdi mdi-bell""></i>
        <span class=""count bg-danger""></span>
    </a>
    <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""notificationDropdown"">
        <h6 class=""p-3 mb-0"">Bildirimler</h6>
        <div class=""dropdown-divider""></div>
        <a class=""dropdown-item preview-item"">
            <div class=""preview-thumbnail"">
                <div class=""preview-icon bg-dark rounded-circle"">
                    <i class=""mdi mdi-calendar text-success""></i>
                </div>
            </div>
            <div class=""preview-item-content"">
                <p class=""preview-subject mb-1"">Bugünkü Etkinlik</p>
                <p class=""text-muted ellipsis mb-0"">Projelerin tamamlanıp canlıya alınması!</p>
            </div>
        </a>
        <div class=""dropdown-divide");
            WriteLiteral(@"r""></div>
        <a class=""dropdown-item preview-item"">
            <div class=""preview-thumbnail"">
                <div class=""preview-icon bg-dark rounded-circle"">
                    <i class=""mdi mdi-settings text-danger""></i>
                </div>
            </div>
            <div class=""preview-item-content"">
                <p class=""preview-subject mb-1"">Ayarlar</p>
                <p class=""text-muted ellipsis mb-0"">Dashboard güncellenmesi</p>
            </div>
        </a>
        <div class=""dropdown-divider""></div>
        <a class=""dropdown-item preview-item"">
            <div class=""preview-thumbnail"">
                <div class=""preview-icon bg-dark rounded-circle"">
                    <i class=""mdi mdi-link-variant text-warning""></i>
                </div>
            </div>
            <div class=""preview-item-content"">
                <p class=""preview-subject mb-1"">Kullanıcı Mesaj Ayarları</p>
                <p class=""text-muted ellipsis mb-0"">Identity özellikleri");
            WriteLiteral(" kontrol!</p>\r\n            </div>\r\n        </a>\r\n        <div class=\"dropdown-divider\"></div>\r\n        <p class=\"p-3 mb-0 text-center\">Tüm Bildirimler</p>\r\n    </div>\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591