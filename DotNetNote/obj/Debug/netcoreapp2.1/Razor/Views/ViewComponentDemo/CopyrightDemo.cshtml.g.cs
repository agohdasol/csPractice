#pragma checksum "D:\csPractice\DotNetNote\Views\ViewComponentDemo\CopyrightDemo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d07a85de5a32f2d0dc54239a5b4f2dcf4df3cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewComponentDemo_CopyrightDemo), @"mvc.1.0.view", @"/Views/ViewComponentDemo/CopyrightDemo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ViewComponentDemo/CopyrightDemo.cshtml", typeof(AspNetCore.Views_ViewComponentDemo_CopyrightDemo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d07a85de5a32f2d0dc54239a5b4f2dcf4df3cb", @"/Views/ViewComponentDemo/CopyrightDemo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cb532820678d07923d8a33ab80093736add67a", @"/Views/_ViewImports.cshtml")]
    public class Views_ViewComponentDemo_CopyrightDemo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\csPractice\DotNetNote\Views\ViewComponentDemo\CopyrightDemo.cshtml"
   
  Layout = null;

#line default
#line hidden
            BeginContext(26, 30, true);
            WriteLiteral("<h3>Copyright 뷰 컴포넌트 호출</h3>\r\n");
            EndContext();
            BeginContext(57, 40, false);
#line 5 "D:\csPractice\DotNetNote\Views\ViewComponentDemo\CopyrightDemo.cshtml"
Write(await Component.InvokeAsync("Copyright"));

#line default
#line hidden
            EndContext();
            BeginContext(97, 1, true);
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
