#pragma checksum "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83749760222b78bab9f2e50577258591ea124136"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_DisplayAndShopProduct), @"mvc.1.0.view", @"/Views/Product/DisplayAndShopProduct.cshtml")]
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
#nullable restore
#line 2 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
using PrintShop.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83749760222b78bab9f2e50577258591ea124136", @"/Views/Product/DisplayAndShopProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e08f9975a018d0ecead824321a4c999fbdceb666", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_DisplayAndShopProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #0b0b0b"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n");
#nullable restore
#line 8 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
  
    ViewBag.Title = "title";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83749760222b78bab9f2e50577258591ea1241365029", async() => {
                WriteLiteral("\n      \n        <meta charset=\"utf-8\">\n          <meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\">\n        \n          <title>Gp Bootstrap Template - Index</title>\n          <meta");
                BeginWriteAttribute("content", " content=\"", 424, "\"", 434, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"description\">\n          <meta");
                BeginWriteAttribute("content", " content=\"", 471, "\"", 481, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""keywords"">
        
          <!-- Favicons -->
          <link href=""../assets1/img/favicon.png"" rel=""icon"">
          <link href=""../assets1/img/apple-touch-icon.png"" rel=""apple-touch-icon"">
        
          <!-- Google Fonts -->
          <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Raleway:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i"" rel=""stylesheet"">
        
        <!-- Vendor CSS Files -->
        
          <link href=""../assets1/vendor/bootstrap/css/bootstrap-grid.min.css"" rel=""stylesheet"">
          <link href=""../assets1/vendor/icofont/icofont.min.css"" rel=""stylesheet"">
          <link href=""../assets1/vendor/boxicons/css/boxicons.min.css"" rel=""stylesheet"">
          <link href=""../assets1/vendor/owl.carousel/assets1/owl.carousel.min.css"" rel=""stylesheet"">
          <link href=""../assets1/vendor/venobox/venobox.css"" rel=""stylesheet"">
          <link href=""../assets1/vendor/remixicon/");
                WriteLiteral(@"remixicon.css"" rel=""stylesheet"">
          <link href=""../assets1/vendor/aos/aos.css"" rel=""stylesheet"">
        
          <!-- Template Main CSS File -->
          <link href=""../assets1/css/style.css"" rel=""stylesheet"">
        
        <!-- =======================================================
        * Template Name: Gp - v3.0.0
        * Template URL: https://bootstrapmade.com/gp-free-multipurpose-html-bootstrap-template/
        * Author: BootstrapMade.com
        * License: https://bootstrapmade.com/license/
        ======================================================== -->
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
            WriteLiteral("\n\n\t  \n\t        \n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83749760222b78bab9f2e50577258591ea1241368252", async() => {
                WriteLiteral("\n\n  <!-- ======= Header ======= -->\n  <header id=\"header\" class=\"fixed-top \">\n    <div class=\"container d-flex align-items-center justify-content-between\">\n\n      <h1 class=\"logo\"><a");
                BeginWriteAttribute("href", " href=\"", 2311, "\"", 2318, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""color: #0b0b0b"" >Backdoor shop<span>.</span></a></h1>
      <!-- Uncomment below if you prefer to use an image logo -->
      <!-- <a href=""index.html"" class=""logo""><img src=""""../assets1/img/logo.png"" alt="""" class=""img-fluid""></a>-->

      <nav class=""nav-menu d-none d-lg-block"">
        <ul>
          <li class=""active""><a href=""/"" style=""color: #0b0b0b; border: #0b0b0b"">Home</a></li>
          

        </ul>
      </nav><!-- .nav-menu -->
");
#nullable restore
#line 70 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
        if (SignInManager.IsSignedIn(User))
          {
              

#line default
#line hidden
#nullable disable
                WriteLiteral("                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83749760222b78bab9f2e50577258591ea1241369620", async() => {
                    WriteLiteral("Hello ");
#nullable restore
#line 73 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
                                                                                                   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("!");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 74 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
              
                 
              
          }
          else
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("              <a href=\"/Identity/Account/Login\" class=\"get-started-btn scrollto\">Log in</a>\n");
#nullable restore
#line 81 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
          }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"      

    </div>
  </header><!-- End Header -->


  <main id=""main"">
    
  <section id=""portfolio"" class=""portfolio"">
    <div class=""container"" data-aos=""fade-up"">

      <div class=""section-title"">
        <h2>Shop</h2>
        <p>Check our Stuff</p>
      </div>
        
      <div class=""row"" data-aos=""fade-up"" data-aos-delay=""100"">
        <div class=""col-lg-12 d-flex justify-content-center"">
          <ul id=""portfolio-flters"">
            <li data-filter=""*"" class=""filter-active"">All</li>
");
#nullable restore
#line 102 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
              
              var products = ViewData["products"] as List<Product>;
              var categories = ViewData["categories"]  as List<Category>;
              foreach (var category in categories)
              {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li data-filter=\".filter-app\">");
#nullable restore
#line 107 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
                                         Write(category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\n");
#nullable restore
#line 108 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
              }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("\n          </ul>\n        </div>\n      </div>\n      \n      <div class=\"row portfolio-container\" data-aos=\"fade-up\" data-aos-delay=\"200\">\n");
#nullable restore
#line 116 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
          
          foreach (var product in products)
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div");
                BeginWriteAttribute("class", " class=\"", 4208, "\"", 4310, 5);
                WriteAttributeValue("", 4216, "col-lg-4", 4216, 8, true);
                WriteAttributeValue(" ", 4224, "col-md-6", 4225, 9, true);
                WriteAttributeValue(" ", 4233, "portfolio-item", 4234, 15, true);
                WriteAttributeValue(" ", 4248, "filter-", 4249, 8, true);
#nullable restore
#line 119 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
WriteAttributeValue("", 4256, categories.Find(c => c.Id == product.CategoryId).Name, 4256, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n              <div class=\"portfolio-wrap\">\n                <img");
                BeginWriteAttribute("src", " src=", 4376, "", 4398, 1);
#nullable restore
#line 121 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
WriteAttributeValue("", 4381, product.ImageUrl, 4381, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\" style=\"height: auto; width: 100%\"  alt=\"Sth went wrong\">\n                <div class=\"portfolio-info\">\n                  <h4>");
#nullable restore
#line 123 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
                 Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n                  <p>");
#nullable restore
#line 124 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
                Write(product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" lei</p>\n                  <div class=\"portfolio-links\">\n                    <a");
                BeginWriteAttribute("href", " href=", 4674, "", 4697, 1);
#nullable restore
#line 126 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
WriteAttributeValue("", 4680, product.ImageUrl, 4680, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-gall=\"portfolioGallery\" class=\"venobox\" title=\"App 1\"><i class=\"bx bx-plus\"></i></a>\n                    ");
#nullable restore
#line 127 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
               Write(Html.ActionLink("Add To Cart", "AddToCart", null, new {id = @product.Id}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                    <a href=\"portfolio-details.html\" title=\"More Details\"><i class=\"bx bx-link\"></i></a>\n                  </div>\n                </div>\n              </div>\n            </div>\n");
#nullable restore
#line 134 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/DisplayAndShopProduct.cshtml"
      
      
          }
          

        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"      </div>
    </div>
    
  </section>
  </main>

 
 
  <!-- Vendor JS Files -->
  <script src=""../assets1/vendor/jquery/jquery.min.js""></script>
  <script src=""../assets1/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
  <script src=""../assets1/vendor/jquery.easing/jquery.easing.min.js""></script>
  <script src=""../assets1/vendor/php-email-form/validate.js""></script>
  <script src=""../assets1/vendor/owl.carousel/owl.carousel.min.js""></script>
  <script src=""../assets1/vendor/isotope-layout/isotope.pkgd.min.js""></script>
  <script src=""../assets1/vendor/venobox/venobox.min.js""></script>
  <script src=""../assets1/vendor/waypoints/jquery.waypoints.min.js""></script>
  <script src=""../assets1/vendor/counterup/counterup.min.js""></script>
  <script src=""../assets1/vendor/aos/aos.js""></script>

  <!-- Template Main JS File -->
  <script src=""../assets1/js/main.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591