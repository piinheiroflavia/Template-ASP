#pragma checksum "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Gallery\GalleryV2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a437f6c1a7e6c82c41505e1cecd2fcf248afb40a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_GalleryV2), @"mvc.1.0.view", @"/Views/Gallery/GalleryV2.cshtml")]
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
#line 1 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\_ViewImports.cshtml"
using studio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\_ViewImports.cshtml"
using studio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a437f6c1a7e6c82c41505e1cecd2fcf248afb40a", @"/Views/Gallery/GalleryV2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bd241ee090bd8b39c0cf55b12cb73c6c44cc0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_GalleryV2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/superbox/superbox.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/superbox/jquery.superbox.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/demo/gallery-v2.demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Gallery\GalleryV2.cshtml"
  
  ViewData["Title"] = "Gallery V2";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a437f6c1a7e6c82c41505e1cecd2fcf248afb40a4963", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a437f6c1a7e6c82c41505e1cecd2fcf248afb40a6260", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a437f6c1a7e6c82c41505e1cecd2fcf248afb40a7357", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<!-- begin breadcrumb -->
<ol class=""breadcrumb float-xl-right"">
	<li class=""breadcrumb-item""><a href=""javascript:;"">Home</a></li>
	<li class=""breadcrumb-item""><a href=""javascript:;"">Gallery</a></li>
	<li class=""breadcrumb-item active"">Gallery v2</li>
</ol>
<!-- end breadcrumb -->
<!-- begin page-header -->
<h1 class=""page-header"">Gallery v2 <small>header small text goes here...</small></h1>
<!-- end page-header -->
<!-- begin superbox -->
<div class=""superbox "" data-offset=""50"">
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-1.jpg"" />
		<span style=""background: url(/img/gallery/gallery-1-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-2.jpg"" />
		<span style=""background: url(/img/gallery/gallery-2-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img ");
            WriteLiteral(@"data-img=""/img/gallery/gallery-3.jpg"" />
		<span style=""background: url(/img/gallery/gallery-3-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-4.jpg"" />
		<span style=""background: url(/img/gallery/gallery-4-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-5.jpg"" />
		<span style=""background: url(/img/gallery/gallery-5-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-6.jpg"" />
		<span style=""background: url(/img/gallery/gallery-6-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-7.jpg"" />
		<span style=""background: url(/img/gallery/gallery-7-thumb.jpg);""></span>
		</a>
	</div>
	<div cla");
            WriteLiteral(@"ss=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-8.jpg"" />
		<span style=""background: url(/img/gallery/gallery-8-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-9.jpg"" />
		<span style=""background: url(/img/gallery/gallery-9-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-10.jpg"" />
		<span style=""background: url(/img/gallery/gallery-10-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-11.jpg"" />
		<span style=""background: url(/img/gallery/gallery-11-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-12.jpg"" />
		<span style=""backgr");
            WriteLiteral(@"ound: url(/img/gallery/gallery-12-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-13.jpg"" />
		<span style=""background: url(/img/gallery/gallery-13-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-14.jpg"" />
		<span style=""background: url(/img/gallery/gallery-14-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-15.jpg"" />
		<span style=""background: url(/img/gallery/gallery-15-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-16.jpg"" />
		<span style=""background: url(/img/gallery/gallery-16-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""s");
            WriteLiteral(@"uperbox-img"">
		<img data-img=""/img/gallery/gallery-17.jpg"" />
		<span style=""background: url(/img/gallery/gallery-17-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-18.jpg"" />
		<span style=""background: url(/img/gallery/gallery-18-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-19.jpg"" />
		<span style=""background: url(/img/gallery/gallery-19-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-20.jpg"" />
		<span style=""background: url(/img/gallery/gallery-20-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-21.jpg"" />
		<span style=""background: url(/img/gallery/gallery-21-thumb.jpg);""></s");
            WriteLiteral(@"pan>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-22.jpg"" />
		<span style=""background: url(/img/gallery/gallery-22-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-23.jpg"" />
		<span style=""background: url(/img/gallery/gallery-23-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-24.jpg"" />
		<span style=""background: url(/img/gallery/gallery-24-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-25.jpg"" />
		<span style=""background: url(/img/gallery/gallery-25-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/galle");
            WriteLiteral(@"ry-26.jpg"" />
		<span style=""background: url(/img/gallery/gallery-26-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-27.jpg"" />
		<span style=""background: url(/img/gallery/gallery-27-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-28.jpg"" />
		<span style=""background: url(/img/gallery/gallery-28-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-29.jpg"" />
		<span style=""background: url(/img/gallery/gallery-29-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-30.jpg"" />
		<span style=""background: url(/img/gallery/gallery-30-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list""");
            WriteLiteral(@">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-31.jpg"" />
		<span style=""background: url(/img/gallery/gallery-31-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-32.jpg"" />
		<span style=""background: url(/img/gallery/gallery-32-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-33.jpg"" />
		<span style=""background: url(/img/gallery/gallery-33-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-34.jpg"" />
		<span style=""background: url(/img/gallery/gallery-34-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-35.jpg"" />
		<span style=""background: url(/img");
            WriteLiteral(@"/gallery/gallery-35-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-36.jpg"" />
		<span style=""background: url(/img/gallery/gallery-36-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-37.jpg"" />
		<span style=""background: url(/img/gallery/gallery-37-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-38.jpg"" />
		<span style=""background: url(/img/gallery/gallery-38-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-39.jpg"" />
		<span style=""background: url(/img/gallery/gallery-39-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">");
            WriteLiteral(@"
		<img data-img=""/img/gallery/gallery-40.jpg"" />
		<span style=""background: url(/img/gallery/gallery-40-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-41.jpg"" />
		<span style=""background: url(/img/gallery/gallery-41-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-42.jpg"" />
		<span style=""background: url(/img/gallery/gallery-42-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-43.jpg"" />
		<span style=""background: url(/img/gallery/gallery-43-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-44.jpg"" />
		<span style=""background: url(/img/gallery/gallery-44-thumb.jpg);""></span>
		</a>
");
            WriteLiteral(@"	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-45.jpg"" />
		<span style=""background: url(/img/gallery/gallery-45-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-46.jpg"" />
		<span style=""background: url(/img/gallery/gallery-46-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-47.jpg"" />
		<span style=""background: url(/img/gallery/gallery-47-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-48.jpg"" />
		<span style=""background: url(/img/gallery/gallery-48-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-49.jpg"" />");
            WriteLiteral(@"
		<span style=""background: url(/img/gallery/gallery-49-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-50.jpg"" />
		<span style=""background: url(/img/gallery/gallery-50-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-51.jpg"" />
		<span style=""background: url(/img/gallery/gallery-51-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-52.jpg"" />
		<span style=""background: url(/img/gallery/gallery-52-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-53.jpg"" />
		<span style=""background: url(/img/gallery/gallery-53-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""");
            WriteLiteral(@"javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-54.jpg"" />
		<span style=""background: url(/img/gallery/gallery-54-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-55.jpg"" />
		<span style=""background: url(/img/gallery/gallery-55-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-56.jpg"" />
		<span style=""background: url(/img/gallery/gallery-56-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-57.jpg"" />
		<span style=""background: url(/img/gallery/gallery-57-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-58.jpg"" />
		<span style=""background: url(/img/gallery/galle");
            WriteLiteral(@"ry-58-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-59.jpg"" />
		<span style=""background: url(/img/gallery/gallery-59-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-60.jpg"" />
		<span style=""background: url(/img/gallery/gallery-60-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-61.jpg"" />
		<span style=""background: url(/img/gallery/gallery-61-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-62.jpg"" />
		<span style=""background: url(/img/gallery/gallery-62-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-i");
            WriteLiteral(@"mg=""/img/gallery/gallery-63.jpg"" />
		<span style=""background: url(/img/gallery/gallery-63-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-64.jpg"" />
		<span style=""background: url(/img/gallery/gallery-64-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-65.jpg"" />
		<span style=""background: url(/img/gallery/gallery-65-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-66.jpg"" />
		<span style=""background: url(/img/gallery/gallery-66-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-67.jpg"" />
		<span style=""background: url(/img/gallery/gallery-67-thumb.jpg);""></span>
		</a>
	</div>
	<div");
            WriteLiteral(@" class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-68.jpg"" />
		<span style=""background: url(/img/gallery/gallery-68-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-69.jpg"" />
		<span style=""background: url(/img/gallery/gallery-69-thumb.jpg);""></span>
		</a>
	</div>
	<div class=""superbox-list"">
		<a href=""javascript:;"" class=""superbox-img"">
		<img data-img=""/img/gallery/gallery-70.jpg"" />
		<span style=""background: url(/img/gallery/gallery-70-thumb.jpg);""></span>
		</a>
	</div>
</div>
<!-- end superbox -->
");
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
