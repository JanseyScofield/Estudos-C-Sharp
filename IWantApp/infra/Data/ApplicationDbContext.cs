using IWantApp.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Flunt.Notifications;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace IWantApp.Infra.Data {
    public class ApplicationDbContext : IdentityDbContext<IdentityUser> {

        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Category { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder) {
            
            base.OnModelCreating(builder);

            builder.Ignore<Notification>();
            builder.Entity<Products>().Property(p => p.Name).IsRequired();
            builder.Entity<Products>().Property(p => p.Description).HasMaxLength(255);
            builder.Entity<Category>().Property(p => p.Name).IsRequired();
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configuration) {
            configuration.Properties<string>().HaveMaxLength(100);
        }

    }
}


