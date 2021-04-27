#pragma checksum "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1d94475ba181b02ccc361f1e66de58ef439adb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artists_Show), @"mvc.1.0.view", @"/Views/Artists/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1d94475ba181b02ccc361f1e66de58ef439adb7", @"/Views/Artists/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f220136cf9098498f5c513a335a9c433e64569f", @"/Views/_ViewImports.cshtml")]
    public class Views_Artists_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArtistVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Show.cshtml"
  
    ViewData["Title"] = Model.Name;
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
                    <b>Artist</b>
                </div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-3"">
                            <img class=""rounded-circle border"" width=""145px"" height=""145px""");
            BeginWriteAttribute("src", " src=\"", 1101, "\"", 1133, 2);
#nullable restore
#line 29 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Show.cshtml"
WriteAttributeValue("", 1107, siteUrl, 1107, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1115, "/images/avatar.png", 1115, 18, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1134, "\"", 1151, 1);
#nullable restore
#line 29 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Show.cshtml"
WriteAttributeValue("", 1140, Model.Name, 1140, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <!-- <h1 class=""text-hide"" style=""background-image: url('https://wa1.narvii.com/static/img/user-icon-placeholder.png'); width: 125px; height: 125px;"">Artist Name</h1> -->
                        </div>
                        <div class=""col"">
                            <h2>");
#nullable restore
#line 33 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Show.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small class=\"font-weight-light\">");
#nullable restore
#line 33 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Show.cshtml"
                                                                        Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small></h2>
                            <i class=""fa fa-eye""></i> Views:  <b>{ $artist->getViews() }}</b> |
                            <i class=""fa fa-star""></i> Popular:
                            <b><span class=""badge badge-success"">Yes</span></b> |
                            <i class=""fa fa-music""></i> Genres
");
            WriteLiteral(@"                            <hr>
                            <!-- <p>Sharing buttons...  </p> -->
                            <!-- Social Button HTML -->
                            <!-- Twitter -->
                            <a href=""http://twitter.com/share?url=<URL>&text=<TEXT>&via=<VIA>"" target=""_blank"" class=""share-btn twitter"">
                                <i class=""fa fa-twitter""></i>
                            </a>
                            <!-- Google Plus -->
                            <a href=""https://plus.google.com/share?url=<BTN>"" target=""_blank"" class=""share-btn google-plus"">
                                <i class=""fa fa-google-plus""></i>
                            </a>
                            <!-- Facebook -->
                            <a href=""http://www.facebook.com/sharer/sharer.php?u=<URL>"" target=""_blank"" class=""share-btn facebook"">
                                <i class=""fa fa-facebook""></i>
                            </a>
                            <!");
            WriteLiteral(@"-- StumbleUpon (url, title) -->
                            <a href=""http://www.stumbleupon.com/submit?url=<URL>&title=<TITLE>"" target=""_blank"" class=""share-btn stumbleupon"">
                                <i class=""fa fa-stumbleupon""></i>
                            </a>
                            <!-- Reddit (url, title) -->
                            <a href=""http://reddit.com/submit?url=<URL>&title=<TITLE>"" target=""_blank"" class=""share-btn reddit"">
                                <i class=""fa fa-reddit""></i>
                            </a>
                            <!-- LinkedIn -->
                            <a href=""http://www.linkedin.com/shareArticle?url=<URL>&title=<TITLE>&summary=<SUMMARY>&source=<SOURCE_URL>"" target=""_blank"" class=""share-btn linkedin"">
                                <i class=""fa fa-linkedin""></i>
                            </a>
                            <!-- Email -->
                            <a href=""mailto:?subject=<SUBJECT&body=<BODY>"" target=""_blank"" ");
            WriteLiteral("class=\"share-btn email\">\r\n                                <i class=\"fa fa-envelope\"></i>\r\n                            </a>\r\n\r\n                            <hr>\r\n");
            WriteLiteral("                            ");
#nullable restore
#line 73 "D:\Visual Studio Projects\source\repos\Songs Manager\Songs Manager\Views\Artists\Show.cshtml"
                       Write(Model.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <hr>
                        </div>
                    </div>
                    <div class=""col"">
                        <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" id=""lyrics-tab"" data-toggle=""tab"" href=""#lyrics"" role=""tab"" aria-controls=""lyrics"" aria-selected=""true"">All lyrics</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" id=""albums-tab"" data-toggle=""tab"" href=""#albums"" role=""tab"" aria-controls=""albums"" aria-selected=""false"">All Albums</a>
                            </li>
                        </ul>
                        <div class=""tab-content"">
                            <div class=""tab-pane active"" id=""lyrics"" role=""tabpanel"" aria-labelledby=""lyrics-tab"">
                                <table class=""table table-striped table-hover table-sm mt-");
            WriteLiteral(@"4"">
                                    <thead>
                                        <tr>
                                            <th scope=""col""></th>
                                            <th scope=""col"">Song</th>
                                            <th scope=""col"">Year</th>
                                            <th scope=""col"">Album</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                            <div class=""tab-pane"" id=""albums"" role=""tabpanel"" aria-labelledby=""albums-tab"">h2</div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card mb-4"">
                <div class=""card-header bg-primary text-white"">
                    <b>Comments</b>
                </div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col"">
                            <p>Comment 1</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-3"">
            <div class=""card mb-4"">
                <div class=""card-header bg-primary text-white"">
                    Artist
                </div>
                <div class=""card-body"">
   ");
            WriteLiteral("                 <div class=\"row\">\r\n                        <div class=\"col\">\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            $(\'#myTab li:first-child a\').tab(\'show\')\r\n        })\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArtistVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
