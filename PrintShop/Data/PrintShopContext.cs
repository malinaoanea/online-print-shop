using Microsoft.EntityFrameworkCore;

namespace PrintShop.Models
{
    public class PrintShopContext : DbContext   
    {
        public PrintShopContext(DbContextOptions<PrintShopContext> options) : base(options)
        {}
        public DbSet<Models.Client> Clients { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
    }
}