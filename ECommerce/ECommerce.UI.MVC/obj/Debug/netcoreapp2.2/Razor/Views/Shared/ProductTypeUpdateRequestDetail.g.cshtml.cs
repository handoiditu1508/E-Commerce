#pragma checksum "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\Shared\ProductTypeUpdateRequestDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4a640f835ef625f26679bb032d86376f0b1b301"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductTypeUpdateRequestDetail), @"mvc.1.0.view", @"/Views/Shared/ProductTypeUpdateRequestDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ProductTypeUpdateRequestDetail.cshtml", typeof(AspNetCore.Views_Shared_ProductTypeUpdateRequestDetail))]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Application;

#line default
#line hidden
#line 2 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Application.Views;

#line default
#line hidden
#line 3 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Application.AddModels;

#line default
#line hidden
#line 4 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Application.UpdateModels;

#line default
#line hidden
#line 5 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Application.SearchModels;

#line default
#line hidden
#line 6 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.UI.MVC;

#line default
#line hidden
#line 7 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.UI.MVC.Models;

#line default
#line hidden
#line 8 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.UI.MVC.Infrastructure;

#line default
#line hidden
#line 9 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.UI.MVC.Models.ViewModels;

#line default
#line hidden
#line 10 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities;

#line default
#line hidden
#line 11 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities.Sellers;

#line default
#line hidden
#line 12 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using ECommerce.Models.Entities.ProductTypes;

#line default
#line hidden
#line 13 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Routing;

#line default
#line hidden
#line 14 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#line 15 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4a640f835ef625f26679bb032d86376f0b1b301", @"/Views/Shared/ProductTypeUpdateRequestDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"963f08a68e178133e60cd1071a0b7376ba1cbb51", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductTypeUpdateRequestDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductTypeUpdateRequestView>
    {
        private global::AspNetCore.Views_Shared_ProductTypeUpdateRequestDetail.__Generated__CategoryBreadCrumbViewComponentTagHelper __CategoryBreadCrumbViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 47, true);
            WriteLiteral("<h2><label>Product type name:</label></h2>\r\n<p>");
            EndContext();
            BeginContext(85, 10, false);
#line 3 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\Shared\ProductTypeUpdateRequestDetail.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(95, 54, true);
            WriteLiteral("</p>\r\n<h2><label>Product type category:</label></h2>\r\n");
            EndContext();
#line 5 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\Shared\ProductTypeUpdateRequestDetail.cshtml"
 if(!string.IsNullOrWhiteSpace(Model.CategoryId))
{

#line default
#line hidden
            BeginContext(203, 1, true);
            WriteLiteral("\t");
            EndContext();
            BeginContext(204, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:category-bread-crumb", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4a640f835ef625f26679bb032d86376f0b1b3016637", async() => {
            }
            );
            __CategoryBreadCrumbViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Shared_ProductTypeUpdateRequestDetail.__Generated__CategoryBreadCrumbViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__CategoryBreadCrumbViewComponentTagHelper);
#line 7 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\Shared\ProductTypeUpdateRequestDetail.cshtml"
__CategoryBreadCrumbViewComponentTagHelper.categoryId = int.Parse(Model.CategoryId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("category-id", __CategoryBreadCrumbViewComponentTagHelper.categoryId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(297, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\Shared\ProductTypeUpdateRequestDetail.cshtml"
}

#line default
#line hidden
            BeginContext(302, 45, true);
            WriteLiteral("<h2><label>Update description:</label></h2>\r\n");
            EndContext();
            BeginContext(347, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4a640f835ef625f26679bb032d86376f0b1b3018484", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 10 "C:\Users\hando\Desktop\ECommerce\ECommerce.UI.MVC\Views\Shared\ProductTypeUpdateRequestDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Descriptions);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductTypeUpdateRequestView> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:category-bread-crumb")]
        public class __Generated__CategoryBreadCrumbViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__CategoryBreadCrumbViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Int32 categoryId { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("CategoryBreadCrumb", new { categoryId });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
