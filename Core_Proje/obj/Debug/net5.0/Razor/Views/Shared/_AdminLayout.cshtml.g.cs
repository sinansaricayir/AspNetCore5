#pragma checksum "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d20eaa25b415f1af16a88a6bfd24f79b2a061af9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d20eaa25b415f1af16a88a6bfd24f79b2a061af9", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n\n            ");
#nullable restore
#line 5 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_AdminLayout.cshtml"
       Write(await Html.PartialAsync("/Views/Admin/PartialHead.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d20eaa25b415f1af16a88a6bfd24f79b2a061af93409", async() => {
                WriteLiteral("\n    <!-- Sidenav -->\n            ");
#nullable restore
#line 9 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_AdminLayout.cshtml"
       Write(await Html.PartialAsync("/Views/Admin/PartialSidebar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \n    <!-- Main content -->\n    <div class=\"main-content\" id=\"panel\">\n        <!-- Topnav -->\n            ");
#nullable restore
#line 13 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_AdminLayout.cshtml"
       Write(await Html.PartialAsync("/Views/Admin/PartialNavbar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \n        <!-- Header -->\n        <!-- Header -->\n            ");
#nullable restore
#line 16 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_AdminLayout.cshtml"
       Write(await Html.PartialAsync("/Views/Admin/PartialNavigation.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \n        <!-- Page content -->\n        <div class=\"container-fluid mt--6\">\n            <div class=\"row\">\n                <div class=\"col\">\n                    ");
#nullable restore
#line 21 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_AdminLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n            </div>\n            <br /><br />\n            <!-- Footer -->\n            ");
#nullable restore
#line 26 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_AdminLayout.cshtml"
       Write(await Html.PartialAsync("/Views/Admin/PartialFooter.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n           ");
#nullable restore
#line 29 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\_AdminLayout.cshtml"
      Write(await Html.PartialAsync("/Views/Admin/PartialScript.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \n");
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
            WriteLiteral("\n\n</html>\n");
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
