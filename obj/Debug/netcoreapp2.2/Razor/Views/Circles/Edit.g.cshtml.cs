#pragma checksum "/Users/Guest/Desktop/CIRCLES_MVC/Views/Circles/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b2d04da06ca0ad28996514f919b611a419a2b7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Circles_Edit), @"mvc.1.0.view", @"/Views/Circles/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Circles/Edit.cshtml", typeof(AspNetCore.Views_Circles_Edit))]
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
#line 1 "/Users/Guest/Desktop/CIRCLES_MVC/Views/_ViewImports.cshtml"
using Circles_MVC;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/CIRCLES_MVC/Views/_ViewImports.cshtml"
using Circles_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b2d04da06ca0ad28996514f919b611a419a2b7a", @"/Views/Circles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d864beb897ca847bc7b874ccfd52d6af1fe42f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Circles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Circles_MVC.Models.Circle>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/Guest/Desktop/CIRCLES_MVC/Views/Circles/Edit.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(62, 40, true);
            WriteLiteral("\n<h1>Update your User profile</h1>\n<hr>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/CIRCLES_MVC/Views/Circles/Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(130, 127, true);
            WriteLiteral("    <div class=\"form-group\">\n        <label for=\"Name\">Name</label>\n        <input name=\"Name\" type=\"text\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 257, "\"", 276, 1);
#line 12 "/Users/Guest/Desktop/CIRCLES_MVC/Views/Circles/Edit.cshtml"
WriteAttributeValue("", 265, Model.Name, 265, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(277, 22, true);
            WriteLiteral(" required>\n    </div>\n");
            EndContext();
            BeginContext(301, 80, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save Changes\" class=\"btn btn-primary\"/><br><br>\n");
            EndContext();
            BeginContext(386, 34, false);
#line 17 "/Users/Guest/Desktop/CIRCLES_MVC/Views/Circles/Edit.cshtml"
Write(Html.ActionLink("Cancel", "Index"));

#line default
#line hidden
            EndContext();
#line 17 "/Users/Guest/Desktop/CIRCLES_MVC/Views/Circles/Edit.cshtml"
                                       
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Circles_MVC.Models.Circle> Html { get; private set; }
    }
}
#pragma warning restore 1591
