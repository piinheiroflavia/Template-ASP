#pragma checksum "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Table\Basic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ef04913769f24ca003b0a08fb01fc647d91af88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table_Basic), @"mvc.1.0.view", @"/Views/Table/Basic.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ef04913769f24ca003b0a08fb01fc647d91af88", @"/Views/Table/Basic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bd241ee090bd8b39c0cf55b12cb73c6c44cc0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Table_Basic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/highlight.js/highlight.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/demo/render.highlight.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/user/user-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-rounded height-30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/user/user-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/user/user-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Table\Basic.cshtml"
  
  ViewData["Title"] = "Basic Tables";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ef04913769f24ca003b0a08fb01fc647d91af885649", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ef04913769f24ca003b0a08fb01fc647d91af886746", async() => {
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
	<li class=""breadcrumb-item""><a href=""javascript:;"">Tables</a></li>
	<li class=""breadcrumb-item active"">Basic Tables</li>
</ol>
<!-- end breadcrumb -->
<!-- begin page-header -->
<h1 class=""page-header"">Basic Tables <small>header small text goes here...</small></h1>
<!-- end page-header -->
<!-- begin row -->
<div class=""row"">
	<!-- begin col-6 -->
	<div class=""col-xl-6"">
		<!-- begin panel -->
		<div class=""panel panel-inverse"" data-sortable-id=""table-basic-1"">
			<!-- begin panel-heading -->
			<div class=""panel-heading"">
				<h4 class=""panel-title"">Default Table</h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa f");
            WriteLiteral(@"a-redo""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<!-- end panel-heading -->
			<!-- begin panel-body -->
			<div class=""panel-body"">
				<!-- begin table-responsive -->
				<div class=""table-responsive"">
					<table class=""table m-b-0"">
						<thead>
							<tr>
								<th>#</th>
								<th>Username</th>
								<th>Email Address</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td>1</td>
								<td>Nicky Almera</td>
								<td>nicky@hotmail.com</td>
							</tr>
							<tr>
								<td>2</td>
								<td>Edmund Wong</td>
								<td>edmund@yahoo.com</td>
							</tr>
							<tr>
								<td>3</td>
								<td>Harvinder Singh</td>
								<td>harvinder@gmail.com</td>
							</tr>
						</tbod");
            WriteLiteral(@"y>
					</table>
				</div>
				<!-- end table-responsive -->
			</div>
			<!-- end panel-body -->
			<!-- begin hljs-wrapper -->
			<div class=""hljs-wrapper"">
				<pre><code class=""html"">&lt;table class=""table""&gt;
  ...
&lt;/table&gt;</code></pre>
			</div>
			<!-- end hljs-wrapper -->
		</div>
		<!-- end panel -->
		<!-- begin panel -->
		<div class=""panel panel-inverse"" data-sortable-id=""table-basic-2"">
			<!-- begin panel-heading -->
			<div class=""panel-heading"">
				<h4 class=""panel-title"">Hover Table</h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" clas");
            WriteLiteral(@"s=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<!-- end panel-heading -->
			<!-- begin panel-body -->
			<div class=""panel-body"">
				<!-- begin table-responsive -->
				<div class=""table-responsive"">
					<table class=""table table-hover m-b-0 text-inverse"">
						<thead>
							<tr>
								<th>#</th>
								<th>Username</th>
								<th>Email Address</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td>1</td>
								<td>Nicky Almera</td>
								<td>nicky");
            WriteLiteral("@hotmail.com</td>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<td>2</td>\r\n\t\t\t\t\t\t\t\t<td>Edmund Wong</td>\r\n\t\t\t\t\t\t\t\t<td>edmund");
            WriteLiteral("@yahoo.com</td>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<td>3</td>\r\n\t\t\t\t\t\t\t\t<td>Harvinder Singh</td>\r\n\t\t\t\t\t\t\t\t<td>harvinder");
            WriteLiteral(@"@gmail.com</td>
							</tr>
						</tbody>
					</table>
				</div>
				<!-- end table-responsive -->
			</div>
			<!-- end panel-body -->
			<!-- begin hljs-wrapper -->
			<div class=""hljs-wrapper"">
				<pre><code class=""html"">&lt;table class=""table table-hover""&gt;
  ...
&lt;/table&gt;</code></pre>
			</div>
			<!-- end hljs-wrapper -->
		</div>
		<!-- end panel -->
		<!-- begin panel -->
		<div class=""panel panel-inverse"" data-sortable-id=""table-basic-3"">
			<!-- begin panel-heading -->
			<div class=""panel-heading"">
				<h4 class=""panel-title"">Table Small</h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""");
            WriteLiteral(@"fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<!-- end panel-heading -->
			<!-- begin panel-body -->
			<div class=""panel-body"">
				<!-- begin table-responsive -->
				<div class=""table-responsive"">
					<table class=""table table-sm m-b-0 text-inverse"">
						<thead>
							<tr>
								<th>#</th>
								<th>Username</th>
								<th>Email Address</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td>1</td>
								<td>Nicky Almera</td>
								<td>nicky@hotmail.com</td>
							</tr>
							<tr>
								<td>2</td>
								<td>Edmund Wong</td>
								<td>edmund@yahoo.com</td>
							</tr>
							<tr>
								<td>3</td>
								<td>Harvinder Singh</td>
								<td>harvinder@gmail.com</td>
							</tr>
						</tbody>
					</table>
				</div>
				<!-- end table-responsive -->
			</div>
			<!-- end panel-body -->
			<!-- ");
            WriteLiteral(@"begin hljs-wrapper -->
			<div class=""hljs-wrapper"">
				<pre><code class=""html"">&lt;table class=""table table-sm""&gt;
  ...
&lt;/table&gt;</code></pre>
			</div>
			<!-- end hljs-wrapper -->
		</div>
		<!-- end panel -->
		<!-- begin panel -->
		<div class=""panel panel-inverse"" data-sortable-id=""table-basic-4"">
			<!-- begin panel-heading -->
			<div class=""panel-heading"">
				<h4 class=""panel-title"">Responsive Table</h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i>");
            WriteLiteral(@"</a>
				</div>
			</div>
			<!-- end panel-heading -->
			<!-- begin panel-body -->
			<div class=""panel-body"">
				<!-- begin table-responsive -->
				<div class=""table-responsive"">
					<table class=""table"">
						<thead>
							<tr>
								<th>#</th>
								<th nowrap>Table heading</th>
								<th nowrap>Table heading</th>
								<th nowrap>Table heading</th>
								<th nowrap>Table heading</th>
								<th nowrap>Table heading</th>
								<th nowrap>Table heading</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td>1</td>
								<td>Table cell</td>
								<td>Table cell</td>
								<td>Table cell</td>
								<td>Table cell</td>
								<td>Table cell</td>
								<td>Table cell</td>
							</tr>
							<tr>
								<td>2</td>
								<td>Table cell</td>
								<td>Table cell</td>
								<td>Table cell</td>
								<td>Table cell</td>
								<td>Table cell</td>
								<td>Table cell</td>
							</tr>
							<tr>
								<td>3</td>
		");
            WriteLiteral(@"						<td>Table cell</td>
								<td>Table cell</td>
								<td>Table cell</td>
								<td>Table cell</td>
								<td>Table cell</td>
								<td>Table cell</td>
							</tr>
						</tbody>
					</table>
				</div>
				<!-- end table-responsive -->
			</div>
			<!-- end panel-body -->
			<!-- begin hljs-wrapper -->
			<div class=""hljs-wrapper"">
				<pre><code class=""html"">&lt;div class=""table-responsive""&gt;
  &lt;table class=""table""&gt;
    ...
  &lt;/table&gt;
&lt;/div&gt;</code></pre>
			</div>
			<!-- end hljs-wrapper -->
		</div>
		<!-- end panel -->
		<!-- begin panel -->
		<div class=""panel panel-inverse"" data-sortable-id=""table-basic-5"">
			<!-- begin panel-heading -->
			<div class=""panel-heading"">
				<h4 class=""panel-title"">Table Striped</h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-i");
            WriteLiteral(@"con btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<!-- end panel-heading -->
			<!-- begin panel-body -->
			<div class=""panel-body"">
				<!-- begin table-responsive -->
				<div class=""table-responsive"">
					<table class=""table table-striped m-b-0"">
						<thead>
							<tr>
								<th>#</th>
								<th>Username</th>
								<th>Email Address</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td>1</td>
								<td>Nicky Almera</td>
								<td>nicky@hotmail.com</td>
							</tr>
							<tr>
								<td>2</td>
								<td>Edmund Wong</td>
								<td>edmund@yahoo.com</td>
							</tr>
							<tr>
								<td>3</td>
								<td>Harv");
            WriteLiteral(@"inder Singh</td>
								<td>harvinder@gmail.com</td>
							</tr>
						</tbody>
					</table>
				</div>
				<!-- end table-responsive -->
			</div>
			<!-- end panel-body -->
			<!-- begin hljs-wrapper -->
			<div class=""hljs-wrapper"">
				<pre><code class=""html"">&lt;table class=""table table-striped""&gt;
  ...
&lt;/table&gt;</code></pre>
			</div>
			<!-- end hljs-wrapper -->
		</div>
		<!-- end panel -->
		<!-- begin panel -->
		<div class=""panel panel-inverse"" data-sortable-id=""table-basic-6"">
			<!-- begin panel-heading -->
			<div class=""panel-heading"">
				<h4 class=""panel-title"">Bordered Table</h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-war");
            WriteLiteral(@"ning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<!-- end panel-heading -->
			<!-- begin panel-body -->
			<div class=""panel-body"">
				<!-- begin table-responsive -->
				<div class=""table-responsive"">
					<table class=""table table-bordered m-b-0"">
						<thead>
							<tr>
								<th>#</th>
								<th>Username</th>
								<th>Email Address</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td>1</td>
								<td>Nicky Almera</td>
								<td>nicky@hotmail.com</td>
							</tr>
							<tr>
								<td>2</td>
								<td>Edmund Wong</td>
								<td>edmund@yahoo.com</td>
							</tr>
							<tr>
								<td>3</td>
								<td>Harvinder Singh</td>
								<td>harvinder@gmail.com</td>
							</tr>
						</tbody>
					</table>
				</div>
				<!-- end table-responsive -->
			</div>");
            WriteLiteral(@"
			<!-- end panel-body -->
			<!-- begin hljs-wrapper -->
			<div class=""hljs-wrapper"">
				<pre><code class=""html"">&lt;table class=""table table-bordered""&gt;
  ...
&lt;/table&gt;</code></pre>
			</div>
			<!-- end hljs-wrapper -->
		</div>
		<!-- end panel -->
	</div>
	<!-- end col-6 -->
	<!-- begin col-6 -->
	<div class=""col-xl-6"">
		<!-- begin panel -->
		<div class=""panel panel-inverse"" data-sortable-id=""table-basic-7"">
			<!-- begin panel-heading -->
			<div class=""panel-heading"">
				<h4 class=""panel-title"">UI Elements in Table <span class=""label label-success m-l-5 t-minus-1"">NEW</span></h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-c");
            WriteLiteral(@"lick=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<!-- end panel-heading -->
			<!-- begin panel-body -->
			<div class=""panel-body"">
				<!-- begin table-responsive -->
				<div class=""table-responsive"">
					<table class=""table table-striped m-b-0"">
						<thead>
							<tr>
								<th>#</th>
								<th>Username</th>
								<th>Email Address</th>
								<th width=""1%""></th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td class=""with-img"">
									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ef04913769f24ca003b0a08fb01fc647d91af8822639", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
								</td>
								<td>Nicky Almera</td>
								<td>nicky@hotmail.com</td>
								<td class=""with-btn"" nowrap>
									<a href=""#"" class=""btn btn-sm btn-primary width-60 m-r-2"">Edit</a>
									<a href=""#"" class=""btn btn-sm btn-white width-60"">Delete</a>
								</td>
							</tr>
							<tr>
								<td class=""with-img"">
									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ef04913769f24ca003b0a08fb01fc647d91af8824114", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
								</td>
								<td>Edmund Wong</td>
								<td>edmund@yahoo.com</td>
								<td class=""with-btn-group"" nowrap>
									<div class=""btn-group"">
										<a href=""#"" class=""btn btn-white btn-sm width-90"">Settings</a>
										<a href=""#"" class=""btn btn-white btn-sm dropdown-toggle width-30 no-caret"" data-toggle=""dropdown"">
										<span class=""caret""></span>
										</a>
										<div class=""dropdown-menu dropdown-menu-right"">
											<a href=""#"" class=""dropdown-item"">Action 1</a>
											<a href=""#"" class=""dropdown-item"">Action 2</a>
											<a href=""#"" class=""dropdown-item"">Action 3</a>
											<div class=""dropdown-divider""></div>
											<a href=""#"" class=""dropdown-item"">Action 4</a>
										</div>
									</div>
								</td>
							</tr>
							<tr>
								<td class=""with-img"">
									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ef04913769f24ca003b0a08fb01fc647d91af8826123", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
								</td>
								<td>Harvinder Singh</td>
								<td>harvinder@gmail.com</td>
								<td class=""with-btn"" nowrap>
									<a href=""#"" class=""btn btn-sm btn-primary width-60 m-r-2"">Edit</a>
									<a href=""#"" class=""btn btn-sm btn-white width-60"">Delete</a>
								</td>
							</tr>
						</tbody>
					</table>
				</div>
				<!-- end table-responsive -->
			</div>
			<!-- end panel-body -->
			<!-- begin hljs-wrapper -->
			<div class=""hljs-wrapper"">
				<pre><code class=""html"">&lt;table class=""table""&gt;
  &lt;tbody&gt;
    &lt;tr&gt;
      &lt;!-- with image --&gt;
      &lt;td class=""with-img""&gt;...&lt;/td&gt;

      &lt;!-- with button --&gt;
      &lt;td class=""with-btn""&gt;...&lt;/td&gt;

      &lt;!-- with button group --&gt;
      &lt;td class=""with-btn-group""&gt;...&lt;/td&gt;
     &lt;/tr&gt;
  &lt;/tbody&gt;
&lt;/table&gt;</code></pre>
			</div>
			<!-- end hljs-wrapper -->
		</div>
		<!-- end panel -->
		<!-- begin panel -->
		<div class=""panel pane");
            WriteLiteral(@"l-inverse"" data-sortable-id=""table-basic-8"">
			<!-- begin panel-heading -->
			<div class=""panel-heading"">
				<h4 class=""panel-title"">Form Elements in Table <span class=""label label-success m-l-5 t-minus-1"">NEW</span></h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<!-- end panel-heading -->
			<!-- begin panel-body -->
			<div class=""panel-body"">
				<!-- begin table-responsive -->
				<div class=""table-responsive"">
					<table class=""");
            WriteLiteral("table table-striped table-th-valign-middle table-td-valign-middle m-b-0\">\r\n\t\t\t\t\t\t<thead>\r\n\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<th class=\"with-checkbox\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"checkbox checkbox-css\">\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 17627, "\"", 17635, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""table_checkbox_1"" />
										<label for=""table_checkbox_1"">&nbsp;</label>
									</div>
								</th>
								<th>Username</th>
								<th>Email Address</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td class=""with-checkbox"">
									<div class=""checkbox checkbox-css"">
										<input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 17982, "\"", 17990, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""table_checkbox_2"" checked />
										<label for=""table_checkbox_2"">&nbsp;</label>
									</div>
								</td>
								<td>Nicky Almera</td>
								<td>nicky@hotmail.com</td>
							</tr>
							<tr>
								<td class=""with-radio"">
									<div class=""radio radio-css"">
										<input type=""radio"" id=""table_radio_1"" name=""table_radio"" checked />
										<label for=""table_radio_1"">&nbsp;</label>
									</div>
								</td>
								<td>Edmund Wong</td>
								<td>edmund@yahoo.com</td>
							</tr>
							<tr>
								<td class=""with-radio"">
									<div class=""radio radio-css"">
										<input type=""radio"" id=""table_radio_2"" name=""table_radio"" />
										<label for=""table_radio_2"">&nbsp;</label>
									</div>
								</td>
								<td class=""with-form-control""><input type=""text"" class=""form-control"" value=""Harvinder Singh"" /></td>
								<td>harvinder@gmail.com</td>
							</tr>
							<tr>
								<td class=""with-radio"">
									<div class=""radio radio-css"">");
            WriteLiteral(@"
										<input type=""radio"" id=""table_radio_3"" name=""table_radio"" />
										<label for=""table_radio_3"">&nbsp;</label>
									</div>
								</td>
								<td class=""with-input-group"">
									<div class=""input-group"">
										<div class=""input-group-prepend"">
											<span class=""input-group-text"">");
            WriteLiteral(@"@</span>
										</div>
										<input type=""text"" class=""form-control"" placeholder=""Terry"" />
									</div>
								</td>
								<td>terry@gmail.com</td>
							</tr>
						</tbody>
					</table>
				</div>
				<!-- end table-responsive -->
			</div>
			<!-- end panel-body -->
			<!-- begin hljs-wrapper -->
			<div class=""hljs-wrapper"">
				<pre><code class=""html"">&lt;table class=""table table-td-valign-middle""&gt;
  &lt;tbody&gt;
    &lt;tr&gt;
      &lt;!-- with checkbox --&gt;
      &lt;td class=""with-checkbox""&gt;...&lt;/td&gt;

      &lt;!-- with radio --&gt;
      &lt;td class=""with-radio""&gt;...&lt;/td&gt;

      &lt;!-- with form input --&gt;
      &lt;td class=""with-form-control""&gt;...&lt;/td&gt;

      &lt;!-- with input group --&gt;
      &lt;td class=""with-input-control""&gt;...&lt;/td&gt;
    &lt;/tr&gt;
  &lt;/tbody&gt;
&lt;/table&gt;</code></pre>
			</div>
			<!-- end hljs-wrapper -->
		</div>
		<!-- end panel -->
		<!-- begin panel -->
		<div class=""");
            WriteLiteral(@"panel panel-inverse"" data-sortable-id=""table-basic-9"">
			<!-- begin panel-heading -->
			<div class=""panel-heading"">
				<h4 class=""panel-title"">Table Row Classes</h4>
				<div class=""panel-heading-btn"">
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
					<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
				</div>
			</div>
			<!-- end panel-heading -->
			<!-- begin panel-body -->
			<div class=""panel-body"">
				<!-- begin table-responsive -->
				<div class=""table-responsive"">
					<table class=""table m-b-0"">
						<thead>
							<tr>
								<th>#");
            WriteLiteral(@"</th>
								<th>Username</th>
								<th>Email Address</th>
							</tr>
						</thead>
						<tbody>
							<tr class=""table-active"">
								<td>1</td>
								<td>Nicky Almera</td>
								<td>nicky@hotmail.com</td>
							</tr>
							<tr class=""table-info"">
								<td>2</td>
								<td>Terry Khoo</td>
								<td>terry@gmail.com</td>
							</tr>
							<tr class=""table-success"">
								<td>3</td>
								<td>Edmund Wong</td>
								<td>edmund@yahoo.com</td>
							</tr>
							<tr class=""table-warning"">
								<td>4</td>
								<td>Harvinder Singh</td>
								<td>harvinder@gmail.com</td>
							</tr>
							<tr class=""table-danger"">
								<td>5</td>
								<td>Terry Khoo</td>
								<td>terry@gmail.com</td>
							</tr>
						</tbody>
					</table>
				</div>
				<!-- end table-responsive -->
			</div>
			<!-- end panel-body -->
			<!-- begin hljs-wrapper -->
			<div class=""hljs-wrapper"">
				<pre><code class=""html"">&lt;table class=""table""&gt;
  &lt;");
            WriteLiteral(@"tbody&gt;
    &lt;tr class=""table-active""&gt;...&lt;/tr&gt;
    &lt;tr class=""table-info""&gt;...&lt;/tr&gt;
    &lt;tr class=""table-success""&gt;...&lt;/tr&gt;
    &lt;tr class=""table-warning""&gt;...&lt;/tr&gt;
    &lt;tr class=""table-danger""&gt;...&lt;/tr&gt;
  &lt;/tbody&gt;
&lt;/table&gt;</code></pre>
			</div>
			<!-- end hljs-wrapper -->
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
