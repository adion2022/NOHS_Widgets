#pragma checksum "C:\Users\Archie\Desktop\NOHS_Widgets-master\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5adabdfb89a88a067a2ba3215e85c8b24b4a22e6"
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
#nullable restore
#line 1 "C:\Users\Archie\Desktop\NOHS_Widgets-master\Views\_ViewImports.cshtml"
using Widgets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Archie\Desktop\NOHS_Widgets-master\Views\_ViewImports.cshtml"
using Widgets.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Archie\Desktop\NOHS_Widgets-master\Views\Home\Index.cshtml"
using Widgets.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5adabdfb89a88a067a2ba3215e85c8b24b4a22e6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfcca973e6cfd0ca20e6ac2e555e780926b19690", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Widget>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Archie\Desktop\NOHS_Widgets-master\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-1 col-md-3 col-lg-4\">          \r\n        </div>\r\n        <div class=\"col-xs-12 col-sm-10 col-md-6 col-lg-4\">         \r\n");
#nullable restore
#line 11 "C:\Users\Archie\Desktop\NOHS_Widgets-master\Views\Home\Index.cshtml"
              
                foreach(Widget item in @Model)
                {     

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row item-row\">\r\n                        <div class=\"item-center\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\'", 514, "\'", 537, 1);
#nullable restore
#line 16 "C:\Users\Archie\Desktop\NOHS_Widgets-master\Views\Home\Index.cshtml"
WriteAttributeValue("", 520, item.WidgetImage, 520, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded img-fluid img-max\"/>                           \r\n                        </div>\r\n                        <div class=\"item-center item-text\">    \r\n                            <span>Widget: ");
#nullable restore
#line 19 "C:\Users\Archie\Desktop\NOHS_Widgets-master\Views\Home\Index.cshtml"
                                     Write(item.WidgetName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"item-space\">Quantity: ");
#nullable restore
#line 19 "C:\Users\Archie\Desktop\NOHS_Widgets-master\Views\Home\Index.cshtml"
                                                                                               Write(item.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \r\n                        </div>                        \r\n                    </div>                    \r\n");
#nullable restore
#line 22 "C:\Users\Archie\Desktop\NOHS_Widgets-master\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-sm-1 col-md-3 col-lg-4\">           \r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Widget>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591