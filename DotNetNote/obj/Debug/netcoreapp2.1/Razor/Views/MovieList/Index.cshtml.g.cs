#pragma checksum "D:\csPractice\DotNetNote\Views\MovieList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01d2fab14824e6ce94e5e7faae8ed9f1bf240b1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieList_Index), @"mvc.1.0.view", @"/Views/MovieList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MovieList/Index.cshtml", typeof(AspNetCore.Views_MovieList_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01d2fab14824e6ce94e5e7faae8ed9f1bf240b1a", @"/Views/MovieList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cb532820678d07923d8a33ab80093736add67a", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MovieViewModel>>
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
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\csPractice\DotNetNote\Views\MovieList\Index.cshtml"
   
  Layout = null;

#line default
#line hidden
            BeginContext(58, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(68, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86061268b7fb4b1c9ce5ecf9c71b15a1", async() => {
                BeginContext(74, 27, true);
                WriteLiteral("\r\n  <title>영화 리스트</title>\r\n");
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
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(110, 318, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d14de906c18c4c30889da9ceab3e1d80", async() => {
                BeginContext(116, 127, true);
                WriteLiteral("\r\n  <h1>영화 리스트</h1>\r\n  <table id=\"movieLists\">\r\n    <tr>\r\n      <th>번호</th>\r\n      <th>제목</th>\r\n      <th>개봉일</th>\r\n    </tr>\r\n");
                EndContext();
#line 19 "D:\csPractice\DotNetNote\Views\MovieList\Index.cshtml"
     foreach(var movie in Model)
    {

#line default
#line hidden
                BeginContext(284, 16, true);
                WriteLiteral("  <tr>\r\n    <td>");
                EndContext();
                BeginContext(301, 8, false);
#line 22 "D:\csPractice\DotNetNote\Views\MovieList\Index.cshtml"
   Write(movie.Id);

#line default
#line hidden
                EndContext();
                BeginContext(309, 15, true);
                WriteLiteral("</td>\r\n    <td>");
                EndContext();
                BeginContext(325, 11, false);
#line 23 "D:\csPractice\DotNetNote\Views\MovieList\Index.cshtml"
   Write(movie.Title);

#line default
#line hidden
                EndContext();
                BeginContext(336, 15, true);
                WriteLiteral("</td>\r\n    <td>");
                EndContext();
                BeginContext(352, 34, false);
#line 24 "D:\csPractice\DotNetNote\Views\MovieList\Index.cshtml"
   Write(movie.CreationDate.Year.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(386, 16, true);
                WriteLiteral("</td>\r\n  </tr>\r\n");
                EndContext();
#line 26 "D:\csPractice\DotNetNote\Views\MovieList\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(409, 12, true);
                WriteLiteral("  </table>\r\n");
                EndContext();
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
            BeginContext(428, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MovieViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
