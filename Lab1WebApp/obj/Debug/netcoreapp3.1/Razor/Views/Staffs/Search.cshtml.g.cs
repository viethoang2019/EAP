#pragma checksum "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f936cfc439948719826f9a1ced21b3200fdc5c98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staffs_Search), @"mvc.1.0.view", @"/Views/Staffs/Search.cshtml")]
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
#line 1 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\_ViewImports.cshtml"
using Lab1WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\_ViewImports.cshtml"
using Lab1WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f936cfc439948719826f9a1ced21b3200fdc5c98", @"/Views/Staffs/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb1d98807960ca02c986985b8f3d090b1e421017", @"/Views/_ViewImports.cshtml")]
    public class Views_Staffs_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab1WebApp.Models.Staff>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Search</h1>\r\n\r\n<br />\r\n        ");
#nullable restore
#line 10 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
   Write(Html.ActionLink("Back to List", "Index", "Staffs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<div>\r\n    <h3> Search By Name</h3>\r\n");
#nullable restore
#line 14 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"text\" name=\"name\" placeholder=\"Enter any character....\" />\r\n");
            WriteLiteral("        <input type=\"submit\" value=\"Search\" />\r\n");
#nullable restore
#line 20 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<br />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 59 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
               Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 60 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\hoang\source\repos\EAP\Lab1WebApp\Views\Staffs\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab1WebApp.Models.Staff>> Html { get; private set; }
    }
}
#pragma warning restore 1591
