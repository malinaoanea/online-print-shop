using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrintShop.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PrintShop.Models;

namespace PrintShop
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
            //services.AddDbContext<PrintShopIdentityDbContext>(options =>
               // options.UseSqlServer(
                 //   Configuration.GetConnectionString("PrintShopIdentityDbContextConnection")));
                 
                  
                 
            services.AddDbContext<PrintShopContext>( options =>
                 options.UseNpgsql(
                  Configuration.GetConnectionString("PrintShopContextConnection")));
            
            
            
            services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddDefaultUI() 
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<PrintShopContext>();
            
            
            services.AddDbContext<PrintShopContext>(options =>
                options.UseNpgsql(
                    Configuration.GetConnectionString("PrintShopContextConnection")));
            
            

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
            
            Roles(serviceProvider);
        }
        
        private void Roles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            Task<bool> var = roleManager.RoleExistsAsync("Costumer");
            var.Wait();
            Task<bool> var1 = roleManager.RoleExistsAsync("Admin");
            var1.Wait();

            if (var.Result)
            {
                var roleResult = roleManager.CreateAsync(new IdentityRole("Costumer"));
                roleResult.Wait();
            }

            if (var1.Result)
            {
                var roleResult = roleManager.CreateAsync(new IdentityRole("Admin"));
                    roleResult.Wait();
                

                var newUser = new IdentityUser();
                newUser.Email = "malina@gmail.com";
                newUser.UserName = "malina@gmail.com";
                
                Task<IdentityResult> task = userManager.CreateAsync(newUser, "Pa55word!");
                task.Wait();
                
                if (task.Result.Succeeded)
                {
                    userManager.AddToRoleAsync(newUser, "Admin").Wait(); 
                    
                }
                
            }

        }

    }
}