#pragma checksum "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b1196e100a2db471ea64462d18eb79aef674ea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Skill\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b1196e100a2db471ea64462d18eb79aef674ea8", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""d-flex justify-content-end mb-4"">
    <a href=""/Skill/AddSkill"" class=""btn btn-success"">+ Yeni Yetenek Ekle</a>
</div>

<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Başlık</th>
                                <th>Oran</th>
                                <th class=""text-center"">Sil</th>
                                <th class=""text-center"">Düzenle</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 29 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Skill\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">\r\n                                        ");
#nullable restore
#line 33 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Skill\Index.cshtml"
                                   Write(item.SkillID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <td class=\"budget\">\r\n                                        ");
#nullable restore
#line 36 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Skill\Index.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <div class=\"progress\">\r\n                                            <div class=\"progress-bar bg-warning\" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 1611, "\"", 1638, 3);
            WriteAttributeValue("", 1619, "width:", 1619, 6, true);
#nullable restore
#line 40 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue(" ", 1625, item.Value, 1626, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1637, "%", 1637, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1639, "\"", 1666, 1);
#nullable restore
#line 40 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1655, item.Value, 1655, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\">%");
#nullable restore
#line 40 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Skill\Index.cshtml"
                                                                                                                                                                                              Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        </div>\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1921, "\"", 1960, 2);
            WriteAttributeValue("", 1928, "/Skill/DeleteSkill/", 1928, 19, true);
#nullable restore
#line 44 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1947, item.SkillID, 1947, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" onclick=\"return confirm(\'Silmek istediğinize emin misiniz?\')\">Sil</a>\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2211, "\"", 2248, 2);
            WriteAttributeValue("", 2218, "/Skill/EditSkill/", 2218, 17, true);
#nullable restore
#line 47 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 2235, item.SkillID, 2235, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Düzenle</a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Skill\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
