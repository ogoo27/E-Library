#pragma checksum "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2ccc1707509243743d95a4753d1c553df8ff290"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2ccc1707509243743d95a4753d1c553df8ff290", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aa37101ab84ca9da3b546c18a8a584f0f333d57", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserDashboardViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("userImage card-img-top rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadAvatar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\Dashboard\Index.cshtml"
  
    Layout = "_DashboardLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Page Content  -->
<div id=""content"">

    <div class=""d-flex flex-row justify-content-center row ml-lg-2 mr-lg-5 pr-lg-3"">
        <!--<div class=""card col-lg-9 col-sm-12 border-0 bg-transparent userImgContaine"">-->
        <div class=""card col-lg-9 col-md-8 col-sm-12 border-0 bg-transparent userImgContaine mt-lg-5"">
            <div class=""card-header bg-secondary mt-lg-5"">
                <h3 class=""text-white"">Your details</h3>
            </div>

            <div class=""card-body"">

                <div class=""input-group mb-3"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"" id=""basic-addon1"" style=""width:110px;""><b>First name</b></span>
                    </div>
                    <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 891, "\"", 915, 1);
#nullable restore
#line 21 "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 899, Model.FirstName, 899, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""First name"" aria-describedby=""basic-addon1"" disabled>
                </div>

                <div class=""input-group mb-3"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"" id=""basic-addon1"" style=""width:110px;""><b>Last name</b></span>
                    </div>
                    <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1319, "\"", 1342, 1);
#nullable restore
#line 28 "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 1327, Model.LastName, 1327, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Last name"" aria-describedby=""basic-addon1"" disabled>
                </div>

                <div class=""input-group mb-3"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"" id=""basic-addon1"" style=""width:110px;""><b>Email</b></span>
                    </div>
                    <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1741, "\"", 1761, 1);
#nullable restore
#line 35 "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 1749, Model.Email, 1749, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Email"" aria-describedby=""basic-addon1"" disabled>
                </div>

                <div class=""line""></div>
            </div>
        </div>



        <!--<div class="" card col-lg-3 col-sm-12 box-shadow border-1 w-50 p-3 h-75"">-->
            <div class=""card col-sm-12 col-md-4 col-lg-3 box-shadow"">
                <div class=""text-center userImgContainer"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2ccc1707509243743d95a4753d1c553df8ff29010734", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 47 "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\Dashboard\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\hp\Downloads\E-Library (1) (1)\E-Library\EBookLibraryApplication\EBookLibrary\EBookLibrary.Presentation\Views\Dashboard\Index.cshtml"
                                                                                          WriteLiteral(Model.AvatarUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-body text-center\">\r\n                    <h6 class=\"text-secondary text-uppercase\">\r\n                        UserName\r\n                    </h6>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2ccc1707509243743d95a4753d1c553df8ff29013528", async() => {
                WriteLiteral("\r\n                        <input type=\"file\" name=\"avatar\" id=\"avatar\"/>\r\n                        <button type=\"submit\" class=\"btn btn-block btn-info\">Upload photo</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    \r\n                </div>\r\n            </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserDashboardViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
