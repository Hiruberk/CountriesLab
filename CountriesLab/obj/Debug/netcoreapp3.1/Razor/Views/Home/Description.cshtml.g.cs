#pragma checksum "D:\Grand Circus\Grand Circus Docs\NET Core\CountriesLab\CountriesLab\CountriesLab\Views\Home\Description.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04d27383f3f32b7c7a4dce6b727f007280880744"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Description), @"mvc.1.0.view", @"/Views/Home/Description.cshtml")]
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
#line 1 "D:\Grand Circus\Grand Circus Docs\NET Core\CountriesLab\CountriesLab\CountriesLab\Views\_ViewImports.cshtml"
using CountriesLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Grand Circus\Grand Circus Docs\NET Core\CountriesLab\CountriesLab\CountriesLab\Views\_ViewImports.cshtml"
using CountriesLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04d27383f3f32b7c7a4dce6b727f007280880744", @"/Views/Home/Description.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c47c5ba1f3a720b30c647d8ca8551d5e1b922cb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Description : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h2>More about ");
#nullable restore
#line 3 "D:\Grand Circus\Grand Circus Docs\NET Core\CountriesLab\CountriesLab\CountriesLab\Views\Home\Description.cshtml"
          Write(TempData.Peek("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>Description: ");
#nullable restore
#line 4 "D:\Grand Circus\Grand Circus Docs\NET Core\CountriesLab\CountriesLab\CountriesLab\Views\Home\Description.cshtml"
           Write(TempData.Peek("Description"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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