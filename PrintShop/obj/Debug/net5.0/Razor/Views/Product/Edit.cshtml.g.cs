#pragma checksum "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f817b8ea63631e4ec0514deb55735708844c6ffc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f817b8ea63631e4ec0514deb55735708844c6ffc", @"/Views/Product/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e08f9975a018d0ecead824321a4c999fbdceb666", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrintShop.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Edit product</h2>\n\n<br />\n\n");
#nullable restore
#line 12 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\n\n        ");
#nullable restore
#line 16 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
   Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 20 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
       Write(Html.LabelFor(x => x.Name, new {@class = "control-label col-md-3"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-9\">\n                ");
#nullable restore
#line 22 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
           Write(Html.TextBoxFor(x => x.Name, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 23 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.Name, "", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 28 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
       Write(Html.LabelFor(x => x.Price, new {@class = "control-label col-md-3"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-9\">\n                ");
#nullable restore
#line 30 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
           Write(Html.TextBoxFor(x => x.Price, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 31 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.Price, "", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 36 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
       Write(Html.LabelFor(x => x.ImageUrl, new {@class = "control-label col-md-3"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-9\">\n                ");
#nullable restore
#line 38 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
           Write(Html.TextBoxFor(x => x.ImageUrl, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 39 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.ImageUrl, "", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n\n\n        <div class=\"form-group\">\n            <div class=\"col-md-10 col-md-offset-2\">\n                <input type=\"submit\" value=\"Submit\" class=\"btn btn-primary\"/>\n            </div>\n        </div>\n\n    </div>\n");
#nullable restore
#line 52 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrintShop.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
