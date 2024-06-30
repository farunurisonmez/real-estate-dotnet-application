using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate.Dal.Config;
using RealEstate.Dal.Configurations;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Context {

    //IdentityDbContext sınıfı, RealEstate.Entities katmanından referans alır.

    /**
    * RealEstate.Dal katmanı, RealEstate.Entities katmanına referans alır. 
    * Bu nedenle IdentityDbContext sınıfını kullanabilmek için RealEstate.Entities katmanına referans verilmiş olmalıdır.
    * IdentityDbContext sınıfından kalıtım alarak Identity tablolarını kullanmamızı sağlar.
    **/
    public class CustomDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>{
        //IdentityRole sınıfı normalde string türünde bir anahtar alırken, 
        //AppUser sınıfı int türünde bir anahtar alır.
        //Bu nedenle IdentityRole<int> şeklinde tanımlama yapılır.

        //DbContextOptions EntityFramework Core tarafından sağlanan bir sınıftır.
        public CustomDbContext(DbContextOptions<DbContext> opt) : base(opt){

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppUserConfig());
            builder.ApplyConfiguration(new AppUserProfileConfig());
            builder.ApplyConfiguration(new CategoryConfig());
            builder.ApplyConfiguration(new ProductConfig());
            builder.ApplyConfiguration(new ProductDetailConfig());
        }
    }
}