#pragma checksum "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Seller\AttributesStates.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf25719aaed51e950a7b430d9e82f269a095cc9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seller_AttributesStates), @"mvc.1.0.view", @"/Views/Seller/AttributesStates.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Seller/AttributesStates.cshtml", typeof(AspNetCore.Views_Seller_AttributesStates))]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Application;

#line default
#line hidden
#line 2 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Application.Views;

#line default
#line hidden
#line 3 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Application.AddModels;

#line default
#line hidden
#line 4 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Application.UpdateModels;

#line default
#line hidden
#line 5 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Application.SearchModels;

#line default
#line hidden
#line 6 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.UI.MVC;

#line default
#line hidden
#line 7 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.UI.MVC.Models;

#line default
#line hidden
#line 8 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.UI.MVC.Infrastructure;

#line default
#line hidden
#line 9 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.UI.MVC.Models.ViewModels;

#line default
#line hidden
#line 10 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.UI.Shared;

#line default
#line hidden
#line 11 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities;

#line default
#line hidden
#line 12 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities.Sellers;

#line default
#line hidden
#line 13 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities.ProductTypes;

#line default
#line hidden
#line 14 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.UI.Shared.Extensions;

#line default
#line hidden
#line 15 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Routing;

#line default
#line hidden
#line 16 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#line 17 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf25719aaed51e950a7b430d9e82f269a095cc9e", @"/Views/Seller/AttributesStates.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33b61cb7095554506aa9d834701448aca0e027d", @"/Views/_ViewImports.cshtml")]
    public class Views_Seller_AttributesStates : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AttributesStatesTableViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 36, true);
            WriteLiteral("\r\n<input type=\"hidden\" id=\"sellerId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 75, "\"", 98, 1);
#line 3 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Seller\AttributesStates.cshtml"
WriteAttributeValue("", 83, Model.SellerId, 83, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(99, 44, true);
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"productTypeId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 143, "\"", 171, 1);
#line 4 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Seller\AttributesStates.cshtml"
WriteAttributeValue("", 151, Model.ProductTypeId, 151, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(172, 51, true);
            WriteLiteral(" />\r\n\r\n<div id=\"AttributesStatesTableContainer\">\r\n\t");
            EndContext();
            BeginContext(224, 48, false);
#line 7 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Seller\AttributesStates.cshtml"
Write(await Html.PartialAsync("AttributesStatesTable"));

#line default
#line hidden
            EndContext();
            BeginContext(272, 1314, true);
            WriteLiteral(@";
</div>

<script type=""text/javascript"">
$(document).ready(function(){

	//add attributes state
	$('#AttributesStatesTableContainer').on('click', '.addAttributesStatesBtn',
		function (event) {

			let attributesState = {};
			$('.addAttributesStatesInput').each(function (index, element) {
				attributesState[$(this).attr('name')] = $(this).val();
			});

			$.ajax({
				url: $('#addAttributesStateUrl').val(),
				type: 'post',
				data: {
					productTypeId: $('#productTypeId').val(),
					attributesState: attributesState
				},
				success: function (result) {
					$('#AttributesStatesTableContainer').html(result);
				},
				error: function (result) {
					alert('Something went wrong while adding attributes state');
				}
			});
		});

	//delete attributes state
	$('#AttributesStatesTableContainer').on('submit', '.deleteAttributesStateOnSubmit',
		function (event) {
			event.preventDefault();
			let $form = $(this);
			$.ajax({
				url: $form.attr('action'),
				type:");
            WriteLiteral(@" $form.attr('method'),
				data: $form.serialize(),
				success: function (result) {
					$('#AttributesStatesTableContainer').html(result);
				},
				error: function (result) {
					alert('Something went wrong while deleting attributes state');
				}
			});
		});
});
</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AttributesStatesTableViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591