#pragma checksum "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\Blog\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07d5575dbb45a93f67ca24afade7ecfb281a9151cdffd7fd399eebd9c82f0fb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\_ViewImports.cshtml"
using DemoCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\_ViewImports.cshtml"
using DemoCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"07d5575dbb45a93f67ca24afade7ecfb281a9151cdffd7fd399eebd9c82f0fb6", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"79ba76a8969b855fb5f7133c6e69e15a439a5cf4a0e7cdf30980942564dbc304", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"main-content-w3layouts-agileits\">\r\n\t<div class=\"container\">\r\n\t\t<h3 class=\"tittle\">Blog Posts</h3>\r\n\t\t<div class=\"inner-sec\">\r\n\t\t\t<!--left-->\r\n\t\t\t<div class=\"left-blog-info-w3layouts-agileits text-left\">\r\n\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\r\n");
#nullable restore
#line 17 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\Blog\Index.cshtml"
                     foreach(var item in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"col-lg-4 card\">\r\n\t\t\t\t\t\t\t<a href=\"single.html\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "07d5575dbb45a93f67ca24afade7ecfb281a9151cdffd7fd399eebd9c82f0fb65062", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 519, "~/web/images/", 519, 13, true);
#nullable restore
#line 21 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 532, item.BlogThumbnailImage, 532, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t<ul class=\"blog-icons my-4\">\r\n\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i>");
#nullable restore
#line 27 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\Blog\Index.cshtml"
                                                                           Write(((DateTime)item.CreateDate).ToString("dd-MMM-yyyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t<li class=\"mx-2\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-comment\"></i> 21\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-eye\"></i> ");
#nullable restore
#line 37 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\Blog\Index.cshtml"
                                                                  Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t<h5 class=\"card-title \">\r\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1185, "\"", 1222, 2);
            WriteAttributeValue("", 1192, "/Blog/BlogReadAll/", 1192, 18, true);
#nullable restore
#line 43 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1210, item.BlogID, 1210, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\Blog\Index.cshtml"
                                                                        Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t\t<p class=\"card-text mb-3\">");
#nullable restore
#line 45 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\Blog\Index.cshtml"
                                                     Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1393, "\"", 1430, 2);
            WriteAttributeValue("", 1400, "/Blog/BlogReadAll/", 1400, 18, true);
#nullable restore
#line 46 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1418, item.BlogID, 1418, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Read More</a>\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 50 "C:\Users\ACER\OneDrive\İş masası\DemoCore\DemoCore\Views\Blog\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
					<nav aria-label=""Page navigation example"">
						<ul class=""pagination justify-content-left mt-4"">
							<li class=""page-item disabled"">
								<a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
							</li>
							<li class=""page-item"">
								<a class=""page-link"" href=""#"">1</a>
							</li>
							<li class=""page-item"">
								<a class=""page-link"" href=""#"">2</a>
							</li>
							<li class=""page-item"">
								<a class=""page-link"" href=""#"">3</a>
							</li>
							<li class=""page-item"">
								<a class=""page-link"" href=""#"">Next</a>
							</li>
						</ul>
					</nav>
				</div>
				<!--//left-->
			</div>
		</div>
	</div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591