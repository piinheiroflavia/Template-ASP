#pragma checksum "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\PageOption\PageWithMixedMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d37c6a08bf8e57987f75142f7a14320ec66be1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PageOption_PageWithMixedMenu), @"mvc.1.0.view", @"/Views/PageOption/PageWithMixedMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d37c6a08bf8e57987f75142f7a14320ec66be1a", @"/Views/PageOption/PageWithMixedMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bd241ee090bd8b39c0cf55b12cb73c6c44cc0b", @"/Views/_ViewImports.cshtml")]
    public class Views_PageOption_PageWithMixedMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\PageOption\PageWithMixedMenu.cshtml"
  
  ViewData["Title"] = "Page with Mixed Menu";
  ViewData["PageContainerClass"] = "page-with-top-menu";
  ViewData["PageWithTopMenu"] = "true";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- begin breadcrumb -->
<ol class=""breadcrumb float-xl-right"">
	<li class=""breadcrumb-item""><a href=""javascript:;"">Home</a></li>
	<li class=""breadcrumb-item""><a href=""javascript:;"">Page Options</a></li>
	<li class=""breadcrumb-item active"">Page with Mixed Menu</li>
</ol>
<!-- end breadcrumb -->
<!-- begin page-header -->
<h1 class=""page-header"">Page with Mixed Menu <small>header small text goes here...</small></h1>
<!-- end page-header -->

<!-- begin panel -->
<div class=""panel panel-inverse"">
	<div class=""panel-heading"">
		<h4 class=""panel-title"">Panel Title here</h4>
		<div class=""panel-heading-btn"">
			<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
			<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
			<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-m");
            WriteLiteral("inus\"></i></a>\r\n\t\t\t<a href=\"javascript:;\" class=\"btn btn-xs btn-icon btn-circle btn-danger\" data-click=\"panel-remove\"><i class=\"fa fa-times\"></i></a>\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"panel-body\">\r\n\t\tPanel Content Here\r\n\t</div>\r\n</div>\r\n<!-- end panel -->");
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
