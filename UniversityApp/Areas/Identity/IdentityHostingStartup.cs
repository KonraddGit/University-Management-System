using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using UniversityApp.Data;

[assembly: HostingStartup(typeof(UniversityApp.Areas.Identity.IdentityHostingStartup))]
namespace UniversityApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationUsersClaimsPrincipalFactory>();

                services.AddIdentity<ApplicationUser, IdentityRole>(options =>
                     options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();
            });


        }
    }
}