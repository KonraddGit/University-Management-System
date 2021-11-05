using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Encodings.Web;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace UniversityApp.Data.Helpers
{
    public static class PageExtensions
    {
        public static string WebPage { get; set; }
        public static async Task<string> RenderViewAsync(this PageModel pageModel, string pageName)
        {
            var actionContext = new ActionContext(
                pageModel.HttpContext,
                pageModel.RouteData,
                pageModel.PageContext.ActionDescriptor
            );

            using (var sw = new StringWriter())
            {
                IRazorViewEngine _razorViewEngine = pageModel.HttpContext.RequestServices.GetService(typeof(IRazorViewEngine)) as IRazorViewEngine;
                IRazorPageActivator _activator = pageModel.HttpContext.RequestServices.GetService(typeof(IRazorPageActivator)) as IRazorPageActivator;

                var result = _razorViewEngine.FindPage(actionContext, pageName);

                if (result.Page == null)
                {
                    throw new ArgumentNullException($"The page {pageName} cannot be found.");
                }

                var page = result.Page;

                var view = new RazorView(_razorViewEngine,
                    _activator,
                    new List<IRazorPage>(),
                    page,
                    HtmlEncoder.Default,
                    new DiagnosticListener("ViewRenderService"));


                var viewContext = new ViewContext(
                    actionContext,
                    view,
                    pageModel.ViewData,
                    pageModel.TempData,
                    sw,
                    new HtmlHelperOptions()
                );


                var pageNormal = ((Page)result.Page);

                pageNormal.PageContext = pageModel.PageContext;

                pageNormal.ViewContext = viewContext;


                _activator.Activate(pageNormal, viewContext);

                await page.ExecuteAsync();

                return sw.ToString();
            }
        }
    }
}


