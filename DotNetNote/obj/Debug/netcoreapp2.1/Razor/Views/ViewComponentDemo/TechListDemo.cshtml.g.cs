#pragma checksum "D:\csPractice\DotNetNote\Views\ViewComponentDemo\TechListDemo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1281c10962150e6b984924c710becae43429b6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewComponentDemo_TechListDemo), @"mvc.1.0.view", @"/Views/ViewComponentDemo/TechListDemo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ViewComponentDemo/TechListDemo.cshtml", typeof(AspNetCore.Views_ViewComponentDemo_TechListDemo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1281c10962150e6b984924c710becae43429b6b", @"/Views/ViewComponentDemo/TechListDemo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cb532820678d07923d8a33ab80093736add67a", @"/Views/_ViewImports.cshtml")]
    public class Views_ViewComponentDemo_TechListDemo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\csPractice\DotNetNote\Views\ViewComponentDemo\TechListDemo.cshtml"
  
  Layout = null;

#line default
#line hidden
            BeginContext(25, 32, true);
            WriteLiteral("<h3>현재 사이트에서 사용된 기술 리스트</h3>\r\n\r\n");
            EndContext();
            BeginContext(58, 40, false);
#line 6 "D:\csPractice\DotNetNote\Views\ViewComponentDemo\TechListDemo.cshtml"
Write(await Component.InvokeAsync("TeachList"));

#line default
#line hidden
            EndContext();
            BeginContext(98, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(101, 40, false);
#line 7 "D:\csPractice\DotNetNote\Views\ViewComponentDemo\TechListDemo.cshtml"
Write(await Component.InvokeAsync("Copyright"));

#line default
#line hidden
            EndContext();
            BeginContext(141, 1, true);
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
