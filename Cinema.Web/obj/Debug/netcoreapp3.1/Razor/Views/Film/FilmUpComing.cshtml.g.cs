#pragma checksum "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b43dec261cefcf0e3aa59779f272550ff2c39565"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_FilmUpComing), @"mvc.1.0.view", @"/Views/Film/FilmUpComing.cshtml")]
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
#line 1 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/_ViewImports.cshtml"
using Cinema.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/_ViewImports.cshtml"
using Cinema.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/_ViewImports.cshtml"
using Cinema.Web.Models.Film;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/_ViewImports.cshtml"
using Cinema.Web.Models.Showing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
using Cinema.Web.Models.CategoryFilm;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b43dec261cefcf0e3aa59779f272550ff2c39565", @"/Views/Film/FilmUpComing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05df60f70d347e751a51e2c46e3ca5a4c16d6653", @"/Views/_ViewImports.cshtml")]
    public class Views_Film_FilmUpComing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Film>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/film.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
  
    ViewData["Title"] = ViewBag.Title;
    //Layout = "~/Views/Shared/_ManagementLayout.cshtml";
    int CateId = ViewBag.CategoryId;
    CategoryFilm category = ViewBag.Category != null ? ViewBag.Category as CategoryFilm : new CategoryFilm();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card shadow mb-4\">\n    <div class=\"card-header row py-3\">\n        <input hidden");
            BeginWriteAttribute("value", " value=\"", 398, "\"", 413, 1);
#nullable restore
#line 12 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
WriteAttributeValue("", 406, CateId, 406, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"CategoryId\" />\n        <h4 id=\"filmclassification\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 485, "\"", 520, 2);
            WriteAttributeValue("", 492, "/film/FilmNowShowing/", 492, 21, true);
#nullable restore
#line 14 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
WriteAttributeValue("", 513, CateId, 513, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"textcustomblue\" id=\"filmnowshow\">Phim đang chiếu</a>  /\n            <a");
            BeginWriteAttribute("href", " href=\"", 599, "\"", 632, 2);
            WriteAttributeValue("", 606, "/Film/FilmScreened/", 606, 19, true);
#nullable restore
#line 15 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
WriteAttributeValue("", 625, CateId, 625, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"textcustomblue\" id=\"filmscreened\">Phim đã chiếu</a>  /\n            <a");
            BeginWriteAttribute("href", " href=\"", 710, "\"", 743, 2);
            WriteAttributeValue("", 717, "/Film/FilmUpComing/", 717, 19, true);
#nullable restore
#line 16 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
WriteAttributeValue("", 736, CateId, 736, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""textcustomred"" id=""filmupcoming"">Phim sắp chiếu</a>
        </h4>
    </div>
    <div class=""card-body"">
        <div class=""row form-group"" style=""padding-left:10px"">
            <div class=""ml-auto"" style=""padding-right:30px"">
            </div>
        </div>
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>Id</th>
                        <th>Tên phim</th>
                        <th>Tiêu đề</th>
                        <th>Đánh giá</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 35 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
                     if (Model != null)
                    {
                        foreach (Film film in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 40 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
                               Write(film.FilmId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1717, "\"", 1751, 2);
            WriteAttributeValue("", 1724, "/Film/FilmShow/", 1724, 15, true);
#nullable restore
#line 41 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
WriteAttributeValue("", 1739, film.FilmId, 1739, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"item\">");
#nullable restore
#line 41 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
                                                                                  Write(film.FilmName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n                                <td>");
#nullable restore
#line 42 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
                               Write(film.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 43 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
                               Write(film.AverageRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n");
#nullable restore
#line 45 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b43dec261cefcf0e3aa59779f272550ff2c395659612", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 54 "/Users/phanbaphap/Desktop/git/Cinema.Web/Cinema.Web/Views/Film/FilmUpComing.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Film>> Html { get; private set; }
    }
}
#pragma warning restore 1591
