#pragma checksum "D:\csPractice\DotNetNote\Views\FormValidationDemo\ModelValidation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0abd43060a5a54d650863c7c6917e6c9f1979a4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FormValidationDemo_ModelValidation), @"mvc.1.0.view", @"/Views/FormValidationDemo/ModelValidation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FormValidationDemo/ModelValidation.cshtml", typeof(AspNetCore.Views_FormValidationDemo_ModelValidation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0abd43060a5a54d650863c7c6917e6c9f1979a4b", @"/Views/FormValidationDemo/ModelValidation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cb532820678d07923d8a33ab80093736add67a", @"/Views/_ViewImports.cshtml")]
    public class Views_FormValidationDemo_ModelValidation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetNote.Models.MaximModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\csPractice\DotNetNote\Views\FormValidationDemo\ModelValidation.cshtml"
   
  Layout = null;

#line default
#line hidden
            BeginContext(65, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d7e4718dbd54149b289888b6ba6c3c5", async() => {
                BeginContext(71, 127, true);
                WriteLiteral("\r\n  <title>모델 기반 서버측 유효성 검사</title>\r\n  <style>\r\n    .input-validation-error{\r\n      border: 1px solid red;\r\n    }\r\n  </style>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(207, 454, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8804d354993349a3bbd23227992fb8b9", async() => {
                BeginContext(213, 31, true);
                WriteLiteral("\r\n  <h2>모델 기반 서버측 유효성 검사</h2>\r\n");
                EndContext();
#line 16 "D:\csPractice\DotNetNote\Views\FormValidationDemo\ModelValidation.cshtml"
   using (Html.BeginForm())
  {
    

#line default
#line hidden
                BeginContext(283, 29, false);
#line 18 "D:\csPractice\DotNetNote\Views\FormValidationDemo\ModelValidation.cshtml"
Write(Html.ValidationSummary(false));

#line default
#line hidden
                EndContext();
                BeginContext(321, 26, false);
#line 20 "D:\csPractice\DotNetNote\Views\FormValidationDemo\ModelValidation.cshtml"
Write(Html.LabelFor(n => n.Name));

#line default
#line hidden
                EndContext();
                BeginContext(359, 2, true);
                WriteLiteral(": ");
                EndContext();
                BeginContext(375, 28, false);
#line 22 "D:\csPractice\DotNetNote\Views\FormValidationDemo\ModelValidation.cshtml"
Write(Html.TextBoxFor(n => n.Name));

#line default
#line hidden
                EndContext();
                BeginContext(410, 38, false);
#line 23 "D:\csPractice\DotNetNote\Views\FormValidationDemo\ModelValidation.cshtml"
Write(Html.ValidationMessageFor(n => n.Name));

#line default
#line hidden
                EndContext();
                BeginContext(448, 8, true);
                WriteLiteral("<br />\r\n");
                EndContext();
                BeginContext(463, 29, false);
#line 25 "D:\csPractice\DotNetNote\Views\FormValidationDemo\ModelValidation.cshtml"
Write(Html.LabelFor(n => n.Content));

#line default
#line hidden
                EndContext();
                BeginContext(504, 2, true);
                WriteLiteral(": ");
                EndContext();
                BeginContext(520, 31, false);
#line 27 "D:\csPractice\DotNetNote\Views\FormValidationDemo\ModelValidation.cshtml"
Write(Html.TextBoxFor(n => n.Content));

#line default
#line hidden
                EndContext();
                BeginContext(558, 41, false);
#line 28 "D:\csPractice\DotNetNote\Views\FormValidationDemo\ModelValidation.cshtml"
Write(Html.ValidationMessageFor(n => n.Content));

#line default
#line hidden
                EndContext();
                BeginContext(599, 8, true);
                WriteLiteral("<br />\r\n");
                EndContext();
                BeginContext(609, 40, true);
                WriteLiteral("    <input type=\"submit\" value=\"전송\" />\r\n");
                EndContext();
#line 31 "D:\csPractice\DotNetNote\Views\FormValidationDemo\ModelValidation.cshtml"
  }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetNote.Models.MaximModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
