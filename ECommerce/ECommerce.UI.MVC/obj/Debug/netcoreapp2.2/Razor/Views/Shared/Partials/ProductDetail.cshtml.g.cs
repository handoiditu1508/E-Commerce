#pragma checksum "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab99affc42cc0173eb3cd0035ec1c0e3cd4ec4dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials_ProductDetail), @"mvc.1.0.view", @"/Views/Shared/Partials/ProductDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partials/ProductDetail.cshtml", typeof(AspNetCore.Views_Shared_Partials_ProductDetail))]
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
using ECommerce.Application.WorkingModels.Views;

#line default
#line hidden
#line 3 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Application.WorkingModels.AddModels;

#line default
#line hidden
#line 4 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Application.WorkingModels.UpdateModels;

#line default
#line hidden
#line 5 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Models.SearchModels;

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
using ECommerce.UI.Shared.Models;

#line default
#line hidden
#line 12 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.UI.Shared.Models.ViewModels;

#line default
#line hidden
#line 13 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities;

#line default
#line hidden
#line 14 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities.Sellers;

#line default
#line hidden
#line 15 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities.ProductTypes;

#line default
#line hidden
#line 16 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities.Customers;

#line default
#line hidden
#line 17 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.UI.Shared.Extensions;

#line default
#line hidden
#line 18 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.UI.Shared.Infrastructure;

#line default
#line hidden
#line 19 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Routing;

#line default
#line hidden
#line 20 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#line 21 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab99affc42cc0173eb3cd0035ec1c0e3cd4ec4dd", @"/Views/Shared/Partials/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a62bbe6e59876a3b95efd28fbfbfe91884dc3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight-bold text-uppercase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Seller", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("addToCartOnSubmit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
  
//required: update-small-cart.js, product-detail.js
//required: product-detail.css

