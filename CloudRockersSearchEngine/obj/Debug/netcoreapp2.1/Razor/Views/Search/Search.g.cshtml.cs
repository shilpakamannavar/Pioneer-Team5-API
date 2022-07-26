#pragma checksum "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83521893f5ba0f41d7aa6d2643ecde21b2a17ebf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Search), @"mvc.1.0.view", @"/Views/Search/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Search.cshtml", typeof(AspNetCore.Views_Search_Search))]
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
#line 1 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\_ViewImports.cshtml"
using CloudRockersSearchEngine;

#line default
#line hidden
#line 2 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\_ViewImports.cshtml"
using CloudRockersSearchEngine.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83521893f5ba0f41d7aa6d2643ecde21b2a17ebf", @"/Views/Search/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a70d9c6e566e241b5cc2405f7d43f0acb676622d", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CloudRockers.Domain.Models.SearchResultModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
  
    ViewData["Title"] = "Search";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 312, true);
            WriteLiteral(@"
<h2>Search</h2>
<div class=""search_wrap"">
    <input class=""form-control col-md-11"" type=""text"" placeholder=""Search"" aria-label=""Search"" id=""txtSearch"" />
    <button type=""submit"" class=""btn btn-primary col-md-1"" onclick=""btnSearch()"">
        Search
    </button>
</div>

<div class=""results_wrap"">
");
            EndContext();
#line 17 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(510, 72, true);
            WriteLiteral("        <div class=\"result_box\">\r\n            <div class=\"result_img\">\r\n");
            EndContext();
#line 21 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
                 if (item.FilePath.Contains(".png", StringComparison.OrdinalIgnoreCase))
                {

#line default
#line hidden
            BeginContext(691, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 713, "\"", 734, 1);
#line 23 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
WriteAttributeValue("", 720, item.FilePath, 720, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(735, 103, true);
            WriteLiteral(" target=\"_blank\">\r\n                        <img class=\"img-responsive result_img\" alt=\"image not found\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 838, "\"", 858, 1);
#line 24 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
WriteAttributeValue("", 844, item.FilePath, 844, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(859, 31, true);
            WriteLiteral(" />\r\n                    </a>\r\n");
            EndContext();
#line 26 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
                }
                else if (item.FilePath.Contains(".doc", StringComparison.OrdinalIgnoreCase) || item.FilePath.Contains(".docx", StringComparison.OrdinalIgnoreCase))
                {
                    var newPath = "https://docs.google.com/gview?url=" + item.FilePath + "&embedded=true";

#line default
#line hidden
            BeginContext(1201, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1223, "\"", 1238, 1);
#line 30 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
WriteAttributeValue("", 1230, newPath, 1230, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1239, 50, true);
            WriteLiteral(" target=\"_blank\">\r\n                        <iframe");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1289, "\"", 1303, 1);
#line 31 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
WriteAttributeValue("", 1295, newPath, 1295, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1304, 88, true);
            WriteLiteral(" style=\"width:.webkit-fill-available\" height=\"250\"></iframe>\r\n                    </a>\r\n");
            EndContext();
#line 33 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1452, 27, true);
            WriteLiteral("                    <iframe");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1479, "\"", 1499, 1);
#line 36 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
WriteAttributeValue("", 1485, item.FilePath, 1485, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1500, 62, true);
            WriteLiteral(" style=\"width:.webkit-fill-available\" height=\"250\"></iframe>\r\n");
            EndContext();
#line 37 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
                }

#line default
#line hidden
            BeginContext(1581, 171, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"searched_data\" id=\"divSearchedData\">\r\n                <ul>\r\n                    <li>\r\n                        <b>File Name : ");
            EndContext();
            BeginContext(1753, 13, false);
#line 43 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
                                  Write(item.FileName);

#line default
#line hidden
            EndContext();
            BeginContext(1766, 99, true);
            WriteLiteral(" </b>\r\n                    </li>\r\n                    <li>\r\n                        <b>File Path : ");
            EndContext();
            BeginContext(1866, 13, false);
#line 46 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
                                  Write(item.FilePath);

#line default
#line hidden
            EndContext();
            BeginContext(1879, 62, true);
            WriteLiteral(" </b>\r\n                    </li>\r\n                    <hr />\r\n");
            EndContext();
#line 49 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
                     if (string.IsNullOrEmpty(item.HighLightedText))
                    {

#line default
#line hidden
            BeginContext(2034, 58, true);
            WriteLiteral("                        <li>\r\n                            ");
            EndContext();
            BeginContext(2093, 16, false);
#line 52 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
                       Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2109, 33, true);
            WriteLiteral("\r\n                        </li>\r\n");
            EndContext();
#line 54 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2214, 28, true);
            WriteLiteral("                        <li>");
            EndContext();
            BeginContext(2243, 31, false);
#line 57 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
                       Write(Html.Raw(@item.HighLightedText));

#line default
#line hidden
            EndContext();
            BeginContext(2274, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 58 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
                    }

#line default
#line hidden
            BeginContext(2304, 59, true);
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 62 "C:\Users\bdadmin\source\repos\CloudRockersSearchEngine\CloudRockersSearchEngine\Views\Search\Search.cshtml"
    }

#line default
#line hidden
            BeginContext(2370, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CloudRockers.Domain.Models.SearchResultModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
