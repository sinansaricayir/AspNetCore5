#pragma checksum "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_NewAdminLAyout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76f048f9d1de0149d93ef3ffd03f2513d2b48cf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NewAdminLAyout), @"mvc.1.0.view", @"/Views/Shared/_NewAdminLAyout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f048f9d1de0149d93ef3ffd03f2513d2b48cf4", @"/Views/Shared/_NewAdminLAyout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NewAdminLAyout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/corona-free-dark-bootstrap-admin-template-1.0.0/template/assets/images/logo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/corona-free-dark-bootstrap-admin-template-1.0.0/template/assets/images/logo-mini.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
#nullable restore
#line 3 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_NewAdminLAyout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/PartialNewHead.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76f048f9d1de0149d93ef3ffd03f2513d2b48cf44765", async() => {
                WriteLiteral(@"
    <div class=""container-scroller"">
        <!-- partial:../../partials/_sidebar.html -->
        <nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
            <div class=""sidebar-brand-wrapper d-none d-lg-flex align-items-center justify-content-center fixed-top"">
                <a class=""sidebar-brand brand-logo"" href=""/Dashboard"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76f048f9d1de0149d93ef3ffd03f2513d2b48cf45377", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n                <a class=\"sidebar-brand brand-logo-mini\" href=\"/Dashboard\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76f048f9d1de0149d93ef3ffd03f2513d2b48cf46633", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n            </div>\r\n            ");
#nullable restore
#line 12 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_NewAdminLAyout.cshtml"
       Write(await Html.PartialAsync("/Views/Admin/PartialNewSidebar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </nav>\r\n        <!-- partial -->\r\n        <div class=\"container-fluid page-body-wrapper\">\r\n            ");
#nullable restore
#line 16 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_NewAdminLAyout.cshtml"
       Write(await Html.PartialAsync("/Views/Admin/PartialNewNavbar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"main-panel\">\r\n                <div class=\"content-wrapper\">\r\n                    <div class=\"page-header\">\r\n                        <h3 class=\"page-title\">");
#nullable restore
#line 20 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_NewAdminLAyout.cshtml"
                                          Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                        <nav aria-label=\"breadcrumb\">\r\n                            <ol class=\"breadcrumb\">\r\n                                <li class=\"breadcrumb-item\"><a href=\"#\">");
#nullable restore
#line 23 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_NewAdminLAyout.cshtml"
                                                                   Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n                                <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 24 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_NewAdminLAyout.cshtml"
                                                                                  Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                            </ol>\r\n                        </nav>\r\n                    </div>\r\n\r\n                    ");
#nullable restore
#line 29 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_NewAdminLAyout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n\r\n                ");
#nullable restore
#line 33 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_NewAdminLAyout.cshtml"
           Write(await RenderSectionAsync("Scripts"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" 

                <!-- content-wrapper ends -->
                <!-- partial:../../partials/_footer.html -->
                <footer class=""footer"">
                    <div class=""d-sm-flex justify-content-center justify-content-sm-between"">
                        <span class=""text-muted d-block text-center text-sm-left d-sm-inline-block""></span>
                        <span class=""float-none float-sm-right d-block mt-1 mt-sm-0 text-center""><a href=""https://www.saricayirsinan.com"" target=""_blank"">Copyright © SSA Technology</a></span>
                    </div>
                </footer>
                <!-- partial -->
            </div>
            <!-- main-panel ends -->
        </div>
        <!-- page-body-wrapper ends -->
    </div>

    ");
#nullable restore
#line 50 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_NewAdminLAyout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/PartialNewScript.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