#line default
#line hidden
            BeginContext(114, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
  ECommerceService eCommerce = (ECommerceService)ViewData[GlobalViewBagKeys.ECommerceService];

#line default
#line hidden
            BeginContext(213, 36, true);
            WriteLiteral("\r\n<input type=\"hidden\" id=\"sellerId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 249, "\"", 272, 1);
#line 10 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
WriteAttributeValue("", 257, Model.SellerId, 257, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(273, 44, true);
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"productTypeId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 317, "\"", 345, 1);
#line 11 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
WriteAttributeValue("", 325, Model.ProductTypeId, 325, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(346, 323, true);
            WriteLiteral(@" />

	<div class=""card productDetailCard"">
		<div class=""container-fliud"">
			<div class=""wrapper row"">
				<div class=""preview col-md-6 galleryContainer border border-top-0 border-left-0 border-bottom-0"">
					<div class=""galleryResult tab-content"">
						<div class=""galleryThumbnail"">
							<img class=""rounded""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 669, "\"", 774, 1);
#line 19 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
WriteAttributeValue("", 675, $"{UIConsts.GetProductUrlById(Model.SellerId, Model.ProductTypeId)}/{Model.RepresentativeImage}", 675, 99, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(775, 32, true);
            WriteLiteral(" />\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
            EndContext();
#line 22 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
                      
						var rand = new Random();
						string carouselUid = "a" + rand.Next();
					

#line default
#line hidden
            BeginContext(903, 9, true);
            WriteLiteral("\t\t\t\t\t<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 912, "\"", 929, 1);
#line 26 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
WriteAttributeValue("", 917, carouselUid, 917, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(930, 136, true);
            WriteLiteral(" class=\"preview-thumbnail nav nav-tabs carousel slide\" data-ride=\"carousel\" data-interval=\"false\">\r\n\t\t\t\t\t\t<div class=\"carousel-inner\">\r\n");
            EndContext();
#line 28 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
                              
								//IList<string> images = (await eCommerce.GetProductImagesAsync(Model.SellerId, Model.ProductTypeId)).ToList();
								short count = 1;
								TagBuilder container = new TagBuilder("div");
								TagBuilder carouselItem = new TagBuilder("div");
								carouselItem.AddCssClass("carousel-item active");
								container.InnerHtml.AppendHtml(carouselItem);
								foreach (string image in Model.Images)
								{
									carouselItem.InnerHtml
										.AppendHtml($"<div class=\"galleryThumbnail\"><img class=\"rounded m-auto mw-100 mh-100\" src=\"{UIConsts.GetProductUrlById(Model.SellerId, Model.ProductTypeId)}/{image}\" /></div>");
									if (count % 5 == 0 && count < Model.Images.Count())
									{
										carouselItem = new TagBuilder("div");
										carouselItem.AddCssClass("carousel-item");
										container.InnerHtml.AppendHtml(carouselItem);
									}
									count++;
								}
							

#line default
#line hidden
            BeginContext(2024, 7, true);
            WriteLiteral("\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2032, 19, false);
#line 48 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
                       Write(container.InnerHtml);

#line default
#line hidden
            EndContext();
            BeginContext(2051, 54, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<a class=\"carousel-control-prev\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2105, "\"", 2127, 2);
            WriteAttributeValue("", 2112, "#", 2112, 1, true);
#line 50 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
WriteAttributeValue("", 2113, carouselUid, 2113, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2128, 207, true);
            WriteLiteral(" role=\"button\" data-slide=\"prev\">\r\n\t\t\t\t\t\t\t<span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n\t\t\t\t\t\t\t<span class=\"sr-only\">Previous</span>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t<a class=\"carousel-control-next\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2335, "\"", 2357, 2);
            WriteAttributeValue("", 2342, "#", 2342, 1, true);
#line 54 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
WriteAttributeValue("", 2343, carouselUid, 2343, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2358, 241, true);
            WriteLiteral(" role=\"button\" data-slide=\"next\">\r\n\t\t\t\t\t\t\t<span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n\t\t\t\t\t\t\t<span class=\"sr-only\">Next</span>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t\r\n\t\t\t\t<div class=\"details col-md-6\">\r\n\t\t\t\t\t<h3>");
            EndContext();
            BeginContext(2599, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab99affc42cc0173eb3cd0035ec1c0e3cd4ec4dd17277", async() => {
                BeginContext(2740, 21, false);
#line 62 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
                                                                                                                                                               Write(Model.ProductTypeName);

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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productTypeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
                                                                                          WriteLiteral(Model.ProductTypeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productTypeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productTypeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productTypeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2765, 19, true);
            WriteLiteral("</h3>\r\n\t\t\t\t\t<div>\r\n");
            EndContext();
#line 64 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
                          
							int reviewsCount = eCommerce.CountCommentsByProductIds(new CommentSearchModel { SellerId = Model.SellerId, ProductTypeId = Model.ProductTypeId });
							float averageRatings = eCommerce.AverageNumberOfRatings(Model.SellerId, Model.ProductTypeId);
						

#line default
#line hidden
            BeginContext(3060, 48, true);
            WriteLiteral("\t\t\t\t\t\t<input class=\"rating-loading product-star\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3108, "\"", 3131, 1);
#line 68 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
WriteAttributeValue("", 3116, averageRatings, 3116, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3132, 15, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(3148, 12, false);
#line 69 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
                         Write(reviewsCount);

#line default
#line hidden
            EndContext();
            BeginContext(3160, 281, true);
            WriteLiteral(@" reviews</span>
					</div>
					<p>Suspendisse quos? Tempus cras iure temporibus? Eu laudantium cubilia sem sem! Repudiandae et! Massa senectus enim minim sociosqu delectus posuere.</p>
					<h4 class=""font-weight-bold text-uppercase"">current price: <span class=""text-warning"">");
            EndContext();
            BeginContext(3442, 42, false);
#line 72 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
                                                                                                     Write(CurrencyFormat.FormatWithUnit(Model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3484, 71, true);
            WriteLiteral("</span></h4>\r\n\t\t\t\t\t<h4 class=\"font-weight-bold text-uppercase\">SELLER: ");
            EndContext();
            BeginContext(3555, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab99affc42cc0173eb3cd0035ec1c0e3cd4ec4dd22767", async() => {
                BeginContext(3662, 16, false);
#line 73 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
                                                                                                                                                                             Write(Model.SellerName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sellerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
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
            BeginContext(3682, 150, true);
            WriteLiteral("</h4>\r\n\t\t\t\t\t<p class=\"vote\"><strong>91%</strong> of buyers enjoyed this product! <strong>(87 votes)</strong></p>\r\n\r\n\t\t\t\t\t<hr class=\"w-100\" />\r\n\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(3832, 1154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab99affc42cc0173eb3cd0035ec1c0e3cd4ec4dd26092", async() => {
                BeginContext(3923, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 79 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
                          
							var attributes = eCommerce.GetProductAttributes(Model.SellerId, Model.ProductTypeId);
							foreach (var attribute in attributes)
							{

#line default
#line hidden
                BeginContext(4085, 63, true);
                WriteLiteral("\t\t\t\t\t\t\t\t<h5 class=\"font-weight-bold text-uppercase\">\r\n\t\t\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(4149, 13, false);
#line 84 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
                               Write(attribute.Key);

#line default
#line hidden
                EndContext();
                BeginContext(4162, 3, true);
                WriteLiteral(":\r\n");
                EndContext();
#line 85 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
                                     foreach (var value in attribute.Value)
									{

#line default
#line hidden
                BeginContext(4227, 80, true);
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t<label class=\"radio-inline text-info\">\r\n\t\t\t\t\t\t\t\t\t\t\t<input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 4307, "\"", 4340, 3);
                WriteAttributeValue("", 4314, "attributes[", 4314, 11, true);
#line 88 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
WriteAttributeValue("", 4325, attribute.Key, 4325, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 4339, "]", 4339, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 4341, "\"", 4355, 1);
#line 88 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
WriteAttributeValue("", 4349, value, 4349, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4356, 4, true);
                WriteLiteral(" /> ");
                EndContext();
                BeginContext(4361, 5, false);
#line 88 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
                                                                                                               Write(value);

#line default
#line hidden
                EndContext();
                BeginContext(4366, 22, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</label>\r\n");
                EndContext();
#line 90 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
									}

#line default
#line hidden
                BeginContext(4400, 15, true);
                WriteLiteral("\t\t\t\t\t\t\t\t</h5>\r\n");
                EndContext();
#line 92 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
							}
						

#line default
#line hidden
                BeginContext(4434, 223, true);
                WriteLiteral("\t\t\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t\t\t<div class=\"form-group col-md-3\">\r\n\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"number\" name=\"quantity\" value=\"1\" />\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<input type=\"hidden\" name=\"sellerId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4657, "\"", 4680, 1);
#line 99 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
WriteAttributeValue("", 4665, Model.SellerId, 4665, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4681, 52, true);
                WriteLiteral(" />\r\n\t\t\t\t\t\t<input type=\"hidden\" name=\"productTypeId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4733, "\"", 4761, 1);
#line 100 "E:\My Stuffs\Công việc ở trường\Thương mại điện tử\e-commerce\ECommerce\ECommerce.UI.MVC\Views\Shared\Partials\ProductDetail.cshtml"
WriteAttributeValue("", 4741, Model.ProductTypeId, 4741, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4762, 217, true);
                WriteLiteral(" />\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<input class=\"btn btn-lg btn-success\" type=\"submit\" value=\"Add to Cart\" />\r\n\t\t\t\t\t\t\t<button class=\"btn btn-lg btn-danger\" type=\"button\"><i class=\"fa fa-heart\"></i></button>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4986, 42, true);
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>");
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
