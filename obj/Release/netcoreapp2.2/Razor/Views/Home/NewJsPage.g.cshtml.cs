#pragma checksum "D:\ProjectSourceCode\templatesForGit\mvc_jquery_webpack_template\Views\Home\NewJsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42d97b65e36fb115f4b96cdf6a5d13bb2845dc6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewJsPage), @"mvc.1.0.view", @"/Views/Home/NewJsPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/NewJsPage.cshtml", typeof(AspNetCore.Views_Home_NewJsPage))]
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
#line 1 "D:\ProjectSourceCode\templatesForGit\mvc_jquery_webpack_template\Views\_ViewImports.cshtml"
using mvc_jquery_webpack_template;

#line default
#line hidden
#line 2 "D:\ProjectSourceCode\templatesForGit\mvc_jquery_webpack_template\Views\_ViewImports.cshtml"
using mvc_jquery_webpack_template.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42d97b65e36fb115f4b96cdf6a5d13bb2845dc6c", @"/Views/Home/NewJsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a8ce0a191943c0fdec952f9dc99c648da476a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewJsPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\ProjectSourceCode\templatesForGit\mvc_jquery_webpack_template\Views\Home\NewJsPage.cshtml"
  
    ViewData["Title"] = "NewJsPage";

#line default
#line hidden
            BeginContext(47, 62, true);
            WriteLiteral("\r\n<h1>NewJsPage</h1>\r\n\r\n<div id=\"messageOnThisPage\"></div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(132, 85, true);
                WriteLiteral("\r\n\r\n    <script>\r\n        $(window).on(\'load\', function () {\r\n            newJsPage(\'");
                EndContext();
                BeginContext(218, 19, false);
#line 15 "D:\ProjectSourceCode\templatesForGit\mvc_jquery_webpack_template\Views\Home\NewJsPage.cshtml"
                  Write(ViewData["message"]);

#line default
#line hidden
                EndContext();
                BeginContext(237, 44, true);
                WriteLiteral("\');\r\n        });           \r\n    </script>\r\n");
                EndContext();
            }
            );
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
