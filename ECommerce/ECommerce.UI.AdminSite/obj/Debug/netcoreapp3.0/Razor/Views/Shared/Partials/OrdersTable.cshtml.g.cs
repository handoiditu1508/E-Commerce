#pragma checksum "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd1ebfa3cfe08d07c60ab0cce9714731862462dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials_OrdersTable), @"mvc.1.0.view", @"/Views/Shared/Partials/OrdersTable.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Application.WorkingModels.AddModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities.Sellers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities.ProductTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Application.WorkingModels.Views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.Models.SearchModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.UI.AdminSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.UI.AdminSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.UI.AdminSite.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.UI.AdminSite.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.UI.Shared.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.UI.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.UI.Shared.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using ECommerce.UI.Shared.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd1ebfa3cfe08d07c60ab0cce9714731862462dd", @"/Views/Shared/Partials/OrdersTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"766bc9fbd8c49b4d5cb749e8e3de72409ac2f3a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials_OrdersTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control submitOnChange"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("status"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("error", new global::Microsoft.AspNetCore.Html.HtmlString("Something wrong happened while changing order status"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "put", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::ECommerce.UI.Shared.Infrastructure.EnumSelectListTagHelper __ECommerce_UI_Shared_Infrastructure_EnumSelectListTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
  
//required: submit-on-change.js
//required: orders-table.css

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
  ECommerceService eCommerce = (ECommerceService)ViewData[GlobalViewBagKeys.ECommerceService];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive rounded"">
	<table class=""table table-striped table-bordered table-hover table-condensed table-sm table-active table-secondary"">
		<thead class=""thead-dark"">
			<tr>
				<th>Id</th>
				<th>Seller</th>
				<th>Product Type</th>
				<th>Customer</th>
				<th>Current Price</th>
				<th>Quantity</th>
				<th>Value</th>
				<th>Attributes</th>
				<th>Status</th>
			</tr>
		</thead>
		<tbody>
");
#nullable restore
#line 26 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
              string formAction = Url.Action("ChangeStatus", "Order");

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
             foreach (var order in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>");
#nullable restore
#line 30 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
               Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<p>");
#nullable restore
#line 32 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
                   Write($"Id: {order.SellerId}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<p>");
#nullable restore
#line 33 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
                   Write($"Name: {order.SellerName}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<p>");
#nullable restore
#line 36 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
                   Write($"Id: {order.ProductTypeId}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<div class=\"bg-light productImageContainerForOrderTable\">\r\n");
#nullable restore
#line 38 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
                          var product = (await eCommerce.GetProductByAsync(order.SellerId, order.ProductTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<img class=\"m-auto mw-100 mh-100\"");
            BeginWriteAttribute("src", " src=\"", 1138, "\"", 1245, 1);
#nullable restore
#line 39 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
WriteAttributeValue("", 1144, $"{UIConsts.GetProductUrlById(order.SellerId, order.ProductTypeId)}/{product.RepresentativeImage}", 1144, 101, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<p>");
#nullable restore
#line 41 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
                   Write($"Name: {order.ProductTypeName}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<p>");
#nullable restore
#line 44 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
                   Write($"Id: {order.CustomerId}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<p>");
#nullable restore
#line 45 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
                   Write($"Name: {order.CustomerName}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 47 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
               Write(order.CurrentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td class=\"text-center\">");
#nullable restore
#line 48 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
                                   Write(order.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 49 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
               Write(order.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>\r\n");
#nullable restore
#line 51 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
                     foreach(var attribute in order.Attributes)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<p>");
#nullable restore
#line 53 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
                   Write($"{attribute.Key}: {attribute.Value}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 54 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1ebfa3cfe08d07c60ab0cce9714731862462dd16101", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<input type=\"hidden\" name=\"orderId\"");
                BeginWriteAttribute("value", " value=\"", 1781, "\"", 1798, 1);
#nullable restore
#line 58 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
WriteAttributeValue("", 1789, order.Id, 1789, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1ebfa3cfe08d07c60ab0cce9714731862462dd16859", async() => {
                }
                );
                __ECommerce_UI_Shared_Infrastructure_EnumSelectListTagHelper = CreateTagHelper<global::ECommerce.UI.Shared.Infrastructure.EnumSelectListTagHelper>();
                __tagHelperExecutionContext.Add(__ECommerce_UI_Shared_Infrastructure_EnumSelectListTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 59 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
__ECommerce_UI_Shared_Infrastructure_EnumSelectListTagHelper.EnumType = typeof(OrderStatus);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("enum-type", __ECommerce_UI_Shared_Infrastructure_EnumSelectListTagHelper.EnumType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
__ECommerce_UI_Shared_Infrastructure_EnumSelectListTagHelper.Selected = order.Status;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("selected", __ECommerce_UI_Shared_Infrastructure_EnumSelectListTagHelper.Selected, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
__ECommerce_UI_Shared_Infrastructure_EnumSelectListTagHelper.Disabled = product.Model==OperatingModel.ODF?true:false;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("disabled", __ECommerce_UI_Shared_Infrastructure_EnumSelectListTagHelper.Disabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 57 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
AddHtmlAttributeValue("", 1712, formAction, 1712, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 63 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.AdminSite\Views\Shared\Partials\OrdersTable.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderView>> Html { get; private set; }
    }
}
#pragma warning restore 1591