#pragma checksum "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea7eeeed34118607e4f94354067987aed6265e32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutList/Default.cshtml")]
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
#line 1 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea7eeeed34118607e4f94354067987aed6265e32", @"/Views/Shared/Components/AboutList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AboutList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"section pt-4 px-3 px-lg-4\" id=\"about\">\r\n        <div class=\"container-narrow\">\r\n");
#nullable restore
#line 7 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <h2 class=\"h4 my-2\">");
#nullable restore
#line 11 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>");
#nullable restore
#line 12 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <div class=""row mt-3"">
                            <div class=""col-sm-2"">
                                <div class=""pb-1"">Yaş:</div>
                            </div>
                            <div class=""col-sm-10"">
                                <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 18 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                       Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                            <div class=""col-sm-2"">
                                <div class=""pb-1"">Email:</div>
                            </div>
                            <div class=""col-sm-10"">
                                <div class=""pb-1 fw-bolder""><a");
            BeginWriteAttribute("href", " href=\"", 1028, "\"", 1052, 2);
            WriteAttributeValue("", 1035, "mailto:", 1035, 7, true);
#nullable restore
#line 24 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
WriteAttributeValue("", 1042, item.Mail, 1042, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none\">");
#nullable restore
#line 24 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                                                                                Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></div>
                            </div>
                            <div class=""col-sm-2"">
                                <div class=""pb-1"">Telefon:</div>
                            </div>
                            <div class=""col-sm-10"">
                                <div class=""pb-1 fw-bolder""><a");
            BeginWriteAttribute("href", " href=\"", 1410, "\"", 1432, 2);
            WriteAttributeValue("", 1417, "tel:", 1417, 4, true);
#nullable restore
#line 30 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
WriteAttributeValue("", 1421, item.Phone, 1421, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none\">");
#nullable restore
#line 30 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                                                                              Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></div>
                            </div>
                            <div class=""col-sm-2"">
                                <div class=""pb-1"">Adres:</div>
                            </div>
                            <div class=""col-sm-10"">
                                <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 36 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                       Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-5 offset-md-1\" data-aos=\"fade-left\" data-aos-delay=\"100\"><img class=\"avatar img-fluid mt-2\"");
            BeginWriteAttribute("src", " src=\"", 2034, "\"", 2066, 2);
            WriteAttributeValue("", 2040, "/aboutImage/", 2040, 12, true);
#nullable restore
#line 40 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
WriteAttributeValue("", 2052, item.ImageUrl, 2052, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" height=\"400\" alt=\"Sinan Sarıçayır\" /></div>\r\n                </div>\r\n");
#nullable restore
#line 42 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; }
    }
}
#pragma warning restore 1591
