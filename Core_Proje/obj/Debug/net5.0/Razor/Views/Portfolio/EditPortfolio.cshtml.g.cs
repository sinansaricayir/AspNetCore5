#pragma checksum "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\EditPortfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc5dbe970958cc36dbd1d5cefdf65348fcf80bd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_EditPortfolio), @"mvc.1.0.view", @"/Views/Portfolio/EditPortfolio.cshtml")]
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
#line 1 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc5dbe970958cc36dbd1d5cefdf65348fcf80bd3", @"/Views/Portfolio/EditPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_EditPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Portfolio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
  
    ViewData["Title"] = "EditPortfolio";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Portfolio Güncelleme Sayfası</h3>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc5dbe970958cc36dbd1d5cefdf65348fcf80bd34324", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 13 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.HiddenFor(x=>x.PortfolioID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 17 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.Label("Proje Adı"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"text\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 411, "\"", 430, 1);
#nullable restore
#line 18 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
WriteAttributeValue("", 419, Model.Name, 419, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 21 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.Label("Resim 1"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"text\" name=\"ImageUrl\"");
                BeginWriteAttribute("value", " value=\"", 537, "\"", 560, 1);
#nullable restore
#line 22 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
WriteAttributeValue("", 545, Model.ImageUrl, 545, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 25 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.Label("Resim 2"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"text\" name=\"ImageUrl2\"");
                BeginWriteAttribute("value", " value=\"", 668, "\"", 692, 1);
#nullable restore
#line 26 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
WriteAttributeValue("", 676, Model.ImageUrl2, 676, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 29 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.Label("Proje Url"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"text\" name=\"ProjectUrl\"");
                BeginWriteAttribute("value", " value=\"", 803, "\"", 828, 1);
#nullable restore
#line 30 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
WriteAttributeValue("", 811, Model.ProjectUrl, 811, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    <br />\r\n\r\n    <button type=\"submit\" class=\"btn btn-info\">Güncelle</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Portfolio> Html { get; private set; }
    }
}
#pragma warning restore 1591
