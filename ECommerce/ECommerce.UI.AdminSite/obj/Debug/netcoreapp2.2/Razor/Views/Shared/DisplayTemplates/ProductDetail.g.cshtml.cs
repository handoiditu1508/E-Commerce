#pragma checksum "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7925c9d50d5a17e9a63fa26866a3117b92fe5ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_ProductDetail), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/ProductDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DisplayTemplates/ProductDetail.cshtml", typeof(AspNetCore.Views_Shared_DisplayTemplates_ProductDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7925c9d50d5a17e9a63fa26866a3117b92fe5ab", @"/Views/Shared/DisplayTemplates/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a5dd05f79130d1ab8fb5ab7a3426d357cb1b7d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Informations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight-bold text-uppercase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Seller", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("submitOnChange form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("status"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("true-label", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("false-label", "Reduce", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("isAdd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeQuantity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("changeProductQuantityOnSubmit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::ECommerce.UI.AdminSite.Infrastructure.EnumSelectListTagHelper __ECommerce_UI_AdminSite_Infrastructure_EnumSelectListTagHelper;
        private global::ECommerce.UI.AdminSite.Infrastructure.BooleanSelectListTagHelper __ECommerce_UI_AdminSite_Infrastructure_BooleanSelectListTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
  ECommerceService eCommerce = (ECommerceService)ViewData[GlobalViewBagKeys.ECommerceService];

#line default
#line hidden
            BeginContext(119, 271, true);
            WriteLiteral(@"<div class=""container"">
	<div class=""card productDetailCard"">
		<div class=""container-fliud"">
			<div class=""wrapper row"">
				<div class=""preview col-md-6"">
					<div id=""galleryResult"" class=""preview-pic tab-content"">
						<div class=""galleryThumbnail"">
							");
            EndContext();
            BeginContext(390, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7925c9d50d5a17e9a63fa26866a3117b92fe5ab11951", async() => {
            }
            );
            __ECommerce_UI_AdminSite_Infrastructure_ImageTagHelper = CreateTagHelper<global::ECommerce.UI.AdminSite.Infrastructure.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__ECommerce_UI_AdminSite_Infrastructure_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 11 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
