#pragma checksum "D:\Projects\DailyCostWebApplication\DailyCostWebApplication\Views\Shared\DisplayTemplates\Url.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79e798a978cfc80ac3a0344bf32bbb23a5a28760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_Url), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/Url.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e798a978cfc80ac3a0344bf32bbb23a5a28760", @"/Views/Shared/DisplayTemplates/Url.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"777d5dddfe6105a48ad36dfbacd8cfc0c6e1946a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_Url : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<a");
            BeginWriteAttribute("href", " href=\"", 4, "\"", 26, 1);
#nullable restore
#line 2 "D:\Projects\DailyCostWebApplication\DailyCostWebApplication\Views\Shared\DisplayTemplates\Url.cshtml"
WriteAttributeValue("", 11, ViewData.Model, 11, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 2 "D:\Projects\DailyCostWebApplication\DailyCostWebApplication\Views\Shared\DisplayTemplates\Url.cshtml"
                                     Write(ViewData.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>");
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
