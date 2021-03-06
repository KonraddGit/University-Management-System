#pragma checksum "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8b723a5a129e047b2f1b64b2017958160360251"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UniversityApp.Pages.ManagementPanel.Pages_ManagementPanel_DepartmentList), @"mvc.1.0.razor-page", @"/Pages/ManagementPanel/DepartmentList.cshtml")]
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
#line 2 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
using UniversityApp.Data.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b723a5a129e047b2f1b64b2017958160360251", @"/Pages/ManagementPanel/DepartmentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebb27c1b36a7b5f5e7d5ad5d389d4d902e469568", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ManagementPanel_DepartmentList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AboutDepartment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddDepartment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 8 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
   var isOfficeResult = await AuthorizationService
                                                .AuthorizeAsync(User, "IsOffice");

    var isStudentResult = await AuthorizationService
                        .AuthorizeAsync(User, "IsStudent"); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"cards\">\n");
#nullable restore
#line 16 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
     foreach (var department in Model.Departments)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-single\">\n    <div>\n        <h1>");
#nullable restore
#line 20 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
       Write(department.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8b723a5a129e047b2f1b64b20179581603602516354", async() => {
                WriteLiteral("\n            <i style=\"color: black; padding: 3rem; font-size: 40px;\" class=\"fas fa-play\"> Informacja</i>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-departmentId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
                                                    WriteLiteral(department.DepartmentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["departmentId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-departmentId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["departmentId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 25 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
         if (department.SignInAvailable == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 27 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
Write(localizer["Zarejestruj si??"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h3> ");
#nullable restore
#line 27 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
                                        }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 30 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
   Write(localizer["Rejestracja zamkni??te"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h3>");
#nullable restore
#line 30 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <div>\n        <span class=\"fas fa-school\"></span>\n    </div>\n</div>");
#nullable restore
#line 34 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
#nullable restore
#line 37 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
 if (isOfficeResult.Succeeded)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"userslist-table-footer\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8b723a5a129e047b2f1b64b201795816036025110691", async() => {
                WriteLiteral("\n        <i class=\"fas fa-plus-square pixel40\"></i>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 40 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
AddHtmlAttributeValue("", 1290, localizer["Dodaj rocznik"], 1290, 27, false);

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
            WriteLiteral("\n</div>");
#nullable restore
#line 43 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\DepartmentList.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<DepartmentListModel> localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUsersData usersData { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityApp.Pages.ManagementPanel.DepartmentListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UniversityApp.Pages.ManagementPanel.DepartmentListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UniversityApp.Pages.ManagementPanel.DepartmentListModel>)PageContext?.ViewData;
        public UniversityApp.Pages.ManagementPanel.DepartmentListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
