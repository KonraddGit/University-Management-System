#pragma checksum "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1be62180c8691d625758228e6c8443aec8cb7a91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UniversityApp.Pages.ManagementPanel.Pages_ManagementPanel_Announcement), @"mvc.1.0.razor-page", @"/Pages/ManagementPanel/Announcement.cshtml")]
namespace UniversityApp.Pages.ManagementPanel
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
#line 1 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\_ViewImports.cshtml"
using UniversityApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\_ViewImports.cshtml"
using UniversityApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1be62180c8691d625758228e6c8443aec8cb7a91", @"/Pages/ManagementPanel/Announcement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebb27c1b36a7b5f5e7d5ad5d389d4d902e469568", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ManagementPanel_Announcement : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddAnnouncement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
  
    ViewData["Title"] = "Add Announcement";

    var isOfficeResult = await AuthorizationService
                        .AuthorizeAsync(User, "IsOffice");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table id=\"myTable\" class=\"styled-table\" style=\"width:100%\">\n    <thead>\n        <tr>\n            <th>");
#nullable restore
#line 15 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
           Write(localizer["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 16 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
           Write(localizer["Author"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 17 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
           Write(localizer["Description"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 18 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
           Write(localizer["Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 22 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
         foreach (var topic in Model.Announcements)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"active-row\">\n                <th>");
#nullable restore
#line 25 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
               Write(topic.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 26 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
               Write(topic.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 27 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
               Write(topic.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 28 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
               Write(topic.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            </tr>\n");
#nullable restore
#line 30 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n<div class=\"userslist-table-footer\">\n    <a id=\"details\" class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("title", " title=\"", 1057, "\"", 1086, 1);
#nullable restore
#line 35 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
WriteAttributeValue("", 1065, localizer["Details"], 1065, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <i class=\"fas fa-info-circle pixel40\"></i>\n    </a>\n\n");
#nullable restore
#line 39 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
     if (isOfficeResult.Succeeded)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1be62180c8691d625758228e6c8443aec8cb7a918887", async() => {
                WriteLiteral("\n            <i class=\"fas fa-newspaper pixel40\"></i>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
AddHtmlAttributeValue("", 1267, localizer["Add"], 1267, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <a id=\"delete\" class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("title", " title=\"", 1404, "\"", 1432, 1);
#nullable restore
#line 44 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
WriteAttributeValue("", 1412, localizer["Delete"], 1412, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <i class=\"fas fa-trash pixel40\"></i>\n        </a>\n");
#nullable restore
#line 47 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\Announcement.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<script type=""text/javascript"">

    $(document).ready(function () {
        $('#myTable').DataTable({
            responsive: true,
            ""pageLength"": 10
        });
    });

    $("".active-row"").click(function () {
        $(this).addClass('selected').siblings().removeClass('selected');
        var value = $(this).find('th:first').html();

        $(""#details"").attr(""href"", ""./DetailsAnnouncement/"" + value);
        $(""#delete"").attr(""href"", ""./DeleteAnnouncement/"" + value);
    });

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<Announcement> localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityApp.Pages.ManagementPanel.AnnouncementModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UniversityApp.Pages.ManagementPanel.AnnouncementModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UniversityApp.Pages.ManagementPanel.AnnouncementModel>)PageContext?.ViewData;
        public UniversityApp.Pages.ManagementPanel.AnnouncementModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591