#pragma checksum "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\Error\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce2015548d38b0c900330f728db1c493b5c64218"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_Error), @"mvc.1.0.view", @"/Views/Error/Error.cshtml")]
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
#line 1 "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\_ViewImports.cshtml"
using EBookLibrary.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\_ViewImports.cshtml"
using EBookLibrary.Presentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\_ViewImports.cshtml"
using EBookLibrary.ViewModels.BookVMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\_ViewImports.cshtml"
using EBookLibrary.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\_ViewImports.cshtml"
using EBookLibrary.ViewModels.UserVMs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce2015548d38b0c900330f728db1c493b5c64218", @"/Views/Error/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aa37101ab84ca9da3b546c18a8a584f0f333d57", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Error_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EBookLibrary.DTOs.Response<string>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"wrapper\" id=\"errorPageBody\">\r\n        <div class=\"box\">\r\n            <h1>");
#nullable restore
#line 5 "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\Error\Error.cshtml"
           Write(ViewBag.StatusCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p>");
#nullable restore
#line 6 "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\Error\Error.cshtml"
          Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>😊</p>\r\n");
            WriteLiteral("        <p><a href=\"/\" id=\"homeBtn\">Home</a></p>\r\n        </div>\r\n    </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EBookLibrary.DTOs.Response<string>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
