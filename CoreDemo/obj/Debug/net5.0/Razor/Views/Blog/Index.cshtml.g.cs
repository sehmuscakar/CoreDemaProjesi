#pragma checksum "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6bd0d49d1a48a2868e1c59b1301c0adeba96c2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
using EntityLayer.concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6bd0d49d1a48a2868e1c59b1301c0adeba96c2e", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/userlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Blog Posts</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 15 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 card\">\r\n                        <a href=\"single.html\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 635, "\"", 656, 1);
#nullable restore
#line 21 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 641, item.BlogImage, 641, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 688, "\"", 694, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                        <div class=""card-body"">
                            <ul class=""blog-icons my-4"">
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 27 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                                        Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </a>
                                </li>
                                <li class=""mx-2"">
                                    <a href=""#"">
                                        <i class=""far fa-comment""></i> 0
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        <i class=""fas fa-eye""></i> ");
#nullable restore
#line 38 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                              Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n\r\n                            </ul>\r\n                            <h5 class=\"card-title\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1787, "\"", 1825, 3);
            WriteAttributeValue("", 1794, "/Blog/BlogReadAll/", 1794, 18, true);
#nullable restore
#line 44 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1812, item.BlogID, 1812, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1824, "/", 1824, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                                     Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h5>\r\n                            <p class=\"card-text mb-3\">");
#nullable restore
#line 46 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                 Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p><!-- bu yapı kelimelrin arada kesilmesini önlemek için --> \r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2116, "\"", 2154, 3);
            WriteAttributeValue("", 2123, "/Blog/BlogReadAll/", 2123, 18, true);
#nullable restore
#line 47 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2141, item.BlogID, 2141, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2153, "/", 2153, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku </a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 50 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
