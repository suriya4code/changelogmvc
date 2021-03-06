#pragma checksum "C:\Users\SURIYAPRAKASH\Source\repos\changelogmvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2e0e870ec53e202351f5ea3c98226f73694e7dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\SURIYAPRAKASH\Source\repos\changelogmvc\Views\_ViewImports.cshtml"
using changelogmvc;

#line default
#line hidden
#line 2 "C:\Users\SURIYAPRAKASH\Source\repos\changelogmvc\Views\_ViewImports.cshtml"
using changelogmvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e0e870ec53e202351f5ea3c98226f73694e7dd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e562399fdb19f5648ac2e58545d23374760a810b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<changes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\SURIYAPRAKASH\Source\repos\changelogmvc\Views\Home\Index.cshtml"
  

    string getClass(string type)
    {
        switch (type)
        {
            case "New Release":
                return "badge badge-pill badge-primary alligntop no-wrap";
            case "Fix":
                return "badge badge-pill badge-danger alligntop no-wrap";
            case "Update":
                return "badge badge-pill badge-success alligntop no-wrap";
            default:
                return "";
        }
    }

#line default
#line hidden
            WriteLiteral("\r\n");
#line 20 "C:\Users\SURIYAPRAKASH\Source\repos\changelogmvc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Change Log App";

#line default
#line hidden
            WriteLiteral(@"
<div class=""jumbotron jumpad"">
    <div class=""container"">
        <div>
        <h1 class=""display-5 page-header text-center font-weight-bolder"">Change Log Updates</h1>

        </div>

        <hr class=""my-2"">

        <div class=""row"">
            <table class=""table table-striped table-inverse table-responsive table-hover bg-light text-dark"">
                <thead class=""thead-dark display-5 text-center"">
                    <tr>
                        <th class=""no-wrap"">Title</th>
                        <th class=""no-wrap"">Update Type</th>
                        <th class=""no-wrap"">Update Time</th>
                        <th>Content</th>
                    </tr>
                </thead>

");
#line 44 "C:\Users\SURIYAPRAKASH\Source\repos\changelogmvc\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            WriteLiteral("                    <tr>\r\n                        <td class=\"no-wrap align-middle\">\r\n                            ");
#line 48 "C:\Users\SURIYAPRAKASH\Source\repos\changelogmvc\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            WriteLiteral("\r\n\r\n                        </td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 1559, "\"", 1589, 1);
#line 51 "C:\Users\SURIYAPRAKASH\Source\repos\changelogmvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 1567, getClass(item.Type), 1567, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            ");
#line 53 "C:\Users\SURIYAPRAKASH\Source\repos\changelogmvc\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            WriteLiteral("\r\n\r\n                        </td>\r\n                        <td class=\"no-wrap align-middle\">\r\n                            ");
#line 57 "C:\Users\SURIYAPRAKASH\Source\repos\changelogmvc\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UpdatedDate));

#line default
#line hidden
            WriteLiteral("\r\n\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#line 61 "C:\Users\SURIYAPRAKASH\Source\repos\changelogmvc\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#line 65 "C:\Users\SURIYAPRAKASH\Source\repos\changelogmvc\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<style>\r\n    .no-wrap {\r\n        white-space: nowrap;\r\n    }\r\n    \r\n.alligntop {\r\n    margin: 1rem;\r\n}\r\n.jumpad{\r\n    padding: 1rem 1rem;\r\n}\r\n</style>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<changes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
