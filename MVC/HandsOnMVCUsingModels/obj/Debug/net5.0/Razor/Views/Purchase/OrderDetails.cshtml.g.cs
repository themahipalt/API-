#pragma checksum "D:\Stackroute\Happiest-Minds\Batch-2\code-sharing\MVC\HandsOnMVCUsingModels\Views\Purchase\OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28fe7129c238774c6c4fdfc9b9ab8212ccd7923c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_OrderDetails), @"mvc.1.0.view", @"/Views/Purchase/OrderDetails.cshtml")]
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
#line 1 "D:\Stackroute\Happiest-Minds\Batch-2\code-sharing\MVC\HandsOnMVCUsingModels\Views\_ViewImports.cshtml"
using HandsOnMVCUsingModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Stackroute\Happiest-Minds\Batch-2\code-sharing\MVC\HandsOnMVCUsingModels\Views\_ViewImports.cshtml"
using HandsOnMVCUsingModels.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28fe7129c238774c6c4fdfc9b9ab8212ccd7923c", @"/Views/Purchase/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2737c80b8a82d20cc8617ce48adabf9015cddf35", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Purchase_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandsOnMVCUsingModels.ViewModel.ProductOrder>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Stackroute\Happiest-Minds\Batch-2\code-sharing\MVC\HandsOnMVCUsingModels\Views\Purchase\OrderDetails.cshtml"
  
    ViewData["Title"] = "OrderDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>OrderDetails</h1>\r\n    <pre>\r\nProductName:");
#nullable restore
#line 10 "D:\Stackroute\Happiest-Minds\Batch-2\code-sharing\MVC\HandsOnMVCUsingModels\Views\Purchase\OrderDetails.cshtml"
       Write(Model.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nPrice:");
#nullable restore
#line 11 "D:\Stackroute\Happiest-Minds\Batch-2\code-sharing\MVC\HandsOnMVCUsingModels\Views\Purchase\OrderDetails.cshtml"
 Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nQty:");
#nullable restore
#line 12 "D:\Stackroute\Happiest-Minds\Batch-2\code-sharing\MVC\HandsOnMVCUsingModels\Views\Purchase\OrderDetails.cshtml"
Write(Model.Order.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nOrderId:");
#nullable restore
#line 13 "D:\Stackroute\Happiest-Minds\Batch-2\code-sharing\MVC\HandsOnMVCUsingModels\Views\Purchase\OrderDetails.cshtml"
   Write(Model.Order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nOrderDate:");
#nullable restore
#line 14 "D:\Stackroute\Happiest-Minds\Batch-2\code-sharing\MVC\HandsOnMVCUsingModels\Views\Purchase\OrderDetails.cshtml"
     Write(Model.Order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nTotalAmount:");
#nullable restore
#line 15 "D:\Stackroute\Happiest-Minds\Batch-2\code-sharing\MVC\HandsOnMVCUsingModels\Views\Purchase\OrderDetails.cshtml"
       Write(Model.Order.OrderAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nDeliveryDate:");
#nullable restore
#line 16 "D:\Stackroute\Happiest-Minds\Batch-2\code-sharing\MVC\HandsOnMVCUsingModels\Views\Purchase\OrderDetails.cshtml"
        Write(Model.Order.DeliveryDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</pre>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandsOnMVCUsingModels.ViewModel.ProductOrder> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591