using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Data
{
    public class RequestLocalizationCookiesMiddleware : IMiddleware
    {
        //public CookieReq MyProperty { get; set; }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}

