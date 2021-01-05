using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PrintShop.Models
{
    public class PrintShopContext :  IdentityDbContext<IdentityUser>
    {
        public PrintShopContext(DbContextOptions<PrintShopContext> options) : base(options)
        {
        }
        public DbSet<Models.Client> Clients { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
        
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.CartItem> CartItems { get; set; }
        
        public DbSet<Models.ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasOne<Category>(s => s.Category)
                .WithMany(g => g.Products)
                .HasForeignKey(s => s.CategoryId);
        }

        // public DbSet<IdentityUser> IdentityUsers { get; set; }
    }
}