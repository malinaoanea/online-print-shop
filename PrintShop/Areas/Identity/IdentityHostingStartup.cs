using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrintShop.Models;

[assembly: HostingStartup(typeof(PrintShop.Areas.Identity.IdentityHostingStartup))]
namespace PrintShop.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PrintShopContext>(options =>
                    options.UseNpgsql(
                        context.Configuration.GetConnectionString("PrintShopContextConnection")));

                // services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    // .AddEntityFrameworkStores<PrintShopIdentityDbContext>();
            });
        }
    }
}