#pragma checksum "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22910b03a2e4ab43cb8ff370c3ba50625d0eb958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_OrdersTable), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/OrdersTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DisplayTemplates/OrdersTable.cshtml", typeof(AspNetCore.Views_Shared_DisplayTemplates_OrdersTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22910b03a2e4ab43cb8ff370c3ba50625d0eb958", @"/Views/Shared/DisplayTemplates/OrdersTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a5dd05f79130d1ab8fb5ab7a3426d357cb1b7d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_OrdersTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/sample.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Informations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Seller", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::ECommerce.UI.AdminSite.Infrastructure.ImageTagHelper __ECommerce_UI_AdminSite_Infrastructure_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 550, true);
            WriteLiteral(@"
<div class=""table-responsive rounded"">
	<table class=""table table-striped table-bordered table-hover table-condensed table-sm table-active table-secondary"">
		<thead class=""thead-dark"">
			<tr>
				<th style=""width:30%;""></th>
				<th style=""width:10%;"">Item</th>
				<th style=""width:10%;"">Seller</th>
				<th style=""width:10%;"">Attributes</th>
				<th style=""width:10%;"">Quantity</th>
				<th class=""text-right"" style=""width:10%;"">Price</th>
				<th class=""text-right"" style=""width:10%;"">Subtotal</th>
			</tr>
		</thead>
		<tbody>
");
            EndContext();
#line 17 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
              
				ECommerceService eCommerce = (ECommerceService)ViewData[GlobalViewBagKeys.ECommerceService];
				string removeAction = Url.Action("RemoveFromCart", "Cart");
				string changeQuantityAction = Url.Action("ChangeQuantity", "Cart");
				foreach (OrderView order in Model)
				{
					ProductView product = eCommerce.GetProductBy(int.Parse(order.SellerId), int.Parse(order.ProductTypeId));

#line default
#line hidden
            BeginContext(982, 45, true);
            WriteLiteral("\t\t\t\t\t<tr class=\"orderTableRow\">\r\n\t\t\t\t\t\t<td>\r\n");
            EndContext();
#line 26 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
                         if (product != null)
						{

#line default
#line hidden
            BeginContext(1065, 7, true);
            WriteLiteral("\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1072, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22910b03a2e4ab43cb8ff370c3ba50625d0eb9588895", async() => {
            }
            );
            __ECommerce_UI_AdminSite_Infrastructure_ImageTagHelper = CreateTagHelper<global::ECommerce.UI.AdminSite.Infrastructure.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__ECommerce_UI_AdminSite_Infrastructure_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 28 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
__ECommerce_UI_AdminSite_Infrastructure_ImageTagHelper.FileContent = product.RepresentativeImage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("file-content", __ECommerce_UI_AdminSite_Infrastructure_ImageTagHelper.FileContent, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
AddHtmlAttributeValue("", 1151, order.ProductTypeName, 1151, 22, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1177, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
						}
						else
						{

#line default
#line hidden
            BeginContext(1209, 7, true);
            WriteLiteral("\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1216, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22910b03a2e4ab43cb8ff370c3ba50625d0eb95811256", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 32 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
AddHtmlAttributeValue("", 1278, order.ProductTypeName, 1278, 22, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1304, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 33 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
						}

#line default
#line hidden
            BeginContext(1315, 41, true);
            WriteLiteral("\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td class=\"text-left\">");
            EndContext();
            BeginContext(1356, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22910b03a2e4ab43cb8ff370c3ba50625d0eb95813282", async() => {
                BeginContext(1491, 21, false);
#line 35 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
                                                                                                                                                                               Write(order.ProductTypeName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productTypeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
                                                                                                                                                  WriteLiteral(order.ProductTypeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productTypeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productTypeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productTypeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1516, 35, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td class=\"text-left\">");
            EndContext();
            BeginContext(1551, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22910b03a2e4ab43cb8ff370c3ba50625d0eb95816446", async() => {
                BeginContext(1671, 16, false);
#line 36 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
                                                                                                                                                                Write(order.SellerName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sellerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
                                                                                                                                        WriteLiteral(order.SellerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sellerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sellerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sellerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1691, 37, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td class=\"text-left\">\r\n");
            EndContext();
#line 38 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
                             foreach (var attribute in order.Attributes)
							{

#line default
#line hidden
            BeginContext(1791, 11, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<p>");
            EndContext();
            BeginContext(1803, 13, false);
#line 40 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
                              Write(attribute.Key);

#line default
#line hidden
            EndContext();
            BeginContext(1816, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1819, 15, false);
#line 40 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
                                              Write(attribute.Value);

#line default
#line hidden
            EndContext();
            BeginContext(1834, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 41 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
							}

#line default
#line hidden
            BeginContext(1850, 43, true);
            WriteLiteral("\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td class=\"text-center\">");
            EndContext();
            BeginContext(1894, 14, false);
#line 43 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
                                           Write(order.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1908, 36, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td class=\"text-right\">");
            EndContext();
            BeginContext(1945, 41, false);
#line 44 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
                                          Write(CurrencyFormat.Format(order.CurrentPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1986, 36, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td class=\"text-right\">");
            EndContext();
            BeginContext(2023, 84, false);
#line 45 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
                                          Write(CurrencyFormat.Format(decimal.Parse(order.CurrentPrice) * int.Parse(order.Quantity)));

#line default
#line hidden
            EndContext();
            BeginContext(2107, 19, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n");
            EndContext();
#line 47 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\OrdersTable.cshtml"
				}
			

#line default
#line hidden
            BeginContext(2139, 29, true);
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
