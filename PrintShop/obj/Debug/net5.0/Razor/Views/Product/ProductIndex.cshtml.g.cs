#pragma checksum "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/ProductIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88c35a313e9650e267acaf30d80d63a4c77791cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductIndex), @"mvc.1.0.view", @"/Views/Product/ProductIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c35a313e9650e267acaf30d80d63a4c77791cb", @"/Views/Product/ProductIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e08f9975a018d0ecead824321a4c999fbdceb666", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/ProductIndex.cshtml"
  
    ViewBag.Title = "Index";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88c35a313e9650e267acaf30d80d63a4c77791cb3475", async() => {
                WriteLiteral(@"
<meta charset=""utf-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
<title>Bootstrap Table with Add and Delete Row Feature</title>
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto|Varela+Round|Open+Sans"">
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"">
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
<script src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
<style>
body {
    color: #404E67;
    background: #F5F7FA;
    font-family: 'Open Sans', sans-serif;
}

.btn {
background-color: black;
color:white;
}
.table-wrapper {
    width: 100%;
    margi");
                WriteLiteral(@"n: 30px auto;
    background: #fff;
    padding: 20px;	
    box-shadow: 0 1px 1px rgba(0,0,0,.05);
}
.table-title {
    padding-bottom: 10px;
    margin: 0 0 10px;
}
.table-title h2 {
    margin: 6px 0 0;
    font-size: 22px;
}
li {
    border-radius: 3px;
    padding: 25px 30px;
    display: flex;
    justify-content: space-between;
    margin-bottom: 25px;
  }

  .col-1 {
    flex-basis: 10%;
  }
  .col-2 {
    flex-basis: 40%;
  }
  .col-3 {
    flex-basis: 25%;
  }
  .col-4 {
    flex-basis: 25%;
  }

.table-title .add-new {
    float: right;
    height: 30px;
    font-weight: bold;
    font-size: 12px;
    text-shadow: none;
    min-width: 100px;
    border-radius: 50px;
    line-height: 13px;
}
.table-title .add-new i {
    margin-right: 4px;
}
table.table {
    table-layout: fixed;
}
table.table tr th, table.table tr td {
    border-color: #e9e9e9;
}
table.table th i {
    font-size: 13px;
    margin: 0 5px;
    cursor: pointer;
}
table.table th:last-child {
    width: 100px;
}
table.table td a {
    c");
                WriteLiteral(@"ursor: pointer;
    display: inline-block;
    margin: 0 5px;
    min-width: 24px;
}    
table.table td a.add {
    color: #27C46B;
}
table.table td a.edit {
    color: #FFC107;
}
table.table td a.delete {
    color: #E34724;
}
table.table td i {
    font-size: 19px;
}
table.table td a.add i {
    font-size: 24px;
    margin-right: -1px;
    position: relative;
    top: 3px;
}    
table.table .form-control {
    height: 32px;
    line-height: 32px;
    box-shadow: none;
    border-radius: 2px;
}
table.table .form-control.error {
    border-color: #f50000;
}
table.table td .add {
    display: none;
}


</style>
<script>
$(document).ready(function(){
	$('[data-toggle=""tooltip""]').tooltip();
	var actions = $(""table td:last-child"").html();
	// Append table with add row form on add new button click
    $("".add-new"").click(function(){
		$(this).attr(""disabled"", ""disabled"");
		var index = $(""table tbody tr:last-child"").index();
        var row = '<tr>' +
            '<td><input type=""text"" class=""form-control"" name=");
                WriteLiteral(@"""name"" id=""name""></td>' +
            '<td><input type=""text"" class=""form-control"" name=""department"" id=""department""></td>' +
            '<td><input type=""text"" class=""form-control"" name=""phone"" id=""phone""></td>' +
			'<td>' + actions + '</td>' +
        '</tr>';
    	$(""table"").append(row);		
		$(""table tbody tr"").eq(index + 1).find("".add, .edit"").toggle();
        $('[data-toggle=""tooltip""]').tooltip();
    });
	// Add row on add button click
	$(document).on(""click"", "".add"", function(){
		var empty = false;
		var input = $(this).parents(""tr"").find('input[type=""text""]');
        input.each(function(){
			if(!$(this).val()){
				$(this).addClass(""error"");
				empty = true;
			} else{
                $(this).removeClass(""error"");
            }
		});
		$(this).parents(""tr"").find("".error"").first().focus();
		if(!empty){
			input.each(function(){
				$(this).parent(""td"").html($(this).val());
			});			
			$(this).parents(""tr"").find("".add, .edit"").toggle();
			$("".add-new"").removeAttr(""disabled"");
		}		
    });
	/");
                WriteLiteral(@"/ Edit row on edit button click
	$(document).on(""click"", "".edit"", function(){		
        $(this).parents(""tr"").find(""td:not(:last-child)"").each(function(){
			$(this).html('<input type=""text"" class=""form-control"" value=""' + $(this).text() + '"">');
		});		
		$(this).parents(""tr"").find("".add, .edit"").toggle();
		$("".add-new"").attr(""disabled"", ""disabled"");
    });
	// Delete row on delete button click
	$(document).on(""click"", "".delete"", function(){
        $(this).parents(""tr"").remove();
		$("".add-new"").removeAttr(""disabled"");
    });
});
</script>
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88c35a313e9650e267acaf30d80d63a4c77791cb9341", async() => {
                WriteLiteral(@"
<div class=""container-lg"">
    <div class=""table-responsive"">
        <div class=""table-wrapper"">
            <div class=""table-title"">
                <div class=""row"">
                    <div class=""col-sm-8""><h2>Products <b>Details</b></h2></div>
                    <div class=""col-sm-6"">
                        <button  onclick=""location.href='/sefu/categories'"" type=""button"" class=""btn btn-info add-new""><i class=""fa fa-plus""></i> Go To Categories</button>
                    </div>
                    
                    <div class=""col-sm-4"">
                                            <button  onclick=""location.href='/product/new'"" type=""button"" class=""btn btn-info add-new""><i class=""fa fa-plus""></i> Add Product</button>
                                        </div>
                </div>
            </div>
            <table class=""table table-bordered"">
                <thead>
                <tr>
                    <th class=""col-1"">Id</th>
                    <th class=""col-2"">Name</th>
      ");
                WriteLiteral("              <th class=\"col-3\">Description</th>\n                    <th class=\"col-4\">Image Url</th>\n                    <th class=\"col-5\">Actions</th>\n                </tr>\n                </thead>\n                <tbody>\n");
#nullable restore
#line 216 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/ProductIndex.cshtml"
                  
                    var productsList = ViewData["products"] as List<Product>;

                    foreach (var product in productsList)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\n                            <td class=\"col-1\">");
#nullable restore
#line 222 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/ProductIndex.cshtml"
                                         Write(product.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td class=\"col-2\">");
#nullable restore
#line 223 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/ProductIndex.cshtml"
                                         Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td class=\"col-3\">");
#nullable restore
#line 224 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/ProductIndex.cshtml"
                                         Write(product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td class=\"col-4\">");
#nullable restore
#line 225 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/ProductIndex.cshtml"
                                         Write(product.ImageUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                            <td class=""col-5"">
                                <a class=""add"" title=""Add"" data-toggle=""tooltip"" href=""/product/new""><i class=""material-icons"">&#xE03B;</i></a>
                                <a class=""edit"" title=""Edit"" data-toggle=""tooltip""");
                BeginWriteAttribute("href", " href=\"", 6761, "\"", 6793, 2);
                WriteAttributeValue("", 6768, "/product/edit/", 6768, 14, true);
#nullable restore
#line 228 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/ProductIndex.cshtml"
WriteAttributeValue("", 6782, product.Id, 6782, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"material-icons\">&#xE254;</i></a>\n                                <a class=\"delete\" title=\"Delete\" data-toggle=\"tooltip\"><i class=\"material-icons\"");
                BeginWriteAttribute("href", " href=\"", 6950, "\"", 6984, 2);
                WriteAttributeValue("", 6957, "/product/delete/", 6957, 16, true);
#nullable restore
#line 229 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/ProductIndex.cshtml"
WriteAttributeValue("", 6973, product.Id, 6973, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">&#xE872;</i></a>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 232 "/Users/malinaoanea/RiderProjects/PrintShop/PrintShop/Views/Product/ProductIndex.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tbody>\n            </table>\n        </div>\n    </div>\n</div>     \n");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
