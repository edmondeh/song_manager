#pragma checksum "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcdaf7f12ab040623a67ac74bb2dcad3fe944a0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artists_Index), @"mvc.1.0.view", @"/Views/Artists/Index.cshtml")]
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
#line 1 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\_ViewImports.cshtml"
using Songs_Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\_ViewImports.cshtml"
using Songs_Manager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\_ViewImports.cshtml"
using Songs_Manager.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\_ViewImports.cshtml"
using Songs_Manager.Data.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcdaf7f12ab040623a67ac74bb2dcad3fe944a0d", @"/Views/Artists/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f220136cf9098498f5c513a335a9c433e64569f", @"/Views/_ViewImports.cshtml")]
    public class Views_Artists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Artist>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Index.cshtml"
  
    ViewData["Title"] = "All Artists";
    string siteUrl = Context.Request.Scheme + System.Uri.SchemeDelimiter + Context.Request.Host.Value;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container m-t-80 p-r-75 p-l-75 bg-white"">
    <!-- <div class=""row"">
        <div class=""col"">
            <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Special title treatment</h5>
                <p class=""card-text"">With supporting text below as a natural lead-in to additional content.</p>
                <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
            </div>
            </div>
        </div>
    </div> -->
    <div class=""row"">
        <div class=""col-9"">

            <div class=""card mb-4"">
                <div class=""card-header bg-primary text-white"">
                    ");
#nullable restore
#line 24 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Index.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"card-body\">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 41 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Index.cshtml"
                         foreach (var artists in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mb-4 col-xs-6 col-md-4\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2009, "\"", 2046, 3);
#nullable restore
#line 43 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Index.cshtml"
WriteAttributeValue("", 2016, siteUrl, 2016, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2024, "/artists/", 2024, 9, true);
#nullable restore
#line 43 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Index.cshtml"
WriteAttributeValue("", 2033, artists.Slug, 2033, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img class=\"img-responsive img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 2123, "\"", 2129, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2130, "\"", 2149, 1);
#nullable restore
#line 44 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Index.cshtml"
WriteAttributeValue("", 2136, artists.Name, 2136, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                            <p><a");
            BeginWriteAttribute("href", " href=\"", 2220, "\"", 2257, 3);
#nullable restore
#line 46 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Index.cshtml"
WriteAttributeValue("", 2227, siteUrl, 2227, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2235, "/artists/", 2235, 9, true);
#nullable restore
#line 46 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Index.cshtml"
WriteAttributeValue("", 2244, artists.Slug, 2244, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Index.cshtml"
                                                                   Write(artists.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></p>\r\n                        </div>");
#nullable restore
#line 47 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Index.cshtml"
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                Pagination\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Artist>> Html { get; private set; }
    }
}
#pragma warning restore 1591
