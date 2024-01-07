using Guildpoint.Api;
using Guildpoint.Data;
using Guildpoint.Modules.Common;
using Guildpoint.Services;
using Microsoft.AspNetCore.Identity;

namespace Guildpoint.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            // Add Guildpoint services.
            builder.Services.AddGuildpointData(builder.Configuration);
            builder.Services.AddGuildpointServices();
            builder.Services.AddGuildpointApi();
            builder.Services.AddGuildpointModulesCommon();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // Use Guildpoint services.
            app.UseGuildpointApi();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapGraphQL();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}