#pragma checksum "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8974e4d24cab607ea9e0e2cb8fdd112cb47d574f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UniversityApp.Pages.ManagementPanel.Pages_ManagementPanel_AboutDepartment), @"mvc.1.0.razor-page", @"/Pages/ManagementPanel/AboutDepartment.cshtml")]
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
#line 2 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
using UniversityApp.Data.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8974e4d24cab607ea9e0e2cb8fdd112cb47d574f", @"/Pages/ManagementPanel/AboutDepartment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebb27c1b36a7b5f5e7d5ad5d389d4d902e469568", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ManagementPanel_AboutDepartment : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DepartmentList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./SignInForClass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Sign In For Class"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DeleteStudentFromClass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./CloseCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DeleteDepartment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 8 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
   var isOfficeResult = await AuthorizationService
                                                    .AuthorizeAsync(User, "IsOffice");

    var isStudentResult = await AuthorizationService
                        .AuthorizeAsync(User, "IsStudent");

    var available = Model.Department.SignInAvailable;

    var isStudentInClass = await departmentData.CheckIfStudentIsAdded(Model.Department.DepartmentId); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 18 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-sm\">\n    <tr>\n        <td style=\"font-size:30px\">");
#nullable restore
#line 22 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                              Write(Model.Department.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("    </tr>\n</table>");
#nullable restore
#line 27 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"userslist-table-footer\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8974e4d24cab607ea9e0e2cb8fdd112cb47d574f8803", async() => {
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
            WriteLiteral("\n");
#nullable restore
#line 33 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
     if (isStudentResult.Succeeded && Model.Department.SignInAvailable == true && isStudentInClass != true)
    {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8974e4d24cab607ea9e0e2cb8fdd112cb47d574f10391", async() => {
                WriteLiteral("\n    <i class=\"fas fa-sign-in-alt pixel40\"></i>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-departmentId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                                                                                                  WriteLiteral(Model.Department.DepartmentId);

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
            WriteLiteral("\n                <p>");
#nullable restore
#line 38 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
              Write(localizer["Sign in here"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>");
#nullable restore
#line 38 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                                                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
     if (isStudentInClass == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 41 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
Write(localizer["Congratulations! Wait for your activities"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 41 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
#nullable restore
#line 44 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
 if (isOfficeResult.Succeeded)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"rightSide\">\n    <div class=\"styled-table\">\n        <table>\n            <thead>\n                <tr>\n                    <td>");
#nullable restore
#line 51 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                   Write(localizer["Students"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 52 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                   Write(localizer["Options"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 56 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                 foreach (var student in Model.Students)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                        <td>");
#nullable restore
#line 59 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                       Write(student.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8974e4d24cab607ea9e0e2cb8fdd112cb47d574f15999", async() => {
                WriteLiteral("\n                                <i class=\"fas fa-trash\"></i>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                                                                                          WriteLiteral(student.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n                </tr>\n");
#nullable restore
#line 66 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n                <div class=\"userslist-table-footer\">\n");
#nullable restore
#line 72 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                     if (available == false)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8974e4d24cab607ea9e0e2cb8fdd112cb47d574f19097", async() => {
                WriteLiteral("\n        <i class=\"fas fa-folder-open pixel40\"></i>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 74 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
AddHtmlAttributeValue("", 2740, localizer["Open Signing In"], 2740, 29, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-departmentId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                                                                                                             WriteLiteral(Model.Department.DepartmentId);

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
            WriteLiteral(" ");
#nullable restore
#line 76 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
         }
else
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8974e4d24cab607ea9e0e2cb8fdd112cb47d574f22252", async() => {
                WriteLiteral("\n    <i class=\"fas fa-folder-minus pixel40\"></i>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 79 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
AddHtmlAttributeValue("", 2961, localizer["Close Signing In"], 2961, 30, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-departmentId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                                                                                                            WriteLiteral(Model.Department.DepartmentId);

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
#nullable restore
#line 81 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8974e4d24cab607ea9e0e2cb8fdd112cb47d574f25409", async() => {
                WriteLiteral("\n                        <i class=\"fas fa-trash pixel40\"></i>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 83 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
AddHtmlAttributeValue("", 3194, localizer["Delete Department"], 3194, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-departmentId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                                                                                                                                      WriteLiteral(Model.Department.DepartmentId);

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
            WriteLiteral("\n                </div>");
#nullable restore
#line 86 "C:\Users\kparchanski\repos\University-AdminPanel\UniversityApp\Pages\ManagementPanel\AboutDepartment.cshtml"
                      }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<AboutDepartmentModel> localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IDepartmentData departmentData { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityApp.Pages.ManagementPanel.AboutDepartmentModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UniversityApp.Pages.ManagementPanel.AboutDepartmentModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UniversityApp.Pages.ManagementPanel.AboutDepartmentModel>)PageContext?.ViewData;
        public UniversityApp.Pages.ManagementPanel.AboutDepartmentModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
