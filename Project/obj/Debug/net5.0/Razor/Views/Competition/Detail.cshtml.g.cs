#pragma checksum "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8664c31d76cb3c2f7fc928b62c76f376b79b5f29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Competition_Detail), @"mvc.1.0.view", @"/Views/Competition/Detail.cshtml")]
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
#line 1 "F:\APTECH\WAD\Project\Project\Views\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\APTECH\WAD\Project\Project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8664c31d76cb3c2f7fc928b62c76f376b79b5f29", @"/Views/Competition/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    public class Views_Competition_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project.Models.Competition>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("site-searchform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
   
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""all-title-box"">
    <div class=""container text-center"">
        <h1>Competition</h1>
    </div>
</div>

<div id=""overviews"" class=""section wb"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-9 blog-post-single"">
                <div class=""blog-item"">
                    <div class=""image-blog"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 451, "\"", 477, 2);
            WriteAttributeValue("", 457, "/images/", 457, 8, true);
#nullable restore
#line 19 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
WriteAttributeValue("", 465, Model.Image, 465, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 478, "\"", 484, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\n                    </div>\n                    <div class=\"post-content\">\n                        <div class=\"post-date\">\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 657, "\"", 756, 5);
            WriteAttributeValue("", 667, "showInPopup(\'", 667, 13, true);
#nullable restore
#line 23 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
WriteAttributeValue("", 680, Url.Action("AddOrEdit", "Post", null, Context.Request.Scheme), 680, 62, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 742, "\',", 742, 2, true);
            WriteAttributeValue(" ", 744, "\'New", 745, 5, true);
            WriteAttributeValue(" ", 749, "Post\')", 750, 7, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-warning font-weight-bolder"" style=""cursor: pointer;"">Register</a>
                        </div>
                        <div class=""meta-info-blog"">
                            <span>
                                <i class=""fa fa-calendar""></i>
                                <span>
                                    ");
#nullable restore
#line 29 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
                               Write(Model.Date_Start.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 29 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
                                                                          Write(Model.Date_End.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </span>\n                            </span>\n                            <span>\n                                <i class=\"fa fa-stack-overflow\"></i>\n");
#nullable restore
#line 34 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
                                 if (Model.Status == true)
                                {
                                    ViewBag.Style = "text-success";
                                    ViewBag.Status = "Happenning";
                                }
                                else if (Model.Status == false)
                                {
                                    ViewBag.Style = "text-danger";
                                    ViewBag.Status = "Finished";
                                }
                                else
                                {
                                    ViewBag.Style = "text-warning";
                                    ViewBag.Status = "Not yet";
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span");
            BeginWriteAttribute("class", " class=\"", 2158, "\"", 2180, 1);
#nullable restore
#line 49 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
WriteAttributeValue("", 2166, ViewBag.Style, 2166, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    ");
#nullable restore
#line 50 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
                               Write(ViewBag.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </span>\n                            </span>\n                        </div>\n                        <div class=\"blog-title\">\n                            <h2><a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 2434, "\"", 2442, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
                                                Write(Model.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\n                        </div>\n                        <div class=\"blog-desc\">");
#nullable restore
#line 57 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
                                          Write(Model.Content.Trim());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>
            </div><!-- end col -->

            <div class=""col-lg-3 col-12 right-single"">
                <div class=""widget-search"">
                    <div class=""site-search-area"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8664c31d76cb3c2f7fc928b62c76f376b79b5f2910038", async() => {
                WriteLiteral(@"
                            <div>
                                <input class=""input-text form-control"" name=""search-k"" id=""search-k"" placeholder=""Search keywords..."" type=""text"">
                                <input id=""searchsubmit"" value=""Search"" type=""submit"">
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"widget-categories\">\n                    <h3 class=\"widget-title\">Competitions</h3>\n                    <ul>\n");
#nullable restore
#line 76 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
                         foreach (var item in Model.getAll())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3523, "\"", 3540, 2);
            WriteAttributeValue("", 3530, "./", 3530, 2, true);
#nullable restore
#line 78 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
WriteAttributeValue("", 3532, item.ID, 3532, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 78 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
                                            Write(item.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>");
#nullable restore
#line 78 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\n                            </div>\n                            <div class=\"widget-tags\">\n                                <h3 class=\"widget-title\">Participants</h3>\n                                <ul>\n");
#nullable restore
#line 84 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
                                     foreach (var item in Model.getAllPost(Model.ID))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a href=\"#\">");
#nullable restore
#line 86 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
                                   Write(item.getNameStudent(item.ID_Student));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>");
#nullable restore
#line 86 "F:\APTECH\WAD\Project\Project\Views\Competition\Detail.cshtml"
                                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                </div>\n            </div>\n        </div><!-- end row -->\n    </div><!-- end container -->\n</div><!-- end section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.Models.Competition> Html { get; private set; }
    }
}
#pragma warning restore 1591