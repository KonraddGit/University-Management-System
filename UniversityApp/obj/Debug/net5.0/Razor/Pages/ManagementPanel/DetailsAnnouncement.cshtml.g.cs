#pragma checksum "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DetailsAnnouncement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15e922a691c20e7cab02a2a747ddd60935b90a78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UniversityApp.Pages.ManagementPanel.Pages_ManagementPanel_DetailsAnnouncement), @"mvc.1.0.razor-page", @"/Pages/ManagementPanel/DetailsAnnouncement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{topic}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15e922a691c20e7cab02a2a747ddd60935b90a78", @"/Pages/ManagementPanel/DetailsAnnouncement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebb27c1b36a7b5f5e7d5ad5d389d4d902e469568", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ManagementPanel_DetailsAnnouncement : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Announcement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
#nullable restore
#line 7 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DetailsAnnouncement.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-sm\">\n    <tr>\n        <td>");
#nullable restore
#line 11 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DetailsAnnouncement.cshtml"
       Write(localizer["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 11 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DetailsAnnouncement.cshtml"
                            Write(Model.Announcement.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>");
#nullable restore
#line 14 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DetailsAnnouncement.cshtml"
       Write(localizer["Author"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 14 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DetailsAnnouncement.cshtml"
                             Write(Model.Announcement.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n    <tr>\n        <td>");
#nullable restore
#line 16 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DetailsAnnouncement.cshtml"
       Write(localizer["Description"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 16 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DetailsAnnouncement.cshtml"
                                  Write(Model.Announcement.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n    <tr>\n        <td>");
#nullable restore
#line 18 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DetailsAnnouncement.cshtml"
       Write(localizer["Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 18 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DetailsAnnouncement.cshtml"
                           Write(Model.Announcement.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n</table>");
#nullable restore
#line 19 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DetailsAnnouncement.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"userslist-table-footer\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15e922a691c20e7cab02a2a747ddd60935b90a787591", async() => {
                WriteLiteral("\n        <i class=\"fas fa-backward pixel40\"></i>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<DetailsModel> localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsAnnouncementModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsAnnouncementModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsAnnouncementModel>)PageContext?.ViewData;
        public DetailsAnnouncementModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
