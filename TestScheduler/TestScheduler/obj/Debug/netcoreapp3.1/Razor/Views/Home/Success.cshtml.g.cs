#pragma checksum "C:\Users\d202staff\Source\Repos\ZachsOnlyFans\TestScheduler\TestScheduler\TestScheduler\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a2207dce581b665853b9995547ee7fc114d8f88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
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
#line 1 "C:\Users\d202staff\Source\Repos\ZachsOnlyFans\TestScheduler\TestScheduler\TestScheduler\Views\_ViewImports.cshtml"
using TestScheduler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\d202staff\Source\Repos\ZachsOnlyFans\TestScheduler\TestScheduler\TestScheduler\Views\_ViewImports.cshtml"
using TestScheduler.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a2207dce581b665853b9995547ee7fc114d8f88", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08099ced15a0f206b7cf3c981aa8bd0788180808", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\d202staff\Source\Repos\ZachsOnlyFans\TestScheduler\TestScheduler\TestScheduler\Views\Home\Success.cshtml"
  
    ViewData["Title"] = "Success";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Success</h1>\r\n<h2>");
#nullable restore
#line 9 "C:\Users\d202staff\Source\Repos\ZachsOnlyFans\TestScheduler\TestScheduler\TestScheduler\Views\Home\Success.cshtml"
Write(ViewBag.userId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" password has been reset</h2>\r\n\r\n");
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
