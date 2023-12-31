#pragma checksum "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "833ec2383890fb3daea8a2bd99b7a10c679361e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Contact\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833ec2383890fb3daea8a2bd99b7a10c679361e7", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";
    var row = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th>Gönderen</th>
                                <th>Mail</th>
                                <th>Tarih</th>
                                <th class=""text-center""> Sil </th>
                                <th class=""text-center""> Düzenle </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 27 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Contact\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">\r\n                                        ");
#nullable restore
#line 31 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Contact\Index.cshtml"
                                   Write(row);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th class=\"budget\">\r\n                                        ");
#nullable restore
#line 34 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Contact\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th class=\"budget\">\r\n                                        ");
#nullable restore
#line 37 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Contact\Index.cshtml"
                                   Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 40 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Contact\Index.cshtml"
                                   Write(Convert.ToDateTime(item.Date).ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1769, "\"", 1814, 2);
            WriteAttributeValue("", 1776, "/Contact/DeleteMessage/", 1776, 23, true);
#nullable restore
#line 43 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1799, item.MessageID, 1799, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" onclick=\"return confirm(\'Silmek istediğinize emin misiniz?\')\">Sil</a>\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2065, "\"", 2108, 2);
            WriteAttributeValue("", 2072, "/Contact/ShowMessage/", 2072, 21, true);
#nullable restore
#line 46 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2093, item.MessageID, 2093, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Mesaj</a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 49 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Contact\Index.cshtml"
                                row++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
