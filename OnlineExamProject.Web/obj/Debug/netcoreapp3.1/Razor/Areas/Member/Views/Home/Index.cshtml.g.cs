#pragma checksum "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9ccd7c2b90a211a409e08955a92f6ad1ac83590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9ccd7c2b90a211a409e08955a92f6ad1ac83590", @"/Areas/Member/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09c78ff5b35fdf87ec0117e5a300d622254d3697", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ExamListDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveExam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExamStart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Question", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm examStart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\Index.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9ccd7c2b90a211a409e08955a92f6ad1ac835906471", async() => {
                WriteLiteral("<i class=\"fas fa-plus-circle mr-2\"></i> Yeni S??nav Ekle");
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
    <table id=""TblExam"" class=""table table-striped table-sm"" style=""background-color:none;"">
        <thead style=""background-image: linear-gradient(90deg,#dc307c,#5e62b0,#33b7e2);
   "">
            <tr>
                <th>#</th>
                <th>S??nav Ba??l??????</th>
                <th>Olu??turulma Tarihi</th>
                <th>S??nava Ba??la</th>
                <th>Sil</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {
                index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"td\">");
#nullable restore
#line 28 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\Index.cshtml"
                              Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"td\">");
#nullable restore
#line 29 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\Index.cshtml"
                              Write(item.ExamTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"td\">");
#nullable restore
#line 30 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\Index.cshtml"
                              Write(item.PostTime.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9ccd7c2b90a211a409e08955a92f6ad1ac835909754", async() => {
                WriteLiteral(" S??nav?? Ba??lat");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\Index.cshtml"
                                                                              WriteLiteral(item.ExamId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("text-");
#nullable restore
#line 33 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\Index.cshtml"
                                                                                                                   Write(index);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-text", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                       \r\n                    </td>\r\n                   \r\n\r\n                    <td>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1402, "\"", 1409, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\" data-toggle=\"modal\" data-target=\"#deleteScreen\" data-examid=\"");
#nullable restore
#line 40 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\Index.cshtml"
                                                                                                                          Write(item.ExamId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fas fa-times-circle mr-2\"></i> Sil</a>\r\n\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 45 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 50 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\Index.cshtml"

}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"p-3 text-center lead mt-4\">\r\n        <p class=\"lead\">\r\n            Herhangi bir s??nav bulunamad?? !\r\n        </p>\r\n\r\n    </div>\r\n");
#nullable restore
#line 61 "C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.Web\Areas\Member\Views\Home\Index.cshtml"
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
                S??nav?? Silmek istedi??inizden emin misiniz ?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hay??r Vazge??</button>
                <button id=""btnDelete"" type=""button"" class=""btn btn-primary"">Evet Sil</button>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">


        $(document).ready(function () {
            $('#TblExam tbody tr').css('background-color', 'rgba(0, 0, 0, 0.05)');
            $('#TblExam').DataTable({
                ""initComplete"": function () {
                    var api = this.api();
                    api.$('.td').click(function () {
                        api.search(this.innerHTML).draw();
                    });
                }

            });


            $(""#deleteScreen"").on(""show.bs.modal"", function (event) {
                let tetikleyenElement = $(event.relatedTarget);
                let id = tetikleyenElement.data(""examid"");

                $(""#btnDelete"").click(function () {
                    $.ajax({
                        type: ""POST"",
                        url: ""/Member/Home/DeleteExam/"" + id,
                        dataType: ""json"",
                        contentType: ""application/json; charset=utf-8;"",
                        success: function () {");
                WriteLiteral(@"
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
