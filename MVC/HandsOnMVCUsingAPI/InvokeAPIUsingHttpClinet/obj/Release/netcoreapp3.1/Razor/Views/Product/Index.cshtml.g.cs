#pragma checksum "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b774a9fc7ff8eae9211013ba7db42da7af4bf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\_ViewImports.cshtml"
using InvokeAPIUsingHttpClinet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\_ViewImports.cshtml"
using InvokeAPIUsingHttpClinet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b774a9fc7ff8eae9211013ba7db42da7af4bf6", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07e21b52213627fffd4d7cdfc2946caec08d55c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InvokeAPIUsingHttpClinet.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<p>
	<button type=""button"" class=""btn btn-primary float-left pull-left"" data-toggle=""modal"" data-target=""#addProductModal"">
		Add Product
	</button>
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 18 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.Pid}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 49 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Pid }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 50 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Pid }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "D:\MindMajix\Batch-06-11\API\HandsOnMVCUsingAPI\InvokeAPIUsingHttpClinet\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"modal fade\" id=\"addProductModal\">\r\n\t<div class=\"modal-dialog\">\r\n\t\t<div class=\"modal-content\">\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7b774a9fc7ff8eae9211013ba7db42da7af4bf68506", async() => {
                WriteLiteral(@"
				<div class=""modal-header"">
					<h3 class=""modal-title"">Add New Product</h3>
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
						<span aria-hidden=""true"">&times;</span>
					</button>
				</div>
				<div class=""modal-body"">
				</div>
				<div class=""modal-footer"">
					<input type=""submit"" value=""Create"" class=""btn btn-success"" />
					<input type=""button"" value=""Cancel"" class=""btn btn-primary"" data-dismiss=""modal"" />
				</div>
			");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InvokeAPIUsingHttpClinet.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591