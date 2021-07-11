#pragma checksum "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffb9d65b01eb56c2636d7228ecda51fa6302c7d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fanfiction_ReadGenre), @"mvc.1.0.view", @"/Views/Fanfiction/ReadGenre.cshtml")]
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
#line 1 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\_ViewImports.cshtml"
using fanfiction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\_ViewImports.cshtml"
using fanfiction.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffb9d65b01eb56c2636d7228ecda51fa6302c7d8", @"/Views/Fanfiction/ReadGenre.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e740631cdb9aec5700bce1d0a84cc2f67223b382", @"/Views/_ViewImports.cshtml")]
    public class Views_Fanfiction_ReadGenre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<fanfiction.Models.Fanfiction.GenreModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"
  
    Layout = "~/Views/Shared/_LayoutFanfiction.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div style=\"width: 80%; text-align: center; vertical-align: center\">\r\n");
#nullable restore
#line 7 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"
     if (Model.IsSignedIn)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"
   Write(Html.ActionLink(
            string.Empty,
            "AddGenre",
            "Fanfiction",
            new {genreId = Model.genre.GenreId},
            new {@class = "bi bi-pen-fill"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"
                                            
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"lang\" key=\"Genre\"></h4>\r\n    <h4 class=\"lang mt-2\" key=\"Category-Name\"></h4>\r\n    <div class=\"border-dashed\" style=\"width: 100%; margin: 0 auto\">\r\n");
#nullable restore
#line 19 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"
         if (Model.lang == "ru")
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 style=\"white-space: pre; padding: 0; margin: 0 auto\">");
#nullable restore
#line 22 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"
                                                                Write(Model.genre.RuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 23 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"

        }
        else
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 style=\"white-space: pre; padding: 0; margin: 0 auto\">");
#nullable restore
#line 28 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"
                                                                Write(Model.genre.EnName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 29 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <h4 class=\"lang mt-2\" key=\"Description\"></h4>\r\n    <div class=\"border-dashed\" style=\"text-align: left; width: 100%;  margin: 0 auto\">\r\n");
#nullable restore
#line 34 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"
         if (Model.lang == "ru")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"white-space: pre-wrap\">");
#nullable restore
#line 36 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"
                                        Write(Model.genre.RuDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 37 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"white-space: pre-wrap\">");
#nullable restore
#line 40 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"
                                        Write(Model.genre.EnDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 41 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadGenre.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n    \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fanfiction.Models.Fanfiction.GenreModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
