#pragma checksum "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b60ab279e9d100f5cc48b77b4d89acb8dac472b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Question_ExamStart), @"mvc.1.0.view", @"/Areas/Member/Views/Question/ExamStart.cshtml")]
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
#line 3 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using OnlineExamProject.DTO.DTOs.AppUserDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using OnlineExamProject.DTO.DTOs.ExamDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using OnlineExamProject.DTO.DTOs.QuestionDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using OnlineExamProject.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using OnlineExamProject.Web.Areas.Member.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b60ab279e9d100f5cc48b77b4d89acb8dac472b3", @"/Areas/Member/Views/Question/ExamStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09c78ff5b35fdf87ec0117e5a300d622254d3697", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Question_ExamStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<QuestionListDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4 w-100 mx-auto p-3 shadow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
  
    ViewData["Title"] = "ExamStart";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b60ab279e9d100f5cc48b77b4d89acb8dac472b34847", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n\r\n        <h2 class=\"text-center fw-bold\">");
#nullable restore
#line 12 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
                                   Write(ViewBag.ExamTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h2>\r\n\r\n    </div>\r\n    <div class=\"row\">\r\n\r\n        <p>");
#nullable restore
#line 17 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
      Write(ViewBag.ExamDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n    </div>\r\n    <div class=\"bs-docs-section\">\r\n\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 23 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
             foreach (var item in Model)
            {
                index++;


#line default
#line hidden
#nullable disable
                WriteLiteral("                <div");
                BeginWriteAttribute("class", " class=\"", 565, "\"", 592, 3);
                WriteAttributeValue("", 573, "col-lg-6", 573, 8, true);
                WriteAttributeValue(" ", 581, "div-", 582, 5, true);
#nullable restore
#line 27 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
WriteAttributeValue("", 586, index, 586, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <div><p>");
#nullable restore
#line 28 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
                       Write(index);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ) ");
#nullable restore
#line 28 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
                                Write(item.QuestionText);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p></div>
                    <div class=""input-group mb-2"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">A )</div>
                        </div>
                        <input type=""text"" class=""form-control""");
                BeginWriteAttribute("id", " id=\"", 938, "\"", 961, 2);
                WriteAttributeValue("", 943, "firstOption-", 943, 12, true);
#nullable restore
#line 33 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
WriteAttributeValue("", 955, index, 955, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 962, "\"", 987, 1);
#nullable restore
#line 33 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
WriteAttributeValue("", 970, item.FirstOption, 970, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                    <div class=""input-group mb-2"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">B )</div>
                        </div>
                        <input type=""text"" class=""form-control""");
                BeginWriteAttribute("id", " id=\"", 1294, "\"", 1318, 2);
                WriteAttributeValue("", 1299, "secondOption-", 1299, 13, true);
#nullable restore
#line 39 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
WriteAttributeValue("", 1312, index, 1312, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1319, "\"", 1345, 1);
#nullable restore
#line 39 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
WriteAttributeValue("", 1327, item.SecondOption, 1327, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                    <div class=""input-group mb-2"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">C )</div>
                        </div>
                        <input type=""text"" class=""form-control""");
                BeginWriteAttribute("id", " id=\"", 1652, "\"", 1675, 2);
                WriteAttributeValue("", 1657, "thirtOption-", 1657, 12, true);
#nullable restore
#line 45 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
WriteAttributeValue("", 1669, index, 1669, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1676, "\"", 1701, 1);
#nullable restore
#line 45 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
WriteAttributeValue("", 1684, item.ThirtOption, 1684, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                    <div class=""input-group mb-2"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">D )</div>
                        </div>
                        <input type=""text"" class=""form-control""");
                BeginWriteAttribute("id", " id=\"", 2008, "\"", 2032, 2);
                WriteAttributeValue("", 2013, "fourthOption-", 2013, 13, true);
#nullable restore
#line 51 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
WriteAttributeValue("", 2026, index, 2026, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2033, "\"", 2059, 1);
#nullable restore
#line 51 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
WriteAttributeValue("", 2041, item.FourthOption, 2041, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"input-group mb-2\">\r\n                        <input type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 2208, "\"", 2233, 2);
                WriteAttributeValue("", 2213, "currentAnswer-", 2213, 14, true);
