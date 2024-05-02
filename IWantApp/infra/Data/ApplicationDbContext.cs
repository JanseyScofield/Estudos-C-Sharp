using IWantApp.Domain.Products;
using System.Globalization;
using System;
using Microsoft.EntityFrameworkCore;

namespace IWantApp.Infra.Data {
    public class ApplicationDbContext : DbContext {

        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Category { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Products>().Property(p => p.Name).IsRequired();
            builder.Entity<Products>().Property(p => p.Description).HasMaxLength(255);
            builder.Entity<Category>().Property(p => p.Name).IsRequired();
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configuration) {
            configuration.Properties<string>().HaveMaxLength(100);
        }

    }
}


