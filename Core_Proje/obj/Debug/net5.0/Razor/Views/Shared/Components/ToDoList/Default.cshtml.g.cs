#pragma checksum "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\ToDoList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49093a7971d69a4364596c1e999807c6349119bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ToDoList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ToDoList/Default.cshtml")]
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
#line 1 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\ToDoList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49093a7971d69a4364596c1e999807c6349119bd", @"/Views/Shared/Components/ToDoList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ToDoList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ToDo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-md-12 col-xl-4 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yapılacaklar Listesi</h4>
            <div class=""add-items d-flex"">
                <input type=""text"" class=""form-control todo-list-input"" placeholder=""enter task.."">
                <button class=""add btn btn-primary todo-list-add-btn"">Ekle</button>
            </div>
            <div class=""list-wrapper"">
                <ul class=""d-flex flex-column-reverse text-white todo-list todo-list-custom"">
");
#nullable restore
#line 14 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\ToDoList\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 713, "\"", 763, 1);
#nullable restore
#line 16 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\ToDoList\Default.cshtml"
WriteAttributeValue("", 721, item.Status == false ? "completed" : "", 721, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"form-check form-check-primary\">\r\n                                <label class=\"form-check-label\">\r\n                                    <input class=\"checkbox\" type=\"checkbox\"> ");
#nullable restore
#line 19 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\ToDoList\Default.cshtml"
                                                                        Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </label>\r\n                            </div>\r\n                            <i class=\"remove mdi mdi-close-box\"></i>\r\n                        </li>\r\n");
#nullable restore
#line 24 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\ToDoList\Default.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ToDo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