#nullable restore
#line 54 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
WriteAttributeValue("", 2227, index, 2227, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2234, "\"", 2261, 1);
#nullable restore
#line 54 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
WriteAttributeValue("", 2242, item.CurrentAnswer, 2242, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"input-group mb-2\">\r\n                        <input type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 2410, "\"", 2441, 2);
                WriteAttributeValue("", 2415, "selectCurrentAnswer-", 2415, 20, true);
#nullable restore
#line 57 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
WriteAttributeValue("", 2435, index, 2435, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 60 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Question\ExamStart.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>

        <div class=""row justify-content-center"">
            <div class=""col-lg-3"">
                <div class=""input-group mb-2"">
                    <button class=""btn btn-lg btn-success sinaviTamamla"" type=""button"">
                        SINAVI TAMAMLA
                    </button>
                </div>

            </div>
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
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"


    <script type=""text/javascript"">

        $(document).ready(function () {

            $("".div-1 input"").click(function () {
                $("".div-1 input"").css(""background-color"", """");
                $(this).css(""background-color"", ""grey"");
                var selectThisAnswer = $(this).attr(""id"");
                var selectThisAnswerId = ""#"" + selectThisAnswer;
                var selectAnswer = $(this).val();
                $(""#selectCurrentAnswer-1"").val(selectAnswer);

                $("".sinaviTamamla"").click(function () {
                    if ($(""#selectCurrentAnswer-1"").val() == $(""#currentAnswer-1"").val()) {
                        $("".div-1 input"").css(""background-color"", """");
                        $(selectThisAnswerId).css(""background-color"", ""green"");
                    }
                    else {
                        $("".div-1 input"").css(""background-color"", """");
                        $(selectThisAnswerId).css(""background-color"", ""red"");
               ");
                WriteLiteral(@"     }
                });
            });

            $("".div-2 input"").click(function () {
                $("".div-2 input"").css(""background-color"", """");
                $(this).css(""background-color"", ""grey"");
                var selectThisAnswer = $(this).attr(""id"");
                var selectThisAnswerId = ""#"" + selectThisAnswer;
                var selectAnswer = $(this).val();
                $(""#selectCurrentAnswer-2"").val(selectAnswer);

                $("".sinaviTamamla"").click(function () {
                    if ($(""#selectCurrentAnswer-2"").val() == $(""#currentAnswer-2"").val()) {
                        $("".div-2 input"").css(""background-color"", """");
                        $(selectThisAnswerId).css(""background-color"", ""green"");
                    }
                    else {
                        $("".div-2 input"").css(""background-color"", """");
                        $(selectThisAnswerId).css(""background-color"", ""red"");
                    }
                });
           ");
                WriteLiteral(@" });

            $("".div-3 input"").click(function () {
                $("".div-3 input"").css(""background-color"", """");
                $(this).css(""background-color"", ""grey"");
                var selectThisAnswer = $(this).attr(""id"");
                var selectThisAnswerId = ""#"" + selectThisAnswer;
                var selectAnswer = $(this).val();
                 $(""#selectCurrentAnswer-3"").val(selectAnswer);
                
                $("".sinaviTamamla"").click(function () {
                    if ($(""#selectCurrentAnswer-3"").val() == $(""#currentAnswer-3"").val()) {
                        $("".div-3 input"").css(""background-color"", """");
                        $(selectThisAnswerId).css(""background-color"", ""green"");
                    }
                    else {
                        $("".div-3 input"").css(""background-color"", """");
                        $(selectThisAnswerId).css(""background-color"", ""red"");
                    }
                });
               
                ");
                WriteLiteral(@"
            });

            $("".div-4 input"").click(function () {
                $("".div-4 input"").css(""background-color"", """");
                $(this).css(""background-color"", ""grey"");
                var selectThisAnswer = $(this).attr(""id"");
                var selectThisAnswerId = ""#"" + selectThisAnswer;
                var selectAnswer = $(this).val();
                $(""#selectCurrentAnswer-4"").val(selectAnswer);

                $("".sinaviTamamla"").click(function () {
                    if ($(""#selectCurrentAnswer-4"").val() == $(""#currentAnswer-4"").val()) {
                        $("".div-4 input"").css(""background-color"", """");
                        $(selectThisAnswerId).css(""background-color"", ""green"");
                    }
                    else {
                        $("".div-4 input"").css(""background-color"", """");
                        $(selectThisAnswerId).css(""background-color"", ""red"");
                    }
                });
            });

          
        ");
                WriteLiteral("});\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<QuestionListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
