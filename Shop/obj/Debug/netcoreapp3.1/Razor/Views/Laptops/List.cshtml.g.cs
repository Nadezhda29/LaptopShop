#pragma checksum "E:\МОЁ\ASP.NET\Shop\Shop\Views\Laptops\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "946eddb2b5a00aac16e39c3b58ba94fd5c787d5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Laptops_List), @"mvc.1.0.view", @"/Views/Laptops/List.cshtml")]
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
#line 1 "E:\МОЁ\ASP.NET\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\МОЁ\ASP.NET\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"946eddb2b5a00aac16e39c3b58ba94fd5c787d5f", @"/Views/Laptops/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67d845e5371e4c720b943bf40f713afc7b23e1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Laptops_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Все ноутбуки</h1>\r\n<h3>");
#nullable restore
#line 2 "E:\МОЁ\ASP.NET\Shop\Shop\Views\Laptops\List.cshtml"
Write(Model.CurrCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 4 "E:\МОЁ\ASP.NET\Shop\Shop\Views\Laptops\List.cshtml"
      
        foreach (Laptop laptop in Model.AllLaptops)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\МОЁ\ASP.NET\Shop\Shop\Views\Laptops\List.cshtml"
       Write(Html.Partial("AllLaptops", laptop));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\МОЁ\ASP.NET\Shop\Shop\Views\Laptops\List.cshtml"
                                               
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
