#pragma checksum "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63f01e4a7b71ee2742ba287d3c9f59661ffadfcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
#line 1 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63f01e4a7b71ee2742ba287d3c9f59661ffadfcd", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopDBContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/List.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img detailimage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63f01e4a7b71ee2742ba287d3c9f59661ffadfcd4585", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<div class=\"shopping-cart\">\r\n    <div class=\"title\">\r\n        <h1>Order Confirmation</h1>\r\n        <h5><a href=\"/Home/Shop\">Back to Shop</a></h5>\r\n    </div>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
      
        List<UserItems> cart = new List<UserItems>();
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 24 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
     foreach (UserItems userItem in Model.UserItems)
    {
        if (Convert.ToInt32(Context.Session.GetString("Id")) == userItem.UserId)
        {
            cart.Add(userItem);
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
     foreach (UserItems item in cart)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
         foreach (Items boughtItem in Model.Items)
        {
            if (item.ItemId == boughtItem.Id)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"item\">\r\n    <div class=\"buttons\">\r\n        <span class=\"delete-btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 900, "\"", 986, 4);
            WriteAttributeValue("", 910, "location.href=", 910, 14, true);
            WriteAttributeValue(" ", 924, "\'", 925, 2, true);
#nullable restore
#line 41 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
WriteAttributeValue("", 926, Url.Action("Delete", "Home", new { id = item.UserItemId }), 926, 59, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 985, "\'", 985, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-times\" aria-hidden=\"true\"></i></span>\r\n        <!-- <span class=\"delete-btn\" onclick=\"location.href= \'");
#nullable restore
#line 42 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
                                                          Write(Url.Action("Delete", "Home", new { id = item.UserItemId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\"></span>\r\n        <span class=\"like-btn\"></span>-->\r\n    </div>\r\n    <div class=\"image\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63f01e4a7b71ee2742ba287d3c9f59661ffadfcd8378", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1304, "~/Images/", 1304, 9, true);
#nullable restore
#line 46 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
AddHtmlAttributeValue("", 1313, boughtItem.ImageUrl, 1313, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 1333, ".jpg", 1334, 5, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"description\">\r\n            <span>");
#nullable restore
#line 50 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
             Write(boughtItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"quantity\">\r\n            <span>");
#nullable restore
#line 53 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
             Write(boughtItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</span>\r\n        </div>\r\n\r\n        <!-- <td>");
#nullable restore
#line 56 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
            Write(boughtItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>-->\r\n        <div class=\"total-price\">\r\n            <span>$");
#nullable restore
#line 58 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
              Write(Math.Round(boughtItem.Price, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n\r\n        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1725, "\"", 1810, 4);
            WriteAttributeValue("", 1735, "location.href=", 1735, 14, true);
            WriteAttributeValue(" ", 1749, "\'", 1750, 2, true);
#nullable restore
#line 61 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
WriteAttributeValue("", 1751, Url.Action("Details", "Home", new { id = boughtItem.Id }), 1751, 58, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1809, "\'", 1809, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Item Details</button>\r\n\r\n        <!-- Product #1 -->\r\n        <!-- <td><button onclick=\"location.href= \'");
#nullable restore
#line 64 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
                                             Write(Url.Action("Delete", "Home", new { id = item.UserItemId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\">Delete</button></td>-->\r\n\r\n    </div>\r\n");
#nullable restore
#line 67 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
    }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\ilona\source\repos\MVC\CoffeeShop\CoffeeShop\Views\Home\List.cshtml"
     
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n   \r\n\r\n    <script src=\"https://kit.fontawesome.com/2a6d697381.js\" crossorigin=\"anonymous\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopDBContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
