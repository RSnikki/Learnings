#pragma checksum "C:\Users\HP\source\repos\NewRepo2\DemoProjectAsp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f430364e29c1b69bfb26cf2538cce3d2c2b1f0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f430364e29c1b69bfb26cf2538cce3d2c2b1f0e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DemoProjectAsp.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\source\repos\NewRepo2\DemoProjectAsp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Index</h2>\r\n");
#nullable restore
#line 7 "C:\Users\HP\source\repos\NewRepo2\DemoProjectAsp\Views\Home\Index.cshtml"
 foreach (var Item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div><span>");
#nullable restore
#line 9 "C:\Users\HP\source\repos\NewRepo2\DemoProjectAsp\Views\Home\Index.cshtml"
          Write(Item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n    <div><i>");
#nullable restore
#line 10 "C:\Users\HP\source\repos\NewRepo2\DemoProjectAsp\Views\Home\Index.cshtml"
       Write(Item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></div>\r\n    <div><b>");
#nullable restore
#line 11 "C:\Users\HP\source\repos\NewRepo2\DemoProjectAsp\Views\Home\Index.cshtml"
       Write(Item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n    <div><span>");
#nullable restore
#line 12 "C:\Users\HP\source\repos\NewRepo2\DemoProjectAsp\Views\Home\Index.cshtml"
          Write(Item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
            WriteLiteral("    <div><span>");
#nullable restore
#line 14 "C:\Users\HP\source\repos\NewRepo2\DemoProjectAsp\Views\Home\Index.cshtml"
          Write(Item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n    <div><span>");
#nullable restore
#line 15 "C:\Users\HP\source\repos\NewRepo2\DemoProjectAsp\Views\Home\Index.cshtml"
          Write(Item.PublishedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 16 "C:\Users\HP\source\repos\NewRepo2\DemoProjectAsp\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DemoProjectAsp.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
