using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Configurations {
    public class ProductConfig:BaseConfig<Product> {
        public override void Configure(EntityTypeBuilder<Product> builder){
            base.Configure(builder);
            builder.HasMany(x=>x.ProductDetails)
            .WithOne(x=>x.Product)
            .HasForeignKey(x => x.Product.ProductID).IsRequired();
        }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<AppUserProfile> AppUserProfiles { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductDetail> ProductDetails { get; set; }
    }
}