#pragma checksum "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffc0ec3c638616398752875ab386b6f27884b1d1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffc0ec3c638616398752875ab386b6f27884b1d1", @"/Views/Home/demo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c01ccae0943be6b64b74e3531665c61fdbea0c89", @"/Views/_ViewImports.cshtml")]
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
#line 2 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
  
    Layout = "~/Views/Shared/_Layoutdemo.cshtml";
    List<Film> Films = ViewBag.films;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""slide-one-item home-slider owl-carousel"">

    <div class=""site-blocks-cover inner-page overlay"" style=""background-image: url(images/anhnen.jpg);"" data-aos=""fade"" data-stellar-background-ratio=""0.5"">
        <div class=""container"">
            <div class=""row align-items-center justify-content-center"">
                <div class=""col-md-6 text-center"" data-aos=""fade"">
                    <h1 class=""font-secondary  font-weight-bold text-uppercase""></h1>
                </div>
            </div>
        </div>
    </div>

    <div class=""site-blocks-cover inner-page overlay"" style=""background-image: url(images/anhnen1.jpg);"" data-aos=""fade"" data-stellar-background-ratio=""0.5"">
        <div class=""container"">
            <div class=""row align-items-center justify-content-center"">
                <div class=""col-md-7 text-center"" data-aos=""fade"">
                    <h1 class=""font-secondary font-weight-bold text-uppercase""></h1>
                </div>
            </div>
        <");
            WriteLiteral(@"/div>
    </div>
</div>

<div class=""warper-content"">
    <div class=""showtimes section--product-view"" style=""margin:50px!important"">
        <div class=""container row m-auto"">
            <div class=""col-5 text-right"">
                <h3 class=""js__active"">
                    <a href=""#"">LỊCH CHIẾU THEO TUẦN</a>
                </h3>
            </div>
            <div class=""col-2 text-center"">
                <h2>|</h2>
            </div>
            <div class=""col-5 text-left"">
                <h3>
                    <a href=""#"">LỊCH CHIẾU THEO NGÀY</a>
                </h3>
            </div>
        </div>
    </div>
</div>
<div class=""site-section "">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 text-center"">
                <span class=""caption d-block mb-2 font-secondary font-weight-bold"">Products &amp; Services</span>
                <h2 class=""site-section-heading text-uppercase text-center font-secondary"">Share Before You Do");
            WriteLiteral("wnload</h2>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12 block-13 nav-direction-white\">\r\n                <div class=\"nonloop-block-13 owl-carousel\" id=\"bodyhome\">\r\n");
#nullable restore
#line 61 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
                     if (@Films != null)
                    {
                        foreach (Film film in Films)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"media-image\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2632, "\"", 2662, 2);
            WriteAttributeValue("", 2639, "/Home/Film/", 2639, 11, true);
#nullable restore
#line 66 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
WriteAttributeValue("", 2650, film.FilmId, 2650, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2706, "\"", 2723, 1);
#nullable restore
#line 67 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
WriteAttributeValue("", 2712, film.Image, 2712, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" class=\"img-fluid\" style=\"width:350px; height:300px\">\r\n                                    <div class=\"media-image-body\" style=\"text-align:center\">\r\n                                        <h2 class=\"font-secondary text-uppercase\">");
#nullable restore
#line 69 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
                                                                             Write(film.FilmName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <p>");
#nullable restore
#line 70 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
                                      Write(film.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </a>\r\n                            </div>\r\n");
#nullable restore
#line 74 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>

        <div class=""row mb-5"">
            <div class=""col-md-12"" data-aos=""fade"">
                <h2 class=""site-section-heading text-center text-uppercase"">Recent Blog Posts</h2>
            </div>
        </div>

        <div class=""row"">

            <div class=""col-md-6 col-lg-4 mb-5"" data-aos=""fade-up"" data-aos-delay=""100"">
                <div class=""media-image"">
                    <a href=""single.html""><img src=""/images/avatar-01.jpg"" alt=""Image"" class=""img-fluid""></a>
                    <div class=""media-image-body"">
                        <h2 class=""font-secondary text-uppercase""><a href=""single.html"">Where Do You Learn HTML & CSS in 2019?</a></h2>
                        <span class=""d-block mb-3"">By James &mdash; Jan. 20, 2019</span>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Fuga, voluptate.</p>
                        <p><a href=""#"">Read More</a></p>
                    </");
            WriteLiteral("div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffc0ec3c638616398752875ab386b6f27884b1d110347", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 106 "C:\Users\User\Desktop\Cinema\Cinema.Web\Cinema.Web\Views\Home\demo.cshtml"
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
