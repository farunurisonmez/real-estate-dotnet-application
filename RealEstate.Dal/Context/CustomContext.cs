using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate.Dal.Configurations;
using RealEstate.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Dal.Context
{
    public class CustomContext : IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        public CustomContext(DbContextOptions<CustomContext> opt):base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppUserConfig());
            builder.ApplyConfiguration(new AppUserProfileConfig());
            builder.ApplyConfiguration(new CategoryConfig());
            builder.ApplyConfiguration(new AdvertConfig());
            builder.ApplyConfiguration(new AdvertDetailConfiguration());

            builder.Entity<AdvertDetail>()
            .HasKey(e => e.ID);

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<AdvertDetail> AdvertDetails { get; set; }

    }
}
