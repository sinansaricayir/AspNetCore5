#pragma checksum "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Experience\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66d8b5bd693b8d799ee5ba9e9068ca71e7f3a4ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_Index), @"mvc.1.0.view", @"/Views/Experience/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Experience\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d8b5bd693b8d799ee5ba9e9068ca71e7f3a4ad", @"/Views/Experience/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Experience_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Experience\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header border-0"">
    <h3 class=""mb-0"">Deneyim Listesi Tablosu</h3>
</div>
<!-- Light table -->
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Deneyim</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Tarih</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Resim</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Açıklama</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Şirket Adı</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Düzenle</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody class=""list"">
");
#nullable restore
#line 28 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Experience\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Experience\Index.cshtml"
               Write(item.ExperienceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"budget\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Experience\Index.cshtml"
               Write(item.ExperienceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Experience\Index.cshtml"
               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Experience\Index.cshtml"
               Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Experience\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Experience\Index.cshtml"
               Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1789, "\"", 1843, 2);
            WriteAttributeValue("", 1796, "/Experience/DeleteExperience/", 1796, 29, true);
#nullable restore
#line 50 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Experience\Index.cshtml"
WriteAttributeValue("", 1825, item.ExperienceID, 1825, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1944, "\"", 1996, 2);
            WriteAttributeValue("", 1951, "/Experience/EditExperience/", 1951, 27, true);
#nullable restore
#line 53 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Experience\Index.cshtml"
WriteAttributeValue("", 1978, item.ExperienceID, 1978, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Düzenle</a>\r\n                </td>\r\n                <td></td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Experience\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n<br />\r\n<a href=\"/Experience/AddExperience\" class=\"btn btn-info\">Deneyim Ekle</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; }
    }
}
#pragma warning restore 1591
