#pragma checksum "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Map\Vector.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41d77e9a14d755cb8b56300d1d85efeef79008c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Map_Vector), @"mvc.1.0.view", @"/Views/Map/Vector.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41d77e9a14d755cb8b56300d1d85efeef79008c5", @"/Views/Map/Vector.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bd241ee090bd8b39c0cf55b12cb73c6c44cc0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Map_Vector : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jvectormap-next/jquery-jvectormap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jvectormap-next/jquery-jvectormap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jvectormap-next/jquery-jvectormap-world-mill.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/demo/map-vector.demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Map\Vector.cshtml"
  
  ViewData["Title"] = "Vector Map";
  ViewData["PageContentClass"] = "content-full-width content-inverse-mode";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "41d77e9a14d755cb8b56300d1d85efeef79008c55410", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41d77e9a14d755cb8b56300d1d85efeef79008c56707", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41d77e9a14d755cb8b56300d1d85efeef79008c57804", async() => {
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
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41d77e9a14d755cb8b56300d1d85efeef79008c58901", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
	<li class=""breadcrumb-item""><a href=""javascript:;"">Map</a></li>
	<li class=""breadcrumb-item active"">Vector Map</li>
</ol>
<!-- end breadcrumb -->
<!-- begin page-header -->
<h1 class=""page-header"">Vector Map <small>header small text goes here...</small></h1>
<!-- end page-header -->
<!-- begin map -->
<div class=""map"">
	<div id=""world-map""></div>
	<!-- begin map-float-table -->
	<div class=""map-float-table d-none d-xl-block p-15"">
		<h4 class=""m-t-0""><i class=""fa fa-map-marker-alt text-danger m-r-5""></i> Vector Map</h4>
		<!-- begin scrollbar -->
		<div data-scrollbar=""true"" class=""height-md"">
			<table class=""table table-transparent"">
				<thead>
					<tr>
						<th>Country</th>
						<th>Total Visitors</th>
					</tr>
				</thead>
				<tbody>
					<tr>
						<td>Vatican City</td>
						<td><span class=""text-success"">9,820 <i class=""fa fa-arrow-up");
            WriteLiteral(@"""></i></span></td>
					</tr>
					<tr>
						<td>Monaco</td>
						<td>1,920</td>
					</tr>
					<tr>
						<td>Nauru</td>
						<td><span class=""text-danger"">1,346 <i class=""fa fa-arrow-down""></i></span></td>
					</tr>
					<tr>
						<td>Tuvalu</td>
						<td><span class=""text-success"">6,543 <i class=""fa fa-arrow-up""></i></span></td>
					</tr>
					<tr>
						<td>San Marino</td>
						<td><span class=""text-success"">7,321 <i class=""fa fa-arrow-up""></i></span></td>
					</tr>
					<tr>
						<td>Liechtenstein</td>
						<td>3,434</td>
					</tr>
					<tr>
						<td>Marshall Islands</td>
						<td>1,922</td>
					</tr>
					<tr>
						<td>Saint Kitts and Nevis</td>
						<td><span class=""text-danger"">9,812 <i class=""fa fa-arrow-down""></i></span></td>
					</tr>
					<tr>
						<td>Maldives</td>
						<td><span class=""text-danger"">4,182 <i class=""fa fa-arrow-down""></i></span></td>
					</tr>
					<tr>
						<td>Malta</td>
						<td>9,188</td>
					</tr>
					<tr>
					");
            WriteLiteral(@"	<td>Grenada</td>
						<td>11,198</td>
					</tr>
					<tr>
						<td>Saint Vincent</td>
						<td><span class=""text-success"">9,101 <i class=""fa fa-arrow-up""></i></span></td>
					</tr>
					<tr>
						<td>Barbados</td>
						<td><span class=""text-success"">9,192 <i class=""fa fa-arrow-up""></i></span></td>
					</tr>
					<tr>
						<td>Antigua and Barbuda</td>
						<td><span class=""text-success"">5,282 <i class=""fa fa-arrow-up""></i></span></td>
					</tr>
					<tr>
						<td>Seychelles</td>
						<td><span class=""text-success"">8,283 <i class=""fa fa-arrow-up""></i></span></td>
					</tr>
					<tr>
						<td>Palau</td>
						<td><span class=""text-danger"">1,222 <i class=""fa fa-arrow-down""></i></span></td>
					</tr>
					<tr>
						<td>Andorra</td>
						<td>146</td>
					</tr>
					<tr>
						<td>Saint Lucia</td>
						<td>3,923</td>
					</tr>
					<tr>
						<td>Federated States</td>
						<td>9,827</td>
					</tr>
					<tr>
						<td>Singapore</td>
						<td>7,293</td>
		");
            WriteLiteral(@"			</tr>
					<tr>
						<td>Kiribati</td>
						<td>9,238</td>
					</tr>
					<tr>
						<td>Tonga</td>
						<td>6,422</td>
					</tr>
					<tr>
						<td>Dominica</td>
						<td><span class=""text-success"">3,341 <i class=""fa fa-arrow-up""></i></span></td>
					</tr>
					<tr>
						<td>Mauritius</td>
						<td><span class=""text-success"">532 <i class=""fa fa-arrow-up""></i></span></td>
					</tr>
					<tr>
						<td>Bahrain</td>
						<td><span class=""text-success"">8,754 <i class=""fa fa-arrow-up""></i></span></td>
					</tr>
					<tr>
						<td>São Tomé and Príncipe</td>
						<td>5,742</td>
					</tr>
				</tbody>
			</table>
		</div>
		<!-- end scrollbar -->
	</div>
	<!-- end map-float-table -->
</div>
<!-- end map -->

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
