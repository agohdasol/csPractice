#pragma checksum "D:\csPractice\DotNetNote\Views\Shared\Components\SiteList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "401b201b90409dca648e139d8ed5f151784196bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SiteList_Index), @"mvc.1.0.view", @"/Views/Shared/Components/SiteList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/SiteList/Index.cshtml", typeof(AspNetCore.Views_Shared_Components_SiteList_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"401b201b90409dca648e139d8ed5f151784196bc", @"/Views/Shared/Components/SiteList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cb532820678d07923d8a33ab80093736add67a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SiteList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DotNetNote.Models.Site>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 8, true);
            WriteLiteral("\r\n<ul>\r\n");
            EndContext();
#line 4 "D:\csPractice\DotNetNote\Views\Shared\Components\SiteList\Index.cshtml"
   foreach (var t in Model)
  {

#line default
#line hidden
            BeginContext(79, 10, true);
            WriteLiteral("    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 89, "\"", 102, 1);
#line 6 "D:\csPractice\DotNetNote\Views\Shared\Components\SiteList\Index.cshtml"
WriteAttributeValue("", 96, t.Url, 96, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(103, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(121, 7, false);
#line 6 "D:\csPractice\DotNetNote\Views\Shared\Components\SiteList\Index.cshtml"
                                    Write(t.Title);

#line default
#line hidden
            EndContext();
            BeginContext(128, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(131, 13, false);
#line 6 "D:\csPractice\DotNetNote\Views\Shared\Components\SiteList\Index.cshtml"
                                              Write(t.Description);

#line default
#line hidden
            EndContext();
            BeginContext(144, 12, true);
            WriteLiteral(")</a></li>\r\n");
            EndContext();
#line 7 "D:\csPractice\DotNetNote\Views\Shared\Components\SiteList\Index.cshtml"
  }

#line default
#line hidden
            BeginContext(161, 7, true);
            WriteLiteral("</ul>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DotNetNote.Models.Site>> Html { get; private set; }
    }
}
#pragma warning restore 1591