using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PrintShop.Models
{
    public class PrintShopContext :  IdentityDbContext<IdentityUser>
    {
        public PrintShopContext(DbContextOptions<PrintShopContext> options) : base(options)
        {}
        public DbSet<Models.Client> Clients { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
        
        // public DbSet<IdentityUser> IdentityUsers { get; set; }
    }
}