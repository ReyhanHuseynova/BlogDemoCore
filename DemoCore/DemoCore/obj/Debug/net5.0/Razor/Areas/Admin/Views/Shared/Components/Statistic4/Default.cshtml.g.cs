#pragma checksum "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Areas\Admin\Views\Shared\Components\Statistic4\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "32bb1152cd0bf51972e831d8d0a1e44fd19b139e4af1a70adb0a23df394254d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statistic4_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statistic4/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Areas\Admin\Views\_ViewImports.cshtml"
using DemoCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Areas\Admin\Views\_ViewImports.cshtml"
using DemoCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"32bb1152cd0bf51972e831d8d0a1e44fd19b139e4af1a70adb0a23df394254d1", @"/Areas/Admin/Views/Shared/Components/Statistic4/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"79ba76a8969b855fb5f7133c6e69e15a439a5cf4a0e7cdf30980942564dbc304", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared_Components_Statistic4_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminpanel/img/a4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle circle-border m-b-md"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-4"">
        <div class=""widget-head-color-box navy-bg p-lg text-center"">
            <div class=""m-b-md"">
                <h2 class=""font-bold no-margins"">
                    Alex Smith
                </h2>
                <small>Founder of Groupeq</small>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "32bb1152cd0bf51972e831d8d0a1e44fd19b139e4af1a70adb0a23df394254d14906", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div>
                <span>100 Tweets</span> |
                <span>350 Following</span> |
                <span>610 Followers</span>
            </div>
        </div>
        <div class=""widget-text-box"">
            <h4 class=""media-heading"">Alex Smith</h4>
            <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.</p>
            <div class=""text-right"">
                <a");
            BeginWriteAttribute("href", " href=\"", 868, "\"", 875, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn-white\"><i class=\"fa fa-thumbs-up\"></i> Like </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 967, "\"", 974, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-xs btn-primary""><i class=""fa fa-heart""></i> Love</a>
            </div>
        </div>
    </div>
    <div class=""col-lg-2"">
        <div class=""widget navy-bg p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-shield fa-4x""></i>
                <h1 class=""m-xs"">456</h1>
                <h3 class=""font-bold no-margins"">
                    Shield
                </h3>
                <small>power</small>
            </div>
        </div>
        <div class=""widget  p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-flash fa-4x""></i>
                <h1 class=""m-xs"">612</h1>
                <h3 class=""font-bold no-margins"">
                    Thunder
                </h3>
                <small>amount</small>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""widget lazur-bg p-xl"">

            <h2>
                Janet Smith
            </h2>
            ");
            WriteLiteral(@"<ul class=""list-unstyled m-t-md"">
                <li>
                    <span class=""fa fa-envelope m-r-xs""></span>
                    <label>Email:</label>
                    mike@mail.com
                </li>
                <li>
                    <span class=""fa fa-home m-r-xs""></span>
                    <label>Address:</label>
                    Street 200, Avenue 10
                </li>
                <li>
                    <span class=""fa fa-phone m-r-xs""></span>
                    <label>Contact:</label>
                    (+121) 678 3462
                </li>
            </ul>

        </div>
        <div class=""widget red-bg p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-bell fa-4x""></i>
                <h1 class=""m-xs"">47</h1>
                <h3 class=""font-bold no-margins"">
                    Notification
                </h3>
                <small>We detect the error.</small>
            </div>
        </div>
    ");
            WriteLiteral(@"</div>
    <div class=""col-lg-2"">
        <div class=""widget yellow-bg p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-thumbs-up fa-4x""></i>
                <h1 class=""m-xs"">520</h1>
                <h3 class=""font-bold no-margins"">
                    Likes
                </h3>
                <small>amount</small>
            </div>
        </div>
        <div class=""widget yellow-bg p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-warning fa-4x""></i>
                <h1 class=""m-xs"">Alarm</h1>
                <h3 class=""font-bold no-margins"">
                    Do
                </h3>
                <small>something</small>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
