#pragma checksum "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "152f00005aee85681bf245e99e71264c289dd34f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_New), @"mvc.1.0.view", @"/Views/Product/New.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"152f00005aee85681bf245e99e71264c289dd34f", @"/Views/Product/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e08f9975a018d0ecead824321a4c999fbdceb666", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Add product</h2>\n\n<br />\n\n");
#nullable restore
#line 11 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 16 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
       Write(Html.LabelFor(x => x.Name, new {@class = "control-label col-md-3"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-9\">\n                ");
#nullable restore
#line 18 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
           Write(Html.TextBoxFor(x => x.Name, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 19 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
           Write(Html.ValidationMessageFor(x => x.Name, "", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 24 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
       Write(Html.LabelFor(x => x.Price, new {@class = "control-label col-md-3"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-9\">\n                ");
#nullable restore
#line 26 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
           Write(Html.TextBoxFor(x => x.Price, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 27 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
           Write(Html.ValidationMessageFor(x => x.Price, "", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 32 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
       Write(Html.LabelFor(x => x.ImageUrl, new {@class = "control-label col-md-3"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-9\">\n                ");
#nullable restore
#line 34 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
           Write(Html.TextBoxFor(x => x.ImageUrl, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 35 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
           Write(Html.ValidationMessageFor(x => x.ImageUrl, "", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 40 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
       Write(Html.LabelFor(x => x.Category, new {@class = "control-label col-md-3"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-9\">\n                ");
#nullable restore
#line 42 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
           Write(Html.DropDownListFor(x=>x.CategoryId, (SelectList) ViewBag.Categories,"Selecteaza Catgegorie", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 43 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
           Write(Html.ValidationMessageFor(x => x.CategoryId, "", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            <div class=\"col-md-10 col-md-offset-2\">\n                <input type=\"submit\" value=\"Add\" class=\"btn btn-primary\"/>\n            </div>\n        </div>\n\n\n    </div>\n");
#nullable restore
#line 55 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/New.cshtml"
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