__ECommerce_UI_AdminSite_Infrastructure_ImageTagHelper.FileContent = Model.RepresentativeImage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("file-content", __ECommerce_UI_AdminSite_Infrastructure_ImageTagHelper.FileContent, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(455, 203, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div id=\"carouselExampleControls\" class=\"preview-thumbnail nav nav-tabs carousel slide\" data-ride=\"carousel\" data-interval=\"false\">\r\n\t\t\t\t\t\t<div class=\"carousel-inner\">\r\n");
            EndContext();
#line 16 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
                              
								IList<FileContent> images = eCommerce.GetProductImages(int.Parse(Model.SellerId), int.Parse(Model.ProductTypeId)).ToList();
								short count = 1;
								TagBuilder container = new TagBuilder("div");
								TagBuilder carouselItem = new TagBuilder("div");
								carouselItem.AddCssClass("carousel-item active");
								container.InnerHtml.AppendHtml(carouselItem);
								foreach (FileContent image in images)
								{
									carouselItem.InnerHtml
										.AppendHtml($"<div class=\"galleryThumbnail\"><img src=\"{image.EncodeInBase64()}\" /></div>");
									if (count++ == 5)
									{
										carouselItem = new TagBuilder("div");
										carouselItem.AddCssClass("carousel-item active");
										container.InnerHtml.AppendHtml(carouselItem);
										count = 1;
									}
								}
							

#line default
#line hidden
            BeginContext(1515, 7, true);
            WriteLiteral("\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1523, 19, false);
#line 36 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
                       Write(container.InnerHtml);

#line default
#line hidden
            EndContext();
            BeginContext(1542, 560, true);
            WriteLiteral(@"
						</div>
						<a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
							<span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
							<span class=""sr-only"">Previous</span>
						</a>
						<a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
							<span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
							<span class=""sr-only"">Next</span>
						</a>
					</div>
				</div>
				<div class=""details col-md-6"">
					<h3>");
            EndContext();
            BeginContext(2102, 171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7925c9d50d5a17e9a63fa26866a3117b92fe5ab15915", async() => {
                BeginContext(2248, 21, false);
#line 49 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
                                                                                                                                                                    Write(Model.ProductTypeName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productTypeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
                                                                                               WriteLiteral(Model.ProductTypeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productTypeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productTypeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productTypeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2273, 570, true);
            WriteLiteral(@"</h3>
					<div>
						<div>
							<span class=""fa fa-star checked""></span>
							<span class=""fa fa-star checked""></span>
							<span class=""fa fa-star checked""></span>
							<span class=""fa fa-star""></span>
							<span class=""fa fa-star""></span>
						</div>
						<span>41 reviews</span>
					</div>
					<p>Suspendisse quos? Tempus cras iure temporibus? Eu laudantium cubilia sem sem! Repudiandae et! Massa senectus enim minim sociosqu delectus posuere.</p>
					<h4 class=""font-weight-bold text-uppercase"">current price: <span class=""text-warning"">");
            EndContext();
            BeginContext(2844, 42, false);
#line 61 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
                                                                                                     Write(CurrencyFormat.FormatWithUnit(Model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2886, 71, true);
            WriteLiteral("</span></h4>\r\n\t\t\t\t\t<h4 class=\"font-weight-bold text-uppercase\">SELLER: ");
            EndContext();
            BeginContext(2957, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7925c9d50d5a17e9a63fa26866a3117b92fe5ab20117", async() => {
                BeginContext(3069, 16, false);
#line 62 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
                                                                                                                                                                                  Write(Model.SellerName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sellerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
                                                                                                                                                          WriteLiteral(Model.SellerId);

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
            BeginContext(3089, 114, true);
            WriteLiteral("</h4>\r\n\t\t\t\t\t<p class=\"vote\"><strong>91%</strong> of buyers enjoyed this product! <strong>(87 votes)</strong></p>\r\n");
            EndContext();
#line 64 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
                     foreach (var attribute in Model.Attributes)
					{

#line default
#line hidden
            BeginContext(3262, 59, true);
            WriteLiteral("\t\t\t\t\t\t<h5 class=\"font-weight-bold text-uppercase\">\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3322, 13, false);
#line 67 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
                       Write(attribute.Key);

#line default
#line hidden
            EndContext();
            BeginContext(3335, 3, true);
            WriteLiteral(":\r\n");
            EndContext();
#line 68 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
                             foreach (var value in attribute.Value)
							{

#line default
#line hidden
            BeginContext(3396, 89, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<label class=\"radio-inline text-info\">\r\n\t\t\t\t\t\t\t\t\t<input type=\"radio\" disabled /> ");
            EndContext();
            BeginContext(3486, 5, false);
#line 71 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
                                                               Write(value);

#line default
#line hidden
            EndContext();
            BeginContext(3491, 20, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</label>\r\n");
            EndContext();
#line 73 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
							}

#line default
#line hidden
            BeginContext(3521, 13, true);
            WriteLiteral("\t\t\t\t\t\t</h5>\r\n");
            EndContext();
#line 75 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
					}

#line default
#line hidden
            BeginContext(3542, 106, true);
            WriteLiteral("\t\t\t\t\t<h5 class=\"font-weight-bold text-uppercase\">Quantity:<input id=\"productQuantity\" type=\"text\" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3648, "\"", 3671, 1);
#line 76 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
WriteAttributeValue("", 3656, Model.Quantity, 3656, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3672, 67, true);
            WriteLiteral(" /></h5>\r\n\t\t\t\t\t<h5 class=\"font-weight-bold text-uppercase\">Active: ");
            EndContext();
            BeginContext(3740, 12, false);
#line 77 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
                                                                   Write(Model.Active);

#line default
#line hidden
            EndContext();
            BeginContext(3752, 75, true);
            WriteLiteral("</h5>\r\n\t\t\t\t\t<h5 class=\"font-weight-bold text-uppercase\">Status:</h5>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(3827, 370, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7925c9d50d5a17e9a63fa26866a3117b92fe5ab26657", async() => {
                BeginContext(3898, 44, true);
                WriteLiteral("\r\n\t\t\t\t\t\t<input name=\"sellerId\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3942, "\"", 3965, 1);
#line 80 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
WriteAttributeValue("", 3950, Model.SellerId, 3950, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3966, 52, true);
                WriteLiteral(" />\r\n\t\t\t\t\t\t<input name=\"productTypeId\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4018, "\"", 4046, 1);
#line 81 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
WriteAttributeValue("", 4026, Model.ProductTypeId, 4026, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4047, 11, true);
                WriteLiteral(" />\r\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(4058, 125, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7925c9d50d5a17e9a63fa26866a3117b92fe5ab28077", async() => {
                }
                );
                __ECommerce_UI_AdminSite_Infrastructure_EnumSelectListTagHelper = CreateTagHelper<global::ECommerce.UI.AdminSite.Infrastructure.EnumSelectListTagHelper>();
                __tagHelperExecutionContext.Add(__ECommerce_UI_AdminSite_Infrastructure_EnumSelectListTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#line 82 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
__ECommerce_UI_AdminSite_Infrastructure_EnumSelectListTagHelper.EnumType = typeof(ProductStatus);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enum-type", __ECommerce_UI_AdminSite_Infrastructure_EnumSelectListTagHelper.EnumType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 82 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
__ECommerce_UI_AdminSite_Infrastructure_EnumSelectListTagHelper.Selected = Model.Status;

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
                BeginContext(4183, 7, true);
                WriteLiteral("\r\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4197, 86, true);
            WriteLiteral("\r\n\t\t\t\t\t<h5 class=\"font-weight-bold text-uppercase\">Add or reduce quantity:</h5>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(4283, 793, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7925c9d50d5a17e9a63fa26866a3117b92fe5ab32154", async() => {
                BeginContext(4394, 154, true);
                WriteLiteral("\r\n\t\t\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<div class=\"input-group\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"input-group-prepend\">\r\n\t\t\t\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(4548, 117, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7925c9d50d5a17e9a63fa26866a3117b92fe5ab32749", async() => {
                }
                );
                __ECommerce_UI_AdminSite_Infrastructure_BooleanSelectListTagHelper = CreateTagHelper<global::ECommerce.UI.AdminSite.Infrastructure.BooleanSelectListTagHelper>();
                __tagHelperExecutionContext.Add(__ECommerce_UI_AdminSite_Infrastructure_BooleanSelectListTagHelper);
#line 90 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
__ECommerce_UI_AdminSite_Infrastructure_BooleanSelectListTagHelper.SelectedBoolValue = null;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("selected-bool-value", __ECommerce_UI_AdminSite_Infrastructure_BooleanSelectListTagHelper.SelectedBoolValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __ECommerce_UI_AdminSite_Infrastructure_BooleanSelectListTagHelper.TrueLabel = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __ECommerce_UI_AdminSite_Infrastructure_BooleanSelectListTagHelper.FalseLabel = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4665, 175, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"number\" name=\"number\" />\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<input type=\"hidden\" name=\"sellerId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4840, "\"", 4863, 1);
#line 96 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
WriteAttributeValue("", 4848, Model.SellerId, 4848, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4864, 52, true);
                WriteLiteral(" />\r\n\t\t\t\t\t\t<input type=\"hidden\" name=\"productTypeId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4916, "\"", 4944, 1);
#line 97 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.AdminSite\Views\Shared\DisplayTemplates\ProductDetail.cshtml"
WriteAttributeValue("", 4924, Model.ProductTypeId, 4924, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4945, 124, true);
                WriteLiteral(" />\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<input class=\"btn btn-lg btn-success\" type=\"submit\" value=\"Change quantity\" />\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5076, 642, true);
            WriteLiteral(@"
				</div>
			</div>
		</div>
	</div>
</div>

<script type=""text/javascript"">
	//change product status

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
				alert('something went wrong while changing product status:\n' + result);
			}
		});
	});

	//product detail

	$('.galleryThumbnail').click(function(){
		$('#galleryResult').html($(this).clone());
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductView> Html { get; private set; }
    }
}
#pragma warning restore 1591