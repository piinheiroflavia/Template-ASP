#pragma checksum "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Chart\ChartJs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44620c38535ca6493791a33e20ee87e6741378ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chart_ChartJs), @"mvc.1.0.view", @"/Views/Chart/ChartJs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44620c38535ca6493791a33e20ee87e6741378ff", @"/Views/Chart/ChartJs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bd241ee090bd8b39c0cf55b12cb73c6c44cc0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Chart_ChartJs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chart.js/dist/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/demo/chart-js.demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Chart\ChartJs.cshtml"
  
  ViewData["Title"] = "Chart JS";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44620c38535ca6493791a33e20ee87e6741378ff4213", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44620c38535ca6493791a33e20ee87e6741378ff5310", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            WriteLiteral(@"
<!-- begin breadcrumb -->
<ol class=""breadcrumb float-xl-right"">
	<li class=""breadcrumb-item""><a href=""javascript:;"">Home</a></li>
	<li class=""breadcrumb-item""><a href=""javascript:;"">Chart</a></li>
	<li class=""breadcrumb-item active"">Chart JS</li>
</ol>
<!-- end breadcrumb -->
<!-- begin page-header -->
<h1 class=""page-header"">Chart JS <small>header small text goes here...</small></h1>
<!-- end page-header -->
<!-- begin row -->
<div class=""row"">
	<!-- begin col-6 -->
	<div class=""col-xl-6"">
		<!-- begin panel -->
		<div class=""panel panel-inverse"" data-sortable-id=""chart-js-1"">
			<div class=""panel-heading"">
				<h4 class=""panel-title"">Line Chart</h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascript:;"" cl");
            WriteLiteral(@"ass=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<div class=""panel-body"">
				<p>
					A line chart is a way of plotting data points on a line.
					Often, it is used to show trend data, and the comparison of two data sets.
				</p>
				<div>
					<canvas id=""line-chart"" data-render=""chart-js""></canvas>
				</div>
			</div>
		</div>
		<!-- end panel -->
	</div>
	<!-- end col-6 -->
	<!-- begin col-6 -->
	<div class=""col-xl-6"">
		<!-- begin panel -->
		<div class=""panel panel-inverse"" data-sortable-id=""chart-js-2"">
			<div class=""panel-heading"">
				<h4 class=""panel-title"">Bar Chart</h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href");
            WriteLiteral(@"=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<div class=""panel-body"">
				<p>
					A bar chart is a way of showing data as bars.
					It is sometimes used to show trend data, and the comparison of multiple data sets side by side.
				</p>
				<div>
					<canvas id=""bar-chart"" data-render=""chart-js""></canvas>
				</div>
			</div>
		</div>
		<!-- end panel -->
	</div>
	<!-- end col-6 -->
</div>
<!-- end row -->
<!-- begin row -->
<div class=""row"">
	<!-- begin col-6 -->
	<div class=""col-xl-6"">
		<!-- begin panel -->
		<div class=""panel panel-inverse"" data-sortable-id=""flot-chart-3"">
			<div class=""panel-heading"">
	");
            WriteLiteral(@"			<h4 class=""panel-title"">Radar Chart</h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<div class=""panel-body"">
				<p>
					A radar chart is a way of showing multiple data points and the variation between them.
					They are often useful for comparing the points of two or more different data sets.
				</p>
				<div>
					<canvas id=""radar-chart"" data-render=""chart-js""></canvas>
				</div>
			</div>
		</div>
		<!-- end panel -->
	</div");
            WriteLiteral(@">
	<!-- end col-6 -->
	<!-- begin col-6 -->
	<div class=""col-xl-6"">
		<!-- begin panel -->
		<div class=""panel panel-inverse"" data-sortable-id=""chart-js-4"">
			<div class=""panel-heading"">
				<h4 class=""panel-title"">Polar Area Chart</h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<div class=""panel-body"">
				<p>
					Polar area charts are similar to pie charts, but each segment has the same angle - the radius of the segment 
					differ");
            WriteLiteral(@"s depending on the value.
				</p>
				<div>
					<canvas id=""polar-area-chart"" data-render=""chart-js""></canvas>
				</div>
			</div>
		</div>
		<!-- end panel -->
	</div>
	<!-- end col-6 -->
</div>
<!-- end row -->
<!-- begin row -->
<div class=""row"">
	<!-- begin col-6 -->
	<div class=""col-xl-6"">
		<!-- begin panel -->
		<div class=""panel panel-inverse"" data-sortable-id=""flot-chart-5"">
			<div class=""panel-heading"">
				<h4 class=""panel-title"">Pie Chart</h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-clic");
            WriteLiteral(@"k=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<div class=""panel-body"">
				<p>
					Pie and doughnut charts are probably the most commonly used chart there are. They are divided into segments, the arc of each segment shows the proportional value of each piece of data.
				</p>
				<div>
					<canvas id=""pie-chart"" data-render=""chart-js""></canvas>
				</div>
			</div>
		</div>
		<!-- end panel -->
	</div>
	<!-- end col-6 -->
	<!-- begin col-6 -->
	<div class=""col-xl-6"">
		<!-- begin panel -->
		<div class=""panel panel-inverse"" data-sortable-id=""chart-js-6"">
			<div class=""panel-heading"">
				<h4 class=""panel-title"">Doughnut Chart</h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascr");
            WriteLiteral(@"ipt:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<div class=""panel-body"">
				<p>
					Pie and doughnut charts are registered under two aliases in the Chart core. Other than their different default value, and different alias, they are exactly the same.
				</p>
				<div>
					<canvas id=""doughnut-chart"" data-render=""chart-js""></canvas>
				</div>
			</div>
		</div>
		<!-- end panel -->
	</div>
	<!-- end col-6 -->
</div>
<!-- end row -->
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
