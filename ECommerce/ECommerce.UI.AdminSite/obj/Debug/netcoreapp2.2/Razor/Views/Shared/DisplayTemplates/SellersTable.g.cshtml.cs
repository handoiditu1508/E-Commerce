#pragma checksum "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\SellersTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "395d244326e5e80ca00db4149647d9fa3838a852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_SellersTable), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/SellersTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DisplayTemplates/SellersTable.cshtml", typeof(AspNetCore.Views_Shared_DisplayTemplates_SellersTable))]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities;

#line default
#line hidden
#line 2 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities.Sellers;

#line default
#line hidden
#line 3 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities.ProductTypes;

#line default
#line hidden
#line 4 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Application;

#line default
#line hidden
#line 5 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Application.Views;

#line default
#line hidden
#line 6 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Application.SearchModels;

#line default
#line hidden
#line 7 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.UI.AdminSite;

#line default
#line hidden
#line 8 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.UI.AdminSite.Models;

#line default
#line hidden
#line 9 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.UI.AdminSite.Infrastructure;

#line default
#line hidden
#line 10 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.UI.AdminSite.Models.ViewModels;

#line default
#line hidden
#line 11 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Routing;

#line default
#line hidden
#line 12 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"395d244326e5e80ca00db4149647d9fa3838a852", @"/Views/Shared/DisplayTemplates/SellersTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a5dd05f79130d1ab8fb5ab7a3426d357cb1b7d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_SellersTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SellerView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Informations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Seller", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("submitOnChange"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("status"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::ECommerce.UI.AdminSite.Infrastructure.EnumSelectListTagHelper __ECommerce_UI_AdminSite_Infrastructure_EnumSelectListTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 320, true);
            WriteLiteral(@"
<div class=""table-responsive rounded"">
	<table class=""table table-striped table-bordered table-hover table-condensed table-sm table-secondary table-active"">
		<thead class=""thead-dark"">
			<tr>
				<th>Email</th>
				<th>Name</th>
				<th>Phone Number</th>
				<th>Status</th>
			</tr>
		</thead>
		<tbody>
");
            EndContext();
#line 14 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\SellersTable.cshtml"
              string formAction = Url.Action("ChangeStatus", "Seller");

#line default
#line hidden
            BeginContext(417, 3, true);
            WriteLiteral("\t\t\t");
            EndContext();
#line 15 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\SellersTable.cshtml"
             foreach (SellerView seller in Model)
			{

#line default
#line hidden
            BeginContext(465, 19, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(484, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "395d244326e5e80ca00db4149647d9fa3838a8528391", async() => {
                BeginContext(599, 12, false);
#line 18 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\SellersTable.cshtml"
                                                                                                                                     Write(seller.Email);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sellerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\SellersTable.cshtml"
                                                                                     WriteLiteral(seller.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sellerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sellerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sellerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(615, 16, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(631, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "395d244326e5e80ca00db4149647d9fa3838a85211389", async() => {
                BeginContext(746, 11, false);
#line 19 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\SellersTable.cshtml"
                                                                                                                                     Write(seller.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sellerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\SellersTable.cshtml"
                                                                                     WriteLiteral(seller.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sellerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sellerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sellerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(761, 16, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(778, 18, false);
#line 20 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\SellersTable.cshtml"
                   Write(seller.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(796, 24, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(820, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "395d244326e5e80ca00db4149647d9fa3838a85214792", async() => {
                BeginContext(861, 45, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t<input name=\"sellerId\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 906, "\"", 924, 1);
#line 23 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\SellersTable.cshtml"
WriteAttributeValue("", 914, seller.Id, 914, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(925, 12, true);
                WriteLiteral(" />\r\n\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(937, 112, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "395d244326e5e80ca00db4149647d9fa3838a85215687", async() => {
                }
                );
                __ECommerce_UI_AdminSite_Infrastructure_EnumSelectListTagHelper = CreateTagHelper<global::ECommerce.UI.AdminSite.Infrastructure.EnumSelectListTagHelper>();
                __tagHelperExecutionContext.Add(__ECommerce_UI_AdminSite_Infrastructure_EnumSelectListTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 24 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\SellersTable.cshtml"
__ECommerce_UI_AdminSite_Infrastructure_EnumSelectListTagHelper.EnumType = typeof(SellerStatus);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enum-type", __ECommerce_UI_AdminSite_Infrastructure_EnumSelectListTagHelper.EnumType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\SellersTable.cshtml"
__ECommerce_UI_AdminSite_Infrastructure_EnumSelectListTagHelper.Selected = seller.Status;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("selected", __ECommerce_UI_AdminSite_Infrastructure_EnumSelectListTagHelper.Selected, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1049, 8, true);
                WriteLiteral("\r\n\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\SellersTable.cshtml"
AddHtmlAttributeValue("", 834, formAction, 834, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1064, 25, true);
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 28 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\SellersTable.cshtml"
			}

#line default
#line hidden
            BeginContext(1095, 497, true);
            WriteLiteral(@"		</tbody>
	</table>
</div>

<script type=""text/javascript"">
	//change user status

	$('.submitOnChange').change(function () {
		var $form = $(this).closest('form');
		$.ajax({
			url: $form.attr('action'),
			type: $form.attr('method'),
			data: $form.serialize(),
			success: function (result) {
				if (result != '')
					alert(result);
			},
			error: function (result) {
				alert('something went wrong while changing user status:\n' + result);
			}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SellerView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
