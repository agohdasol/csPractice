#pragma checksum "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d639bd73be2362bf2a5b8d1f505b1727151c3643"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CommunityCamp_ComCampAdmin), @"mvc.1.0.view", @"/Views/CommunityCamp/ComCampAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CommunityCamp/ComCampAdmin.cshtml", typeof(AspNetCore.Views_CommunityCamp_ComCampAdmin))]
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
#line 1 "D:\csPractice\DotNetNote\Views\_ViewImports.cshtml"
using DotNetNote;

#line default
#line hidden
#line 2 "D:\csPractice\DotNetNote\Views\_ViewImports.cshtml"
using DotNetNote.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d639bd73be2362bf2a5b8d1f505b1727151c3643", @"/Views/CommunityCamp/ComCampAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cb532820678d07923d8a33ab80093736add67a", @"/Views/_ViewImports.cshtml")]
    public class Views_CommunityCamp_ComCampAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CommunityCampJoinMember>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CommunityCamp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
   
  ViewData["Title"] = "커뮤니티 캠프";

#line default
#line hidden
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(82, 23, true);
            WriteLiteral("\r\n<h2>참가자 리스트</h2> \r\n\r\n");
            EndContext();
            BeginContext(105, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b222f79d8094f0289488c283c509dd0", async() => {
                BeginContext(180, 7, true);
                WriteLiteral("참가 등록하기");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(191, 220, true);
            WriteLiteral("\r\n<hr />\r\n\r\n<table class=\"table table-bordered table-hover table-condensed table-responsive table-striped\">\r\n  <tr>\r\n    <th>커뮤니티</th>\r\n    <th>이름</th>\r\n    <th>연락처</th>\r\n    <th>이메일</th>\r\n    <th>티셔츠 사이즈</th>\r\n  </tr>\r\n");
            EndContext();
#line 20 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
   foreach(var members in Model)
  {

#line default
#line hidden
            BeginContext(450, 20, true);
            WriteLiteral("    <tr>\r\n      <td>");
            EndContext();
            BeginContext(471, 21, false);
#line 23 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
     Write(members.CommunityName);

#line default
#line hidden
            EndContext();
            BeginContext(492, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(510, 12, false);
#line 24 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
     Write(members.Name);

#line default
#line hidden
            EndContext();
            BeginContext(522, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(540, 14, false);
#line 25 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
     Write(members.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(554, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(572, 13, false);
#line 26 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
     Write(members.Email);

#line default
#line hidden
            EndContext();
            BeginContext(585, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(603, 12, false);
#line 27 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
     Write(members.Size);

#line default
#line hidden
            EndContext();
            BeginContext(615, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 29 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
  }

#line default
#line hidden
            BeginContext(638, 514, true);
            WriteLiteral(@"</table>

<div class=""container"">
  <div class=""row"">
    <div class=""col-md-12"">
      <div class=""panel panel-default"">
        <div class=""panel-heading"">ASP.NET Korea 참여가 리스트</div>
        <div class=""panel-body"">
          <table class=""table table-bordered table-hover table-condensed table-responsive table-striped"">
            <tr>
              <th>커뮤니티</th>
              <th>이름</th>
              <th>연락처</th>
              <th>이메일</th>
              <th>티셔츠 사이즈</th>
            </tr>
");
            EndContext();
#line 46 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
             foreach(var aspnetkorea in Model.Where(m=>m.CommunityName=="ASP.NET Korea").OrderBy(m => m.Id).Take(15))
            {

#line default
#line hidden
            BeginContext(1286, 32, true);
            WriteLiteral("          <tr>\r\n            <td>");
            EndContext();
            BeginContext(1319, 25, false);
#line 49 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
           Write(aspnetkorea.CommunityName);

#line default
#line hidden
            EndContext();
            BeginContext(1344, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1368, 16, false);
#line 50 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
           Write(aspnetkorea.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1384, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1408, 18, false);
#line 51 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
           Write(aspnetkorea.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(1426, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1450, 17, false);
#line 52 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
           Write(aspnetkorea.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1467, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1491, 16, false);
#line 53 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
           Write(aspnetkorea.Size);

#line default
#line hidden
            EndContext();
            BeginContext(1507, 24, true);
            WriteLiteral("</td>\r\n          </tr>\r\n");
            EndContext();
#line 55 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
            }

#line default
#line hidden
            BeginContext(1546, 514, true);
            WriteLiteral(@"          </table>
        </div>
      </div>
    </div>
    <div class=""col-md-12"">
      <div class=""panel panel-default"">
        <div class=""panel-heading"">Taeyo.Net 참여자 리스트</div>
        <div class=""panel-body"">
          <table class=""table table-bordered table-hover table-condensed table-responsive table-striped"">
            <tr>
              <th>커뮤니티</th>
              <th>이름</th>
              <th>연락처</th>
              <th>이메일</th>
              <th>티셔츠 사이즈</th>
            </tr>
");
            EndContext();
#line 72 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
             foreach (var taeyonet in Model.Where(m => m.CommunityName == "Taeyo.Net").OrderBy(m => m.Id).Take(15))
            {

#line default
#line hidden
            BeginContext(2192, 40, true);
            WriteLiteral("              <tr>\r\n                <td>");
            EndContext();
            BeginContext(2233, 22, false);
#line 75 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
               Write(taeyonet.CommunityName);

#line default
#line hidden
            EndContext();
            BeginContext(2255, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2283, 13, false);
#line 76 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
               Write(taeyonet.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2296, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2324, 15, false);
#line 77 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
               Write(taeyonet.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(2339, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2367, 14, false);
#line 78 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
               Write(taeyonet.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2381, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2409, 13, false);
#line 79 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
               Write(taeyonet.Size);

#line default
#line hidden
            EndContext();
            BeginContext(2422, 28, true);
            WriteLiteral("</td>\r\n              </tr>\r\n");
            EndContext();
#line 81 "D:\csPractice\DotNetNote\Views\CommunityCamp\ComCampAdmin.cshtml"
            }

#line default
#line hidden
            BeginContext(2465, 78, true);
            WriteLiteral("          </table>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CommunityCampJoinMember>> Html { get; private set; }
    }
}
#pragma warning restore 1591
