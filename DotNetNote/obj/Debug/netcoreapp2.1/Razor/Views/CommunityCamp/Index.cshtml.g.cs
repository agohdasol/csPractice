#pragma checksum "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18383c759a75c9060cf40ba399f4fcfcb5634823"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CommunityCamp_Index), @"mvc.1.0.view", @"/Views/CommunityCamp/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CommunityCamp/Index.cshtml", typeof(AspNetCore.Views_CommunityCamp_Index))]
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
#line 1 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
using DotNetNote.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18383c759a75c9060cf40ba399f4fcfcb5634823", @"/Views/CommunityCamp/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cb532820678d07923d8a33ab80093736add67a", @"/Views/_ViewImports.cshtml")]
    public class Views_CommunityCamp_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CommunityCampJoinMember>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CommunityCamp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("취소"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
   
  ViewData["Title"] = "커뮤니티 캠프";

#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(111, 43, true);
            WriteLiteral("\r\n<h1>커뮤니티 캠프 테스트</h1> \r\n<h2>참가자 리스트</h2>\r\n");
            EndContext();
            BeginContext(154, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e4e5f9ed1284eea8377f73233f70a9b", async() => {
                BeginContext(229, 7, true);
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
            BeginContext(240, 190, true);
            WriteLiteral("\r\n<hr />\r\n\r\n<div class=\"row\">\r\n  <div class=\"col-md-6\">\r\n    <div class=\"panel panel-default\">\r\n      <div class=\"panel-heading\">ASP.NET Korea 참여자 리스트</div>\r\n      <div class=\"panel-body\">\r\n");
            EndContext();
#line 19 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
         foreach(var aspnetkorea in Model.Where(m=>m.CommunityName=="ASP.NET Korea").OrderBy(m => m.Id).Take(15))
        {

#line default
#line hidden
            BeginContext(556, 46, true);
            WriteLiteral("          <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(603, 16, false);
#line 22 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
       Write(aspnetkorea.Name);

#line default
#line hidden
            EndContext();
            BeginContext(619, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(633, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ed916bee29d494194ea38e88419f462", async() => {
                BeginContext(698, 77, true);
                WriteLiteral("\r\n              <i class=\"glyphicon glyphicon-remove-sign\"></i>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(779, 20, true);
            WriteLiteral("\r\n          </div>\r\n");
            EndContext();
#line 27 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(810, 191, true);
            WriteLiteral("      </div>\r\n    </div>\r\n  </div>\r\n  <div class=\"col-md-6\">\r\n    <div class=\"panel panel-default\">\r\n      <div class=\"panel-heading\">Taeyo.Net 참여자 리스트</div>\r\n      <div class=\"panel-body\">\r\n");
            EndContext();
#line 35 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
         foreach (var taeyonetkorea in Model.Where(m => m.CommunityName == "Taeyo.Net").OrderBy(m => m.Id).Take(15))
        {

#line default
#line hidden
            BeginContext(1130, 46, true);
            WriteLiteral("          <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(1177, 18, false);
#line 38 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
       Write(taeyonetkorea.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1195, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1209, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cb90516e09448f0b7f1dc9a46d5c6fb", async() => {
                BeginContext(1274, 77, true);
                WriteLiteral("\r\n              <i class=\"glyphicon glyphicon-remove-sign\"></i>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1355, 20, true);
            WriteLiteral("\r\n          </div>\r\n");
            EndContext();
#line 43 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1386, 222, true);
            WriteLiteral("      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n<div class=\"row\">\r\n  <div class=\"col-md-6\">\r\n    <div class=\"panel panel-default\">\r\n      <div class=\"panel-heading\">ASP.NET Korea 대기자 리스트</div>\r\n      <div class=\"panel-body\">\r\n");
            EndContext();
#line 53 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
         foreach(var aspnetkorea in Model.Where(m=>m.CommunityName=="ASP.NET Korea").OrderBy(m => m.Id).Skip(15).Take(25))
        {

#line default
#line hidden
            BeginContext(1743, 34, true);
            WriteLiteral("          <div class=\"col-md-3\">\r\n");
            EndContext();
#line 56 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
               
              var aspName = aspnetkorea.Name[0].ToString() + "*" + aspnetkorea.Name.Substring(aspnetkorea.Name.Length - 1);
            

#line default
#line hidden
            BeginContext(1934, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1947, 7, false);
#line 59 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
       Write(aspName);

#line default
#line hidden
            EndContext();
            BeginContext(1954, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1968, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee804d6795ee40f2ae6c8e53cf7ef75c", async() => {
                BeginContext(2033, 77, true);
                WriteLiteral("\r\n              <i class=\"glyphicon glyphicon-remove-sign\"></i>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2114, 20, true);
            WriteLiteral("\r\n          </div>\r\n");
            EndContext();
#line 64 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2145, 209, true);
            WriteLiteral("      </div>\r\n    </div>\r\n  </div>\r\n  <div class=\"col-md-6\">\r\n    <div class=\"panel panel-default\">\r\n      <div class=\"panel-heading\">\r\n        Taeyo.Net 대기자 리스트\r\n      </div>\r\n      <div class=\"panel-body\">\r\n");
            EndContext();
#line 74 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
         foreach(var taeyonetkorea in Model.Where(m => m.CommunityName == "Taeyo.Net").OrderBy(m => m.Id).Skip(15).Take(25))
        {

#line default
#line hidden
            BeginContext(2491, 34, true);
            WriteLiteral("          <div class=\"col-md-3\">\r\n");
            EndContext();
#line 77 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
               
              var taeyoName = taeyonetkorea.Name[0].ToString() + "*" + taeyonetkorea.Name.Substring(taeyonetkorea.Name.Length - 1);
            

#line default
#line hidden
            BeginContext(2690, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2703, 9, false);
#line 80 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
       Write(taeyoName);

#line default
#line hidden
            EndContext();
            BeginContext(2712, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(2726, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb12ace88d4f4c11a34735f33ab193ed", async() => {
                BeginContext(2791, 77, true);
                WriteLiteral("\r\n              <i class=\"glyphicon glyphicon-remove-sign\"></i>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2872, 20, true);
            WriteLiteral("\r\n          </div>\r\n");
            EndContext();
#line 85 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
              }

#line default
#line hidden
            BeginContext(2909, 46, true);
            WriteLiteral("      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2972, 3, true);
                WriteLiteral(" \r\n");
                EndContext();
#line 92 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
   if (TempData["Message"] != null)
  {

#line default
#line hidden
                BeginContext(3017, 33, true);
                WriteLiteral("    <script>\r\n      toastr.info(\'");
                EndContext();
                BeginContext(3051, 19, false);
#line 95 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
              Write(TempData["Message"]);

#line default
#line hidden
                EndContext();
                BeginContext(3070, 20, true);
                WriteLiteral("\');\r\n    </script>\r\n");
                EndContext();
#line 97 "D:\csPractice\DotNetNote\Views\CommunityCamp\Index.cshtml"
  }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CommunityCampJoinMember>> Html { get; private set; }
    }
}
#pragma warning restore 1591
