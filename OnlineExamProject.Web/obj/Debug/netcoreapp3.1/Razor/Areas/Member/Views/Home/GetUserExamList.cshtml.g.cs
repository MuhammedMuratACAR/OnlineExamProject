#pragma checksum "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\GetUserExamList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9155bb01556041e41a3673162be51e62dc189f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Home_GetUserExamList), @"mvc.1.0.view", @"/Areas/Member/Views/Home/GetUserExamList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9155bb01556041e41a3673162be51e62dc189f6", @"/Areas/Member/Views/Home/GetUserExamList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09c78ff5b35fdf87ec0117e5a300d622254d3697", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Home_GetUserExamList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ExamListDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark btn-sm my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExamStart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\GetUserExamList.cshtml"
  
    ViewData["Title"] = "GetUserExamList";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\GetUserExamList.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9155bb01556041e41a3673162be51e62dc189f66216", async() => {
                WriteLiteral("<i class=\"fas fa-plus-circle mr-2\"></i> Yeni Sınav Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <table class=""table table-hover table-sm"">
        <thead>
            <tr>
                <th>#</th>
                <th>Sınav Başlığı</th>
                <th>OLuşturulma Tarihi</th>
                <th>Sınava Başla</th>
                <th>Sil</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\GetUserExamList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\GetUserExamList.cshtml"
                   Write(item.ExamTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\GetUserExamList.cshtml"
                   Write(item.PostTime.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9155bb01556041e41a3673162be51e62dc189f68985", async() => {
                WriteLiteral("<i class=\"fas fa-edit mr-2\"></i> Sınava Başla");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\GetUserExamList.cshtml"
                                                                           WriteLiteral(item.ExamId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n\r\n                    <td>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1073, "\"", 1080, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\" data-toggle=\"modal\" data-target=\"#deleteScreen\" data-examid=\"");
#nullable restore
#line 32 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\GetUserExamList.cshtml"
                                                                                                                          Write(item.ExamId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fas fa-times-circle mr-2\"></i> Sil</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\GetUserExamList.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 40 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\GetUserExamList.cshtml"

}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"p-3 text-center lead mt-4\">\r\n        <p class=\"lead\">\r\n            Herhangi bir sınav bulunamadı !\r\n        </p>\r\n\r\n    </div>\r\n");
#nullable restore
#line 51 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\GetUserExamList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Modal -->
<div class=""modal fade"" id=""deleteScreen"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">UYARI</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Sınavı Silmek istediğinizden emin misiniz ?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hayır Vazgeç</button>
                <button id=""btnSil"" type=""button"" class=""btn btn-primary"">Evet Sil</button>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">


        $(document).ready(function () {
            $(""#deleteScreen"").on(""show.bs.modal"", function (event) {
                let tetikleyenElement = $(event.relatedTarget);
                let id = tetikleyenElement.data(""examid"");

                $(""#btnSil"").click(function () {
                    $.ajax({
                        type: ""POST"",
                        url: ""/Member/Home/DeleteExam/""+id,
                        dataType: ""json"",
                        contentType: ""application/json; charset=utf-8;"",
                        success: function () {
                            window.location.reload();
                        },
                        error: function (error) {
                            alert(error.statusText);
                        }
                    })
                });
            })
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ExamListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591