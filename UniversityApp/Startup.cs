using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using UniversityApp.Data;
using UniversityApp.Data.Helpers;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;
using UniversityApp.Data.Models.Email;
using UniversityApp.Data.SqlData;
using UniversityApp.Data.UserData;

namespace UniversityApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddIdentityCore<ApplicationUser>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireNonAlphanumeric = true;
            }).AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("IsAdmin", policy =>
                    policy.RequireRole("admin"));

                options.AddPolicy("IsStudent", policy =>
                    policy.RequireRole("student"));

                options.AddPolicy("IsTeacher", policy =>
                    policy.RequireRole("teacher"));

                options.AddPolicy("IsOffice", policy =>
                    policy.RequireRole("office"));
            });

            services.AddScoped<IAnnouncementData, SqlAnnouncementData>();
            services.AddScoped<IUsersData, SqlUserData>();
            services.AddScoped<IFilesData, SqlFilesData>();
            services.AddScoped<ISubjectData, SqlSubjectData>();
            services.AddScoped<IDepartmentData, SqlDepartmentData>();
            services.AddScoped<IViewRenderService, ViewRenderService>();
            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationUsersClaimsPrincipalFactory>();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddHttpContextAccessor();

            //services.AddHangfire(x=>x.UseSqlServerStorage
            //(@"Server=(localdb)\\mssqllocaldb;Initial Catalog=Hangfire;Trusted_Connection=True;"));
            //services.AddHangfireServer();

            // Add Hangfire services.
            services.AddHangfire(configuration => configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage(Configuration.GetConnectionString("HangfireConnection"), new SqlServerStorageOptions
                {
                    CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                    SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                    QueuePollInterval = TimeSpan.Zero,
                    UseRecommendedIsolationLevel = true,
                    DisableGlobalLocks = true
                }));

            // Add the processing server as IHostedService
            services.AddHangfireServer();

            services
                .AddRazorPages()
                .AddViewLocalization();

            services.AddMvc().AddRazorPagesOptions(options =>
                options.Conventions.AddPageRoute("/ManagementPanel/Index", ""));

            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc().AddViewLocalization().AddDataAnnotationsLocalization();

            services.Configure<RequestLocalizationOptions>(options =>
            {
            //    var supportedCultures = new List<CultureInfo>
            //    {
            //            new CultureInfo("pl-PL"),
            //            new CultureInfo("en-GB")
            //    };

                options.SetDefaultCulture("pl-PL");
                options.AddSupportedUICultures("pl-PL", "en-GB");
                options.FallBackToParentUICultures = true;
                //options.SupportedCultures = supportedCultures;
                //options.SupportedUICultures = supportedCultures;

                //options
                //    .RequestCultureProviders
                //    .Remove((IRequestCultureProvider)typeof(AcceptLanguageHeaderRequestCultureProvider));
            });

            //Mail pipeline
            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<EmailSenderOptions>(options =>
            {
                options.Host_Address = "smtp-relay.sendinblue.com";
                options.Host_Port = 587;
                options.Host_Username = "datsenz@gmail.com";
                options.Host_Password = "dVxQRCSy9BcNKDn3";
                options.Sender_Email = "thirdage@ath.com";
                options.Sender_Name = "Bielsko-Bia³a University";
            });

            services.AddScoped<RequestLocalizationCookiesMiddleware>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IBackgroundJobClient backgroundJobs)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseHangfireDashboard();
            backgroundJobs.Enqueue(() => Console.WriteLine("Hello from Hangfire"));

            app.UseRequestLocalization();
            //app.UseRequestLocalizationCookies();

            app.UseRouting();

            //app.UseRequestLocalization(app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>().Value);

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapDefaultControllerRoute().RequireAuthorization();
            });
        }
    }
}
