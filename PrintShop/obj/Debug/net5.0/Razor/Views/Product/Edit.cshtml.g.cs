#pragma checksum "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a9ba6c79046f75bcf454058ca4cfd873c542295"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Edit), @"mvc.1.0.view", @"/Views/Product/Edit.cshtml")]
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
#line 1 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/_ViewImports.cshtml"
using PrintShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/_ViewImports.cshtml"
using PrintShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a9ba6c79046f75bcf454058ca4cfd873c542295", @"/Views/Product/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e08f9975a018d0ecead824321a4c999fbdceb666", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a9ba6c79046f75bcf454058ca4cfd873c5422953192", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta content=""width=device-width, initial-scale=1.0"" name=""viewport"">
   
          
          
    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Raleway:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i"" rel=""stylesheet"">
          
    <!-- Vendor CSS Files -->
    <link href=""/address/style.css"" rel=""stylesheet"">
          
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 21 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <p>Edit Products</p>
    
        <div class=""form"">
    
            <div class=""fields fields--2"">
                <label class=""field"">
                    <span class=""field__label"" for=""firstname"">Product Name</span>
                    ");
#nullable restore
#line 31 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
               Write(Html.TextBoxFor(x => x.Name, new { @class = "field__input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </label>\n        \n                <label class=\"field\">\n                    <span class=\"field__label\" for=\"firstname\">Product Price</span>\n                    ");
#nullable restore
#line 36 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
               Write(Html.TextBoxFor(x => x.Price, new {@class = "field__input"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </label>\n        \n                <label class=\"field\">\n                    <span class=\"field__label\" for=\"firstname\">Image Url</span>\n                    ");
#nullable restore
#line 41 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
               Write(Html.TextBoxFor(x => x.ImageUrl, new {@class = "field__input"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </label>\n        \n       \n            </div>\n      \n               \n        </div>\n     \n  \n        <hr>\n        <button class=\"button\">Add</button>\n    </div>\n");
#nullable restore
#line 54 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
