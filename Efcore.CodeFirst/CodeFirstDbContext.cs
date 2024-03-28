using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore.CodeFirst
{
    public static class Consts
    {
        public const string ConnectionString = "Server=.;Database=Efcore.stated.database;user id=sa;pwd=1234$;Trusted_Connection=True;";
    }

    public class CodeFirstDbContext : DbContext
    {
        public CodeFirstDbContext() { }

        //public CodeFirstDbContext(DbContextOptions options) : base (options){}

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            builder.UseSqlServer(Consts.ConnectionString);
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(options =>
            {
                options.ToTable("table_product");
                options.HasKey(x => x.Key);
                options.Property(x => x.Key).HasColumnName("product_key").IsRequired();
                options.Property(x => x.Id).HasColumnName("product_id");
                options.Property(x => x.Name).HasColumnName("product_name").IsRequired();
                options.Property(x => x.Price).HasColumnName("product_price").HasColumnType("float").IsRequired();
                options.Property(x => x.IsAvailable).HasColumnName("product_available");
                options.HasData(new[] {
                    new Product { Key = 1, Name = "Product 1", Price = 10 },
                    new Product { Key = 2, Id = Guid.NewGuid(), Name = "Pro max", Price = 100 }
                });
            });
        }
    }
}
