#pragma checksum "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e70b03bc19cfdc326f2c3b726dbe3858032e9ef5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fanfiction_ReadChapter), @"mvc.1.0.view", @"/Views/Fanfiction/ReadChapter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70b03bc19cfdc326f2c3b726dbe3858032e9ef5", @"/Views/Fanfiction/ReadChapter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e740631cdb9aec5700bce1d0a84cc2f67223b382", @"/Views/_ViewImports.cshtml")]
    public class Views_Fanfiction_ReadChapter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<fanfiction.Models.Fanfiction.ChapterRead>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("isLiked"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAccount.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<input hidden");
            BeginWriteAttribute("value", " value=\"", 125, "\"", 157, 1);
#nullable restore
#line 6 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
WriteAttributeValue("", 133, Model.chapter.ChapterId, 133, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Id\">\r\n<div style=\"margin: 20px auto;text-align: center; vertical-align: center\">\r\n    <table style=\"margin: 0 auto; padding: 0\">\r\n");
#nullable restore
#line 9 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
             if (Model.editStatus)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
           Write(Html.ActionLink(
                    string.Empty,
                    "AddChapter",
                    "Fanfiction",
                    new
                    {
                        fanficId = Model.chapter.FanficId,
                        chapterNumber = Model.chapter.ChapterNumber
                    },
                    new {@class = "bi bi-pen-fill"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                                                    
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
         if (Model.lang == "ru")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>\r\n                    <h6>\r\n                        ");
#nullable restore
#line 28 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                   Write(Html.ActionLink(
                            Model.fanfic.fandom.RuName,
                            "ReadFandom",
                            "Fanfiction",
                            new {fandomId = Model.fanfic.fandom.FandomId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h6></th>\r\n                <th>\r\n                    <h6>");
#nullable restore
#line 35 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                   Write(Html.ActionLink(
                            Model.fanfic.genre.RuName,
                            "ReadGenre",
                            "Fanfiction",
                            new {genreId = Model.fanfic.genre.GenreId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></th>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>\r\n                    <h6> ");
#nullable restore
#line 46 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                    Write(Html.ActionLink(
                             Model.fanfic.fandom.EnName,
                             "ReadFandom",
                             "Fanfiction",
                             new {fandomId = Model.fanfic.fandom.FandomId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></th>\r\n                <th>\r\n                    <h6>\r\n                        ");
#nullable restore
#line 53 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                   Write(Html.ActionLink(
                            Model.fanfic.genre.EnName,
                            "ReadGenre",
                            "Fanfiction",
                            new {genreId = Model.fanfic.genre.GenreId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h6></th>\r\n            </tr>\r\n");
#nullable restore
#line 60 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n        <th colspan=\"2\">\r\n            <h3>\r\n                ");
#nullable restore
#line 64 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
           Write(Html.ActionLink(
                    Model.fanfic.Name,
                    "ViewFanfic",
                    "Fanfiction",
                    new {fanficId = Model.fanfic.FanficId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n        </th>\r\n        <tr>\r\n            <th>\r\n                <h4 class=\"lang\" key=\"Chapter-number\"></h4></th>\r\n            <th>\r\n                <h4>");
#nullable restore
#line 75 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
               Write(Model.chapter.ChapterNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></th>\r\n        </tr>\r\n    </table>\r\n    <div class=\"border-dashed\" style=\"width: 60%; margin: auto\">\r\n        <h3 style=\"white-space: pre; padding: 0; margin: 0 auto\">");
#nullable restore
#line 79 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                                                            Write(Model.chapter.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div> \r\n<div style=\"text-align: center; width: 60%; margin: 0 auto;\">\r\n");
#nullable restore
#line 83 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
         if (Model.chapter.ChapterNumber != 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"mb-1 pb-1\" style=\"margin-right: 20%; display: inline-block; font-size: 1.5em\">\r\n                ");
#nullable restore
#line 86 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
           Write(Html.ActionLink("<<",
                    "ReadChapter",
                    "Fanfiction",
                    new {fanficId = Model.chapter.FanficId, chapterNumber = Model.chapter.ChapterNumber - 1},
                    new {@class = "fanfiction-button"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 92 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n");
#nullable restore
#line 94 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
         if (Model.isSignedIn)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a style=\"display: inline-block;\" class=\"mt-1\" onclick=\"change()\">\r\n");
#nullable restore
#line 97 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                 if (Model.isLiked)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p id=\"like\" class=\"red bi bi-heart-fill\"> ");
#nullable restore
#line 99 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                                                          Write(Model.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 100 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p id=\"like\" class=\"bi bi-heart-fill\"> ");
#nullable restore
#line 103 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                                                      Write(Model.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 104 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </a>\r\n");
#nullable restore
#line 106 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a style=\"display: inline-block;\" class=\"mt-1\">\r\n                <p id=\"like\" class=\"bi bi-heart-fill\"> ");
#nullable restore
#line 110 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                                                  Write(Model.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </a>\r\n");
#nullable restore
#line 112 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                \r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e70b03bc19cfdc326f2c3b726dbe3858032e9ef513579", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 115 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.isLiked);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                                                 WriteLiteral(Model.isLiked ? 1 : 0);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  \r\n        \r\n");
#nullable restore
#line 118 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
             if (!Model.isLast)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\" mb-1 pb-1\" style=\"margin-left:20%;  display: inline-block; font-size: 1.5em\">\r\n                    ");
#nullable restore
#line 121 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
               Write(Html.ActionLink(">>",
                        "ReadChapter",
                        "Fanfiction",
                        new {fanficId = Model.chapter.FanficId, chapterNumber = Model.chapter.ChapterNumber + 1},
                        new {@class = "fanfiction-button"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 127 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n<div  class=\"border-dashed\" style=\"width: 60%;  margin: 0 auto\">\r\n    <p");
            BeginWriteAttribute("style", " style=\"", 4765, "\"", 4827, 5);
            WriteAttributeValue("", 4773, "width:", 4773, 6, true);
#nullable restore
#line 131 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
WriteAttributeValue(" ", 4779, Model.chapter.ChapterId, 4780, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4804, ";", 4804, 1, true);
            WriteAttributeValue(" ", 4805, "white-space:", 4806, 13, true);
            WriteAttributeValue(" ", 4818, "pre-wrap", 4819, 9, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 131 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
                                                                 Write(Model.chapter.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
</div>

<script>
function change()
{
    
    document.getElementById('like').classList.toggle('red')
if(document.getElementById('isLiked').value === '0') 
{
	
	$('#isLiked').val(1)
  let val = (Number(document.getElementById(""like"").innerHTML) + 1);
  document.getElementById(""like"").innerHTML = ""  "" + val.toString();
  setLike(document.getElementById('Id').value)
}
else
{
    
	
	$('#isLiked').val(0)
  let val = (Number(document.getElementById(""like"").innerHTML) - 1);
   document.getElementById(""like"").innerHTML =""  "" + val.toString();
   deleteLike(document.getElementById('Id').value)
}

    
}

function setLike(chapterId)
{
      $.ajax({
             type: ""POST"",
             url: '");
#nullable restore
#line 164 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
              Write(Url.Action("SetLike", "Fanfiction"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
             data: { 'chapterId': chapterId} ,
             success: function (data) {
              
             },
             error: function (data) {

             }
         });   
}
function deleteLike(chapterId)
{
      $.ajax({
             type: ""POST"",
             url: '");
#nullable restore
#line 178 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Fanfiction\ReadChapter.cshtml"
              Write(Url.Action("DeleteLike", "Fanfiction"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
             data: { 'chapterId': chapterId} ,
             success: function (data) {
      
             },
             error: function (data) {
    
             }
         });   
}
    
</script>
<style>
    .red
    {
    color: red;
    }


</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fanfiction.Models.Fanfiction.ChapterRead> Html { get; private set; }
    }
}
#pragma warning restore 1591
