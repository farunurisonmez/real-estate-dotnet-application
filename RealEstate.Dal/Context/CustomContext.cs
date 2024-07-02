using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate.Dal.Configurations;
using RealEstate.Entities.Models;


namespace RealEstate.Dal.Context
{
    /// <summary>
    // CustomContext sınıfı, IdentityDbContext'ten türetilmiştir.
    // Bu sınıf, uygulama için Entity Framework Core bağlamını temsil eder.
    /// </summary>
    public class CustomContext : IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        // Yapıcı metot, DbContextOptions ile yapılandırılır.
        public CustomContext(DbContextOptions<CustomContext> opt):base(opt)
        {

        }

        // OnModelCreating metodu, model yapılandırmalarını tanımlar.
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // IdentityDbContext'in OnModelCreating metodunu çağırır.
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppUserConfig());
            builder.ApplyConfiguration(new AppUserProfileConfig());
            builder.ApplyConfiguration(new CategoryConfig());
            builder.ApplyConfiguration(new AdvertConfig());
            builder.ApplyConfiguration(new AdvertDetailConfiguration());

            // AdvertDetail için birincil anahtar yapılandırması
            builder.Entity<AdvertDetail>()
            .HasKey(e => e.ID);

        }

        // DbSet'ler, veritabanı tablolarını temsil eder.
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<AdvertDetail> AdvertDetails { get; set; }

    }
}
