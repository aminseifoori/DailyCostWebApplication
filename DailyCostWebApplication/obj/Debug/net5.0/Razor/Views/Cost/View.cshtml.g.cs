#pragma checksum "D:\Projects\DailyCostWebApplication\DailyCostWebApplication\Views\Cost\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "078d6f6c3263c78333d6f1fe5a0ad268c90cf20c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cost_View), @"mvc.1.0.view", @"/Views/Cost/View.cshtml")]
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
#line 1 "D:\Projects\DailyCostWebApplication\DailyCostWebApplication\Views\_ViewImports.cshtml"
using DailyCostWebApplication.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\DailyCostWebApplication\DailyCostWebApplication\Views\_ViewImports.cshtml"
using DailyCostWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"078d6f6c3263c78333d6f1fe5a0ad268c90cf20c", @"/Views/Cost/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"777d5dddfe6105a48ad36dfbacd8cfc0c6e1946a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cost_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CostRegisteredViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\DailyCostWebApplication\DailyCostWebApplication\Views\Cost\View.cshtml"
  
    ViewBag.Title = "Cost View Model";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-4 offset-lg-4 col-md-6 offset-md-3 col-12"">
        <div class=""card"">
            <div class=""card-header"">
                Submitted Cost Data
            </div>
            <div class=""card-body"">
                ");
#nullable restore
#line 12 "D:\Projects\DailyCostWebApplication\DailyCostWebApplication\Views\Cost\View.cshtml"
           Write(Html.DisplayForModel());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 13 "D:\Projects\DailyCostWebApplication\DailyCostWebApplication\Views\Cost\View.cshtml"
           Write(Html.ActionLink("Back To Create Cost", "CreateStronglyTypedView", "Cost"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CostRegisteredViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
