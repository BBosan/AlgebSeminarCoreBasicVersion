using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SeminarCore2.Controllers;
using SeminarCore2.Data;
using SeminarCore2.Extra;
using SeminarCore2.Extra.Security;
using SeminarCore2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarCore2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region App_Data Folder DB u Projektu LocalDB Primjer1
            //https://www.youtube.com/watch?v=DSUtqG2wk2E
            //https://stackoverflow.com/questions/59693363/how-to-create-database-in-another-location-instead-of-default-lactation-c-users
            //https://stackoverflow.com/questions/55955282/how-to-use-datadirectory-substitution-string-in-appsettings-json-with-asp-net
            //https://stackoverflow.com/questions/37058684/how-to-set-the-right-attachdbfilename-relative-path-in-asp-net-core
            string path = Directory.GetCurrentDirectory();
            services.AddDbContextPool<MojContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")
                            .Replace("[DataDirectory]", path)));
            #endregion

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContextPool<MojContext>(options =>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))/*, ServiceLifetime.Singleton*/);

            //Email: admin@admin.com
            //Password: admin
            //https://github.com/dotnet/aspnetcore/blob/b795ac3546eb3e2f47a01a64feb3020794ca33bb/src/Identity/Extensions.Core/src/PasswordOptions.cs
            #region MozeIliOvo
            services.AddIdentity<ApplicationUser, IdentityRole>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequiredLength = 3;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireDigit = false;
                opt.SignIn.RequireConfirmedEmail = false;
                opt.SignIn.RequireConfirmedPhoneNumber = false;

            }).AddEntityFrameworkStores<MojContext>();
            #endregion

            #region MozeIliOvoGoreUAddIdentity
            //services.Configure<IdentityOptions>(opt =>
            //{
            //    opt.Password.RequireDigit = false;
            //    opt.Password.RequiredLength = 3;
            //    opt.Password.RequireLowercase = false;
            //    opt.Password.RequireNonAlphanumeric = false;
            //    opt.Password.RequireUppercase = false;
            //    opt.Password.RequireDigit = false;
            //}); 
            #endregion

            services.AddMvc(
            #region AuthorizeFilterOnWholeAppAkAGlobally
            //https://www.youtube.com/watch?v=uET7MjhUeY4
            options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser().Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            }
            #endregion
            ).AddXmlSerializerFormatters()/*.SetCompatibilityVersion(CompatibilityVersion.Version_2_2)*/;

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString($"/Admin/{nameof(AdminController.AccessDenied)}");
            });

            services.AddAuthorization(options =>
            {
                #region Old
                //options.AddPolicy("DeleteRolePolicy",
                //    policy => policy.RequireClaim("Delete Role", "true")/*.RequireClaim("Edit Role")*/);

                //options.AddPolicy("CreateRolePolicy",
                //    policy => policy.RequireClaim("Create Role", "true")); 
                #endregion

                options.AddPolicy("DeleteRolePolicy",
                    policy => policy.RequireAssertion(context =>
                    context.User.IsInRole("Admin") &&
                    context.User.HasClaim(claim => claim.Type == "Delete Role" && claim.Value == "true") ||
                    context.User.IsInRole("Super Admin")));

                #region Old
                //options.AddPolicy("EditRolePolicy",
                //    policy => policy.RequireAssertion(context => 
                //    context.User.IsInRole("Admin") && 
                //    context.User.HasClaim(claim => claim.Type == "Edit Role" && claim.Value == "true") ||
                //    context.User.IsInRole("Super Admin"))); 
                #endregion

                options.AddPolicy("EditRolePolicy",
                    policy => policy.AddRequirements(new ManageAdminRolesAndClaimsRequirement())); //custom handler

                options.AddPolicy("CreateRolePolicy",
                    policy => policy.RequireAssertion(context =>
                    context.User.IsInRole("Admin") &&
                    context.User.HasClaim(claim => claim.Type == "Create Role" && claim.Value == "true") ||
                    context.User.IsInRole("Super Admin")));

                #region NotUseful
                //options.InvokeHandlersAfterFailure = false; 
                #endregion

                options.AddPolicy("AdminRolePolicy", policy => policy.RequireRole("Admin"/*, "User"*/));

            });

            services.AddSingleton<IAuthorizationHandler, CanEditOnlyOtherAdminRolesAndClaimsHandler>();
            services.AddSingleton<IAuthorizationHandler, SuperAdminHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            #region Generated
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //} 
            #endregion

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}"); //placeholder receives 404 or which ever we put as statuscode
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication(); //Idenitity
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
