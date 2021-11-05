using System.Security.Claims;
using System.Security.Principal;

namespace UniversityApp.Data.Extensions
{
    public static class Extensions
    {
        public static string FullName(this IPrincipal user)
        {
            if (user.Identity.IsAuthenticated)
            {
                var claimsIdentity = user.Identity as ClaimsIdentity;
                foreach (var claim in claimsIdentity.Claims)
                {
                    if (claim.Type == "FirstName")
                        return claim.Value;
                }
                return "";
            }
            else
                return "";
        }

        public static string GivenName(this IPrincipal user)
        {
            if (user.Identity.IsAuthenticated)
            {
                var claim = ((ClaimsIdentity)user.Identity).FindFirst(ClaimTypes.GivenName);
                return claim == null ? null : claim.Value;
            }
            return "";
        }
    }
}
