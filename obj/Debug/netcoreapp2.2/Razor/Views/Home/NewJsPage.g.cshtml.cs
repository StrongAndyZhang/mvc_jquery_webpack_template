#pragma checksum "D:\ProjectSourceCode\templatesForGit\mvc_jquery_webpack_template\Views\Home\NewJsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "697068c19a9caee39ac946c121d01d8cfc3b7475"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"697068c19a9caee39ac946c121d01d8cfc3b7475", @"/Views/Home/NewJsPage.cshtml")]
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
            BeginContext(47, 617, true);
            WriteLiteral(@"
<h1>New Js Page</h1>

<div class=""dropdown mt-3"">
    <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
        <i class=""far fa-thumbs-up""></i> Bootstrap dropdown
    </button>
    <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
        <a class=""dropdown-item"" href=""#"">Action</a>
        <a class=""dropdown-item"" href=""#"">Another action</a>
        <a class=""dropdown-item"" href=""#"">Something else here</a>
    </div>
</div>

<div class=""mt-4"" id=""messageOnThisPage""></div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(687, 94, true);
                WriteLiteral("\r\n\r\n    <script>\r\n        $(window).on(\'load\', function () {\r\n            MyWebApp.newJsPage(\'");
                EndContext();
                BeginContext(782, 19, false);
#line 26 "D:\ProjectSourceCode\templatesForGit\mvc_jquery_webpack_template\Views\Home\NewJsPage.cshtml"
                           Write(ViewData["message"]);

#line default
#line hidden
                EndContext();
                BeginContext(801, 44, true);
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