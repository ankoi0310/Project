#pragma checksum "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6363ba7417ca074876f48ed50289b61e9783e58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student__ViewAll), @"mvc.1.0.view", @"/Views/Student/_ViewAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6363ba7417ca074876f48ed50289b61e9783e58", @"/Views/Student/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    public class Views_Student__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
  
    ViewBag.ID = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">
        <h3 class=""card-title"">DataTable with default features</h3>
    </div>
    <!-- /.card-header -->
    <div class=""card-body"">
        <table id=""example1"" class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>
                        No.
                    </th>
                    <th>
                        ");
#nullable restore
#line 19 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 22 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date_Of_Birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 25 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 28 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("/Username\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 31 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("/Username\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 34 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.ID_Class_Room));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1259, "\"", 1364, 5);
            WriteAttributeValue("", 1269, "showInPopup(\'", 1269, 13, true);
#nullable restore
#line 37 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
WriteAttributeValue("", 1282, Url.Action("AddOrEdit", "Student", null, Context.Request.Scheme), 1282, 65, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1347, "\',", 1347, 2, true);
            WriteAttributeValue(" ", 1349, "\'New", 1350, 5, true);
            WriteAttributeValue(" ", 1354, "Student\')", 1355, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\"><i class=\"fas fa-plus\"></i>&ensp;New Student</a>\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 42 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">\r\n");
#nullable restore
#line 46 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                          
                            ViewBag.ID++;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 49 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                   Write(ViewBag.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 55 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Date_Of_Birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 58 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                          
                            ViewBag.Gender = item.Gender ? "Male" : "Female";
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 61 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                   Write(ViewBag.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 64 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 67 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 70 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                   Write(Tools.GetClassroomName(item.ID_Class_Room));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2808, "\"", 2927, 5);
            WriteAttributeValue("", 2818, "showInPopup(\'", 2818, 13, true);
#nullable restore
#line 73 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
WriteAttributeValue("", 2831, Url.Action("AddOrEdit", "Student", new { item.ID }, Context.Request.Scheme), 2831, 76, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2907, "\',", 2907, 2, true);
            WriteAttributeValue(" ", 2909, "\'Update", 2910, 8, true);
            WriteAttributeValue(" ", 2917, "Student\')", 2918, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\"><i class=\"fas fa-pencil-alt\"></i> Edit</a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6363ba7417ca074876f48ed50289b61e9783e5811727", async() => {
                WriteLiteral("\r\n                            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                                                    WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 79 "F:\APTECH\WAD\Project\Project\Views\Student\_ViewAll.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <!-- /.card-body -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
