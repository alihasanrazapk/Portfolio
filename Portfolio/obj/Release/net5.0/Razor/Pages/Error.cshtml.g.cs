#pragma checksum "C:\Users\aliha\source\repos\Portfolio\Portfolio\Pages\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31e12a34ff2957b9c2ecddf6b68c5dd48e775e0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Error), @"mvc.1.0.razor-page", @"/Pages/Error.cshtml")]
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
#line 1 "C:\Users\aliha\source\repos\Portfolio\Portfolio\Pages\_ViewImports.cshtml"
using Portfolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31e12a34ff2957b9c2ecddf6b68c5dd48e775e0f", @"/Pages/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b65624e1e8e0e1d0a50826b9cb5b553a38c9a53", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\aliha\source\repos\Portfolio\Portfolio\Pages\Error.cshtml"
  
    ViewBag.Title = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section>
    <div class=""container-fluid"">
        <div class=""row bg-warning opacity-75 justify-content-center align-items-center vh-100"">
            <div class=""col-sm-10 text-center"">
                <h1 class=""text-danger"">Error.</h1>
                <h2 class=""text-danger"">An error occurred while processing your request.</h2>

                <h3>Development Mode</h3>
                <p>
                    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
                </p>
                <p>
                    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
                    It can result in displaying sensitive information from exceptions to end users.
                    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
           ");
            WriteLiteral("         and restarting the app.\r\n                </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio.Pages.ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Portfolio.Pages.ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Portfolio.Pages.ErrorModel>)PageContext?.ViewData;
        public Portfolio.Pages.ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
