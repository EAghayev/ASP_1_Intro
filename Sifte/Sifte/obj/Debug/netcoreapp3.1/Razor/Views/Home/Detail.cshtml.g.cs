#pragma checksum "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a1d8f41638232353acf50d8277b335dd3053b95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a1d8f41638232353acf50d8277b335dd3053b95", @"/Views/Home/Detail.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Home\Detail.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>This is a Detail page</h1>\r\n\r\n\r\n\r\n<h3>Id = ");
#nullable restore
#line 9 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Home\Detail.cshtml"
    Write(ViewData["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Id = ");
#nullable restore
#line 10 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Home\Detail.cshtml"
    Write(ViewBag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Id = ");
#nullable restore
#line 11 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\45. 14-12-2021\Sifte\Sifte\Views\Home\Detail.cshtml"
    Write(TempData["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n");
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
