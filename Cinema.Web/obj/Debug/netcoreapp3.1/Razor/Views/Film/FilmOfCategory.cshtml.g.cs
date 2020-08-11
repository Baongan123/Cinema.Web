#pragma checksum "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmOfCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00bd42dbd1fa88bd3a267b849b9008e98e3f3b51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_FilmOfCategory), @"mvc.1.0.view", @"/Views/Film/FilmOfCategory.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web.Models.Film;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web.Models.Showing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmOfCategory.cshtml"
using Cinema.Web.Models.CategoryFilm;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00bd42dbd1fa88bd3a267b849b9008e98e3f3b51", @"/Views/Film/FilmOfCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e7eb3d3cce1bd07fb9281760a30cfbe6d64d4bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Film_FilmOfCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Film>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmAddEditEmployee"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/film.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmOfCategory.cshtml"
  
    ViewData["Title"] = ViewBag.Title;
    //Layout = "~/Views/Shared/_ManagementLayout.cshtml";
    int CateId = ViewBag.CategoryId;
    CategoryFilm category = ViewBag.Category != null ? ViewBag.Category as CategoryFilm : new CategoryFilm();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card shadow mb-4\">\r\n    <div class=\"card-header row py-3\">\r\n        <input hidden");
            BeginWriteAttribute("value", " value=\"", 409, "\"", 424, 1);
#nullable restore
#line 12 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmOfCategory.cshtml"
WriteAttributeValue("", 417, CateId, 417, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""CategoryId""/>
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
#line 30 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmOfCategory.cshtml"
                     if (Model != null)
                    {
                        foreach (Film film in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 35 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmOfCategory.cshtml"
                               Write(film.FilmId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1406, "\"", 1440, 2);
            WriteAttributeValue("", 1413, "/Film/FilmShow/", 1413, 15, true);
#nullable restore
#line 36 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmOfCategory.cshtml"
WriteAttributeValue("", 1428, film.FilmId, 1428, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"item\">");
#nullable restore
#line 36 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmOfCategory.cshtml"
                                                                                  Write(film.FilmName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmOfCategory.cshtml"
                               Write(film.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmOfCategory.cshtml"
                               Write(film.AverageRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmOfCategory.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<!-- Modal -->\r\n<div id=\"addEditFilm\" class=\"modal fade\" data-backdrop=\"false\" role=\"dialog\">\r\n    <div class=\"modal-dialog modal-lg\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00bd42dbd1fa88bd3a267b849b9008e98e3f3b519002", async() => {
                WriteLiteral(@"
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Add New Film</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
                <input hidden id=""FilmId"" name=""FilmId"">
                <div class=""modal-body"">
                    <div class=""row"">
                        <div class=""col-4"">
                            <div class=""row form-group"">
                                <div class=""col-12"">
                                    <img src=""/images/noavatar.png"" id=""Image"" width=""200"" height=""210"" />
                                    <input type=""file"" id=""FileUpload"" class=""custom-file"" accept=""image/*"" onchange=""film.uploadImage(this)"" />
                                </div>
                            </div>
                        </div>
                        <div class=""col-8"">
                            <div class=""row form-gro");
                WriteLiteral(@"up"">
                                <div class=""col-3"">
                                    <label>Tên phim</label>
                                </div>
                                <div class=""col-9"">
                                    <input type=""text"" id=""FilmName"" name=""FilmName"" class=""form-control"" data-rule-required=""true"">
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-3"">
                                    <label>Tiêu đề</label>
                                </div>
                                <div class=""col-9"">
                                    <input type=""text"" id=""Title"" name=""Title"" class=""form-control"" data-rule-required=""true"">
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-3"">
                      ");
                WriteLiteral(@"              <label>Thông tin</label>
                                </div>
                                <div class=""col-9"">
                                    <textarea cols=""100"" rows=""10"" style=""width:100%"" type=""text"" id=""Description"" name=""Description"" class=""form-control"" data-rule-required=""true""></textarea>
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-3"">
                                    <label>Link Trailer</label>
                                </div>
                                <div class=""col-9"">
                                    <input type=""text"" id=""Linktrailer"" name=""Linktrailer"" class=""form-control"" data-rule-required=""true"">
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-3"">
                         ");
                WriteLiteral(@"           <label>Loại phim</label>
                                </div>
                                <div class=""col-9"">
                                    <select class=""custom-select"" id=""Category"" name=""Category"">
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-info"" data-dismiss=""modal"">Đóng</button>
                    <a href=""javascript:;"" class=""btn btn-danger"" onclick=""film.create()"">Lưu</a>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00bd42dbd1fa88bd3a267b849b9008e98e3f3b5114486", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 122 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmOfCategory.cshtml"
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
                WriteLiteral("\r\n");
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
