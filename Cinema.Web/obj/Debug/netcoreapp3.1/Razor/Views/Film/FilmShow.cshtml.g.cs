<<<<<<< HEAD
#pragma checksum "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd3b040960a5d33e6883998fe5b430b8a4768725"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_FilmShow), @"mvc.1.0.view", @"/Views/Film/FilmShow.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web.Models.Film;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web.Models.Showing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web.Models.CategoryFilm;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd3b040960a5d33e6883998fe5b430b8a4768725", @"/Views/Film/FilmShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e7eb3d3cce1bd07fb9281760a30cfbe6d64d4bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Film_FilmShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:15px;width:100%;height:500px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar-01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmAddEditEmployee"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/filmshow.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmShow.cshtml"
  
    ViewData["Title"] = ViewBag.Title;
    Layout = "~/Views/Shared/_ManagementLayout.cshtml";
    int filmid = ViewBag.FilmId;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"showfilm\" style=\"border:2px solid\">\r\n    <input hidden id=\"FilmId\"");
            BeginWriteAttribute("value", " value=\"", 215, "\"", 230, 1);
#nullable restore
#line 8 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmShow.cshtml"
WriteAttributeValue("", 223, filmid, 223, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd3b040960a5d33e6883998fe5b430b8a47687256668", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-sm-6"">
            <div style=""padding:50px 5px"">
                <div class=""row form-group mt-10 justify-content-center mb-10"">
                    <a href=""javascript:;"" onclick=""film.get()"" class=""item""><i class=""zmdi zmdi-edit"" style=""font-size:20px""><u> Chỉnh sửa</u></i></a>
                    <span>&nbsp;&nbsp;&nbsp;||&nbsp;&nbsp;&nbsp;</span>
                    <a href=""javascript:;"" onclick=""film.delete()"" class=""item""><i style=""font-size:20px;color:red"" class=""zmdi zmdi-delete""><u> Xóa</u></i></a>
                </div>
                <div class=""row form-group mt-10"">
                    <div class=""col-3"">
                        <label style=""font-size:20px""><b><i>Tên phim:</i></b></label>
                    </div>
                    <div class=""col-9"" id=""FilmName"">
                    </div>
                </div>
                <div class=""row form-group"">
                    <div class=""col-3"">
                        <label styl");
            WriteLiteral(@"e=""font-size:20px""><b><i>Tiêu đề:</i></b></label>
                    </div>
                    <div class=""col-9"" id=""Title"">
                    </div>
                </div>
                <div class=""row form-group"">
                    <div class=""col-3"">
                        <label style=""font-size:20px""><b><i>Thông tin:</i></b></label>
                    </div>
                    <div class=""col-9"" id=""Description"">
                    </div>
                </div>
                <div class=""row form-group"">
                    <div class=""col-3"">
                        <label style=""font-size:20px""><b><i>Loại phim:</i></b></label>
                    </div>
                    <div class=""col-9"" id=""CategoryFilm"">
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container text-center mt-10"">
    <h2 style=""margin:20px"">Trailer</h2>
    <iframe width=""1000"" height=""600"" id=""trailer""");
            BeginWriteAttribute("src", " src=\"", 2423, "\"", 2429, 0);
            EndWriteAttribute();
            WriteLiteral(@" frameborder=""0""
            allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
</div>
<!-- Modal -->
<div id=""EditFilm"" class=""modal fade"" data-backdrop=""false"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd3b040960a5d33e6883998fe5b430b8a476872510435", async() => {
                WriteLiteral(@"
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Add New Employee</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
                <div class=""modal-body"">
                    <div class=""row"">
                        <div class=""col-4"">
                            <div class=""row form-group"">
                                <div class=""col-12"">
                                    <img src=""/images/noavatar.png"" id=""ImageUd"" width=""200"" height=""210"" />
                                    <input type=""file"" id=""FileUpload"" class=""custom-file"" accept=""image/*"" onchange=""film.uploadImage(this)"" />
                                </div>
                            </div>
                        </div>
                        <div class=""col-8"">
                            <div class=""row form-group"">
                                <div class=""co");
                WriteLiteral(@"l-3"">
                                    <label>Tên phim</label>
                                </div>
                                <div class=""col-9"">
                                    <input type=""text"" id=""FilmNameUd"" name=""FilmNameUd"" class=""form-control"" data-rule-required=""true"">
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-3"">
                                    <label>Tiêu đề</label>
                                </div>
                                <div class=""col-9"">
                                    <input type=""text"" id=""TitleUd"" name=""TitleUd"" class=""form-control"" data-rule-required=""true"">
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-3"">
                                    <label>Thông tin</label>
    ");
                WriteLiteral(@"                            </div>
                                <div class=""col-9"">
                                    <textarea cols=""100"" rows=""10"" style=""width:100%"" type=""text"" id=""DescriptionUd"" name=""DescriptionUd"" class=""form-control"" data-rule-required=""true""></textarea>
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-3"">
                                    <label>Link Trailer</label>
                                </div>
                                <div class=""col-9"">
                                    <input type=""text"" id=""LinktrailerUd"" name=""LinktrailerUd"" class=""form-control"" data-rule-required=""true"">
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-3"">
                                    <label>Loại phim</label>");
                WriteLiteral(@"
                                </div>
                                <div class=""col-9"">
                                    <select class=""custom-select"" id=""CategoryUd"" name=""CategoryUd"">
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-info"" data-dismiss=""modal"">Đóng</button>
                    <a href=""javascript:;"" class=""btn btn-danger"" onclick=""film.update()"">Lưu</a>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd3b040960a5d33e6883998fe5b430b8a476872515888", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 132 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmShow.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
=======
#pragma checksum "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "450ebc1636011e92137cc9d054847b2c329b33f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_FilmShow), @"mvc.1.0.view", @"/Views/Film/FilmShow.cshtml")]
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
#line 5 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web.Models.CategoryFilm;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"450ebc1636011e92137cc9d054847b2c329b33f5", @"/Views/Film/FilmShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e7eb3d3cce1bd07fb9281760a30cfbe6d64d4bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Film_FilmShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:15px;width:100%;height:500px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar-01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmAddEditEmployee"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/filmshow.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmShow.cshtml"
  
    ViewData["Title"] = ViewBag.Title;
    Layout = "~/Views/Shared/_ManagementLayout.cshtml";
    int filmid = ViewBag.FilmId;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"showfilm\" style=\"border:2px solid\">\r\n    <input hidden id=\"FilmId\"");
            BeginWriteAttribute("value", " value=\"", 215, "\"", 230, 1);
#nullable restore
#line 8 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmShow.cshtml"
WriteAttributeValue("", 223, filmid, 223, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "450ebc1636011e92137cc9d054847b2c329b33f56660", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-sm-6"">
            <div style=""padding:50px 5px"">
                <div class=""row form-group mt-10 justify-content-center mb-10"">
                    <a href=""javascript:;"" onclick=""film.get()"" class=""item""><i class=""zmdi zmdi-edit"" style=""font-size:20px""><u> Chỉnh sửa</u></i></a>
                    <span>&nbsp;&nbsp;&nbsp;||&nbsp;&nbsp;&nbsp;</span>
                    <a href=""javascript:;"" onclick=""film.delete()"" class=""item""><i style=""font-size:20px;color:red"" class=""zmdi zmdi-delete""><u> Xóa</u></i></a>
                </div>
                <div class=""row form-group mt-10"">
                    <div class=""col-3"">
                        <label style=""font-size:20px""><b><i>Tên phim:</i></b></label>
                    </div>
                    <div class=""col-9"" id=""FilmName"">
                    </div>
                </div>
                <div class=""row form-group"">
                    <div class=""col-3"">
                        <label styl");
            WriteLiteral(@"e=""font-size:20px""><b><i>Tiêu đề:</i></b></label>
                    </div>
                    <div class=""col-9"" id=""Title"">
                    </div>
                </div>
                <div class=""row form-group"">
                    <div class=""col-3"">
                        <label style=""font-size:20px""><b><i>Thông tin:</i></b></label>
                    </div>
                    <div class=""col-9"" id=""Description"">
                    </div>
                </div>
                <div class=""row form-group"">
                    <div class=""col-3"">
                        <label style=""font-size:20px""><b><i>Loại phim:</i></b></label>
                    </div>
                    <div class=""col-9"" id=""CategoryFilm"">
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container text-center mt-10"">
    <h2 style=""margin:20px"">Trailer</h2>
    <iframe width=""1000"" height=""600"" id=""trailer""");
            BeginWriteAttribute("src", " src=\"", 2423, "\"", 2429, 0);
            EndWriteAttribute();
            WriteLiteral(@" frameborder=""0""
            allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
</div>
<!-- Modal -->
<div id=""addEditFilm"" class=""modal fade"" data-backdrop=""false"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "450ebc1636011e92137cc9d054847b2c329b33f510430", async() => {
                WriteLiteral(@"
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Update Film</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
                <div class=""modal-body"">
                    <div class=""row"">
                        <div class=""col-4"">
                            <div class=""row form-group"">
                                <div class=""col-12"">
                                    <img src=""/images/noavatar.png"" id=""ImageUd"" width=""200"" height=""210"" />
                                    <input type=""file"" id=""FileUpload"" class=""custom-file"" accept=""image/*"" onchange=""film.uploadImage(this)"" />
                                </div>
                            </div>
                        </div>
                        <div class=""col-8"">
                            <div class=""row form-group"">
                                <div class=""col-3"">");
                WriteLiteral(@"
                                    <label>Tên phim</label>
                                </div>
                                <div class=""col-9"">
                                    <input type=""text"" id=""FilmNameUd"" name=""FilmNameUd"" class=""form-control"" data-rule-required=""true"">
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-3"">
                                    <label>Tiêu đề</label>
                                </div>
                                <div class=""col-9"">
                                    <input type=""text"" id=""TitleUd"" name=""TitleUd"" class=""form-control"" data-rule-required=""true"">
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-3"">
                                    <label>Thông tin</label>
         ");
                WriteLiteral(@"                       </div>
                                <div class=""col-9"">
                                    <textarea cols=""100"" rows=""10"" style=""width:100%"" type=""text"" id=""DescriptionUd"" name=""DescriptionUd"" class=""form-control"" data-rule-required=""true""></textarea>
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-3"">
                                    <label>Link Trailer</label>
                                </div>
                                <div class=""col-9"">
                                    <input type=""text"" id=""LinktrailerUd"" name=""LinktrailerUd"" class=""form-control"" data-rule-required=""true"">
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-3"">
                                    <label>Loại phim</label>
    ");
                WriteLiteral(@"                            </div>
                                <div class=""col-9"">
                                    <select class=""custom-select"" id=""CategoryUd"" name=""CategoryUd"">
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-info"" data-dismiss=""modal"">Đóng</button>
                    <a href=""javascript:;"" class=""btn btn-danger"" onclick=""film.update()"">Lưu</a>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "450ebc1636011e92137cc9d054847b2c329b33f515878", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 132 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Film\FilmShow.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
>>>>>>> Deverloper
