#pragma checksum "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Admin\PartialNewSidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb28b4bf86cc5691b26c1fd5f7a3b8704d30c053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PartialNewSidebar), @"mvc.1.0.view", @"/Views/Admin/PartialNewSidebar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb28b4bf86cc5691b26c1fd5f7a3b8704d30c053", @"/Views/Admin/PartialNewSidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_PartialNewSidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.WriterUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-xs rounded-circle "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/corona-free-dark-bootstrap-admin-template-1.0.0/template/assets/images/faces/face15.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"nav\">\r\n    <li class=\"nav-item profile\">\r\n        <div class=\"profile-desc\">\r\n            <div class=\"profile-pic\">\r\n                <div class=\"count-indicator\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb28b4bf86cc5691b26c1fd5f7a3b8704d30c0534503", async() => {
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
                    <span class=""count bg-success""></span>
                </div>
                <div class=""profile-name"">
                    <h5 class=""mb-0 font-weight-normal"">Sinan Sarıçayır</h5>
                    <span>Admin</span>
                </div>
            </div>
");
            WriteLiteral(@"        </div>
    </li>
    <li class=""nav-item nav-category"">
        <span class=""nav-link"">Navigation</span>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Dashboard/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-speedometer""></i>
            </span>
            <span class=""menu-title"">Dashboard</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Feature/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-contacts""></i>
            </span>
            <span class=""menu-title"">Öne Çıkan Gönderiler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/About/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-file-document-box""></i>
            </span>
            <span class=""menu-title"">Hakkımda</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">");
            WriteLiteral(@"
        <a class=""nav-link"" href=""/Service/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-file-document-box""></i>
            </span>
            <span class=""menu-title"">Hizmetler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Skill/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-speedometer""></i>
            </span>
            <span class=""menu-title"">Yetenekler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Portfolio/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-github-circle""></i>
            </span>
            <span class=""menu-title"">Projeler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Experience/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-playlist-play""></i>
            </span>
");
            WriteLiteral(@"            <span class=""menu-title"">Deneyimler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Testimonial/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-contact-mail""></i>
            </span>
            <span class=""menu-title"">Referanslar</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Contact/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-message""></i>
            </span>
            <span class=""menu-title"">İletişim Mesajlar</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/AdminMessage/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-message""></i>
            </span>
            <span class=""menu-title"">Yazar-Admin Mesajlar</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/W");
            WriteLiteral(@"riterUser/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-contacts""></i>
            </span>
            <span class=""menu-title"">Yazar - Admin Listesi</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/SocialMedia/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-youtube""></i>
            </span>
            <span class=""menu-title"">Sosyal Medya Hesapları</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Default/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-web""></i>
            </span>
            <span class=""menu-title"">Siteye Git</span>
        </a>
    </li>
</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.WriterUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
