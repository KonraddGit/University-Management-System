using Hangfire.Dashboard;
using Microsoft.AspNetCore.Authorization;

namespace UniversityApp.Data.Helpers
{
    [Authorize(Roles = "admin")]
    public class AuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context)
        {
            var httpContext = context.GetHttpContext();

            return httpContext.User.Identity.IsAuthenticated;
        }
    }
}
