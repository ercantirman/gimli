#pragma checksum "C:\Users\ercan.tirman\source\repos\Gimli\Gimli\Views\Cloth\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "212d1543be881134c1c51ff0ee63e0aaa11f2d5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cloth_Index), @"mvc.1.0.view", @"/Views/Cloth/Index.cshtml")]
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
#line 1 "C:\Users\ercan.tirman\source\repos\Gimli\Gimli\Views\_ViewImports.cshtml"
using Gimli;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ercan.tirman\source\repos\Gimli\Gimli\Views\Cloth\Index.cshtml"
using Gimli.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"212d1543be881134c1c51ff0ee63e0aaa11f2d5a", @"/Views/Cloth/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c20054719412e5a441c86544d085221ca6bc4bf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cloth_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClothViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ercan.tirman\source\repos\Gimli\Gimli\Views\Cloth\Index.cshtml"
  
    ViewData["Title"] = "Clothes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">CLOTHES</h1>\r\n\r\n    <table>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Name</th>\r\n            <th>Type</th>\r\n        </tr>\r\n");
#nullable restore
#line 16 "C:\Users\ercan.tirman\source\repos\Gimli\Gimli\Views\Cloth\Index.cshtml"
         foreach (var cloth in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\ercan.tirman\source\repos\Gimli\Gimli\Views\Cloth\Index.cshtml"
               Write(cloth.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\ercan.tirman\source\repos\Gimli\Gimli\Views\Cloth\Index.cshtml"
               Write(cloth.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\ercan.tirman\source\repos\Gimli\Gimli\Views\Cloth\Index.cshtml"
               Write(cloth.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\ercan.tirman\source\repos\Gimli\Gimli\Views\Cloth\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClothViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
