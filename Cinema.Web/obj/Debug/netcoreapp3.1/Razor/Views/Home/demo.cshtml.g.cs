#pragma checksum "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0ee6d6d2e987b58f0c49da1ed8aa52846b7111d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_demo), @"mvc.1.0.view", @"/Views/Home/demo.cshtml")]
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
#nullable restore
#line 6 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web.Models.Event;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0ee6d6d2e987b58f0c49da1ed8aa52846b7111d", @"/Views/Home/demo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0735799183de5b5d0dbf04c25b153c14b309e0b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_demo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/home.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
  
    Layout = "~/Views/Shared/_Layoutdemo.cshtml";
    List<Film> Films = ViewBag.films;
    List<EventDelete> banners = ViewBag.banners;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"homebody\">\r\n        <div class=\"slide-one-item home-slider owl-carousel\">\r\n");
#nullable restore
#line 9 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
             if (banners != null)
            {
                foreach (EventDelete ev in banners)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
                     if (ev.IsDeleted==false)
                    {
                        var @link = (ev.LinkEvent == "") ? "#" : ev.LinkEvent;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=", 535, "", 546, 1);
#nullable restore
#line 16 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
WriteAttributeValue("", 541, link, 541, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"site-blocks-cover inner-page overlay\" id=\"imgevent\"");
            BeginWriteAttribute("style", " style=\"", 640, "\"", 686, 4);
            WriteAttributeValue("", 648, "background-image:", 648, 17, true);
            WriteAttributeValue(" ", 665, "url(", 666, 5, true);
#nullable restore
#line 17 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
WriteAttributeValue("", 670, ev.ImageEvent, 670, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 684, ");", 684, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" data-aos=""fade"" data-stellar-background-ratio=""0.5"">
                                <div class=""container"">
                                    <div class=""row align-items-center justify-content-center"">
                                        <div class=""col-md-6 text-center"" data-aos=""fade"">
                                            <h1 class=""font-secondary  font-weight-bold text-uppercase""></h1>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </a>
");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
                     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
                      
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <section style=""padding-top:40px"">

            <div class=""container row m-auto"">
                <div class=""col-5 text-right"">
                    <h3 class=""js__active"">
                        <a href=""/Home/demo"">LỊCH CHIẾU THEO PHIM</a>
                    </h3>
                </div>
                <div class=""col-2 text-center"">
                    <h2>|</h2>
                </div>
                <div class=""col-5 text-left"">
                    <h3>
                        <a href=""/Home/FilmOfDate"">LỊCH CHIẾU THEO NGÀY</a>
                    </h3>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-md-12 block-13 nav-direction-white"">
                    <div class=""nonloop-block-13 owl-carousel"" id=""bodyhome"">
");
#nullable restore
#line 54 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
                         if (@Films != null)
                        {
                            foreach (Film film in Films)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"media-image\" style=\"justify-content: center;text-align:center\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2536, "\"", 2566, 2);
            WriteAttributeValue("", 2543, "/Home/Film/", 2543, 11, true);
#nullable restore
#line 59 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
WriteAttributeValue("", 2554, film.FilmId, 2554, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 2614, "\"", 2631, 1);
#nullable restore
#line 60 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
WriteAttributeValue("", 2620, film.Image, 2620, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Image"" class=""img-fluid"" style=""width:100%;height:400px;padding:0px 15%"">
                                        <div class=""media-image-body"" style=""text-align:center"">
                                            <h2 class=""font-secondary text-uppercase"">");
#nullable restore
#line 62 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
                                                                                 Write(film.FilmName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>                                           \r\n                                            <button");
            BeginWriteAttribute("href", " href=\"", 3012, "\"", 3042, 2);
            WriteAttributeValue("", 3019, "/Home/Film/", 3019, 11, true);
#nullable restore
#line 63 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
WriteAttributeValue("", 3030, film.FilmId, 3030, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" id=""buttonve"" class=""btn btn-primary""><i class=""fa fa-ticket-alt"" style=""transform: rotate(135deg);""></i> MUA VÉ</button>
                                        </div>
                                    </a>
                                </div>
");
#nullable restore
#line 67 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <h2 style=\"text-align:center;color:#007bff\">PHIM HOT</h2>\r\n            <div class=\"row\" id=\"filmsbyrate\">\r\n            </div>\r\n        </section>\r\n    </div>   \r\n\r\n");
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0ee6d6d2e987b58f0c49da1ed8aa52846b7111d11661", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 135 "C:\Users\Admin\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
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
            WriteLiteral("\r\n");
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
