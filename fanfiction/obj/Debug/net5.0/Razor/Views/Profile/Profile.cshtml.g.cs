#pragma checksum "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "667aacb9305917095dfcbf1c25a3f1bcdae3cd5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Profile), @"mvc.1.0.view", @"/Views/Profile/Profile.cshtml")]
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
#nullable restore
#line 7 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
using fanfiction.Models.User;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"667aacb9305917095dfcbf1c25a3f1bcdae3cd5e", @"/Views/Profile/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e740631cdb9aec5700bce1d0a84cc2f67223b382", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dragndrop.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editable-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("drag-n-drop-avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Ajax/UploadImages"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return submitFilesForm(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/dragndrop.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/clickToEdit.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAccount.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n\n\n");
            WriteLiteral("\n<link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "667aacb9305917095dfcbf1c25a3f1bcdae3cd5e8328", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC\" crossorigin=\"anonymous\">\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "667aacb9305917095dfcbf1c25a3f1bcdae3cd5e9663", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    \n\n\n<div class=\"area\">\n\n    <div class=\"profile-area m-3\">\n        <div id=\"avatar-area\" style=\"display: inline-block; text-align: center\">\n");
#nullable restore
#line 21 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
             if (Model.AvatarUrl == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img class=\"avatar\" style=\"display: inline-block; \" src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Anonymous_emblem.svg/1200px-Anonymous_emblem.svg.png\" alt=\"avatar\"/>\n");
#nullable restore
#line 24 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img class=\"avatar\" style=\"display: inline-block; \"");
            BeginWriteAttribute("src", " src=\"", 1105, "\"", 1127, 1);
#nullable restore
#line 27 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 1111, Model.AvatarUrl, 1111, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"avatar\"/>\n");
#nullable restore
#line 28 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <br>
            <button onclick=""showArea()"" id=""edit-photo"" key=""Upload"" class=""mt-3 p-1 bi bi-capslock lang""></button>

        </div>



        <div class=""ml-3 p-0"" style=""display: inline-block; width: 70% ; vertical-align: top "">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "667aacb9305917095dfcbf1c25a3f1bcdae3cd5e12574", async() => {
                WriteLiteral(@"
                <table class=""profile-table"" id=""profile-data-area"" style=""width: 100%"">
                    <tr class=""p-0 m-0""><td class=""lang"" key=""Name""></td>
                        <td>



                            <p class=""m-0 p-0"" style=""border-width: 0; display: inline-block"" href=""#"" id=""username"" data-type=""text"" data-placeholder=""Required"" data-placement=""right"" data-title=""Enter username"">");
#nullable restore
#line 44 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
                                                                                                                                                                                                                Write(Model.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

                        </td></tr>
                    <tr class=""p-1""><td class=""lang"" key=""Email""></td>
                        <td>

                            <p class=""m-0 p-0"" style=""border-width: 0; display: inline-block"" href=""#"" id=""Email"" data-type=""text"" data-placeholder=""Required"" data-placement=""right"" data-title=""Enter email"">");
#nullable restore
#line 50 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
                                                                                                                                                                                                          Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n\n\n                        </td></tr>\n                </table>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "667aacb9305917095dfcbf1c25a3f1bcdae3cd5e15634", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "667aacb9305917095dfcbf1c25a3f1bcdae3cd5e16759", async() => {
                WriteLiteral("\n                ");
#nullable restore
#line 58 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@" <!-- Prevent Cross Site Request Forgery -->
                <input type=""file"" name=""files"" id=""files-field"" accept=""image/*"" onchange=""submitFilesForm(this.form);"" multiple/>
                <label style=""width: 100%; height: 100px; vertical-align: bottom"" for=""files-field"" id=""files-label""
                       ondragover=""stopDefault(event);dragOver(this,  getDropData());""
                       ondragenter=""stopDefault(event);dragOver(this, getDropData());""
                       ondragleave=""stopDefault(event);dragLeave(this);""
                       ondrop=""stopDefault(event);dragLeave(this);addFilesAndSubmit(event);""
                       class=""lang"" key=""Drag-n-drop""></label>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <div style=\"text-align: left;\"><div id=\"files-progress\"></div></div>\n            <div class=\"modal-page\" id=\"uploaded-files\"></div>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "667aacb9305917095dfcbf1c25a3f1bcdae3cd5e19678", async() => {
                WriteLiteral("\n");
#nullable restore
#line 70 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
             if (TempData["edit-error"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"mt-3 alert alert-danger alert-dismissible\" style=\"width: 100%\">\n                    <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\n                    ");
#nullable restore
#line 74 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
               Write(TempData["edit-error"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>");
#nullable restore
#line 75 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
                      }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 78 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
        if (@Model.UserFanfiction != null)
       {
       

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
        foreach (var it in Model.UserFanfiction)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <div> ");
#nullable restore
#line 82 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
            Write(it.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\n");
#nullable restore
#line 83 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
        
       }
       else
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <p>Список фанфиков пуст</p>\n");
#nullable restore
#line 88 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table_col mt-5"" style=""margin: auto; width: 90%;"">
                <thead style=""text-align: center"">
                 <td colspan=""4""><h2>Список фанфиков</h2></td>
                </thead>
                <tr>
                    <th>Название</th>
                    <th>Фандом</th>
                    <th>Жанр</th>
                    <th>Количество глав</th>
                </tr>
                <tr>
                    <td>Scary Movie</td>
                    <td>Indiana Jones</td>
                    <td>The Punisher</td>
                    <td>Wall-E</td>
                </tr>
               
            </table>
        
    </div>
    
   
    
</div>













");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "667aacb9305917095dfcbf1c25a3f1bcdae3cd5e23720", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "667aacb9305917095dfcbf1c25a3f1bcdae3cd5e24759", async() => {
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
function  getDropData()
{
    if (localStorage.key('lang') === ""en"") return langArr.en.Drop
    else  if (localStorage.key('lang') === ""ru"") return langArr.ru.Drop
    else return langArr.ru.Drop
    }
(function($) {

    $(function() {
        if ($('#editable-form').length) {
            $.fn.editable.defaults.mode = 'inline';

            $.fn.editableform.buttons =
                '<button type=""submit""  class=""btn edit-btn btn-sm editable-submit"">' +
                '<i class=""fa fa-fw fa-check""></i>' + '</button>' +
                '<button type=""button"" class=""edit-btn btn  btn-sm editable-cancel"">' +
                '<i class=""fa fa-fw fa-times""></i>' + '</button>';



            $('#username').editable({
                validate: function(value) {

                    if ($.trim(value) === '')
                    {
                        
                        return ' ';
                    }
                    else
                    {
                        UpdateName($.trim(value");
            WriteLiteral(@"))
                       
                    }
                }
            });
 $('#Email').editable({
                validate: function(value) {
                   
                    if ($.trim(value) === '')
                    {
                           
                        return ' ';
                    }
                    else
                    {
                        
                        UpdateEmail($.trim(value))
                       
                    }
                }
            });

        }
    });
})(jQuery);






function UpdateName(value) {
     
    $.ajax({
        type: ""POST"",
        url: '");
#nullable restore
#line 195 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
         Write(Url.Action("UpdateName", "Profile"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
        data: { 'newName': value,
         'lang': localStorage.getItem(""lang"")} ,
        success: function (data) {

            window.location.reload()
        },
        error: function (data) {

          window.location.reload()
        }
    });

}
function UpdateEmail(value) {
    
    $.ajax({
        type: ""POST"",
        url: '");
#nullable restore
#line 213 "C:\Users\User\RiderProjects\fanfiction\fanfiction\Views\Profile\Profile.cshtml"
         Write(Url.Action("UpdateEmail", "Profile"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
        data: { 'email': value,
        'lang': localStorage.getItem(""lang"")
        },
        success: function (data) {

            window.location.reload()
        },
        error: function (data) {

            window.location.reload()
        }
    });

}

</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
