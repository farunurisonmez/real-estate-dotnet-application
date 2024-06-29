using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Configurations
{
    public class AppUserConfig : BaseConfig<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.Id);
            //AppUser ile AppUserProfile arasında 1-1 ilişki vardır.
            builder.HasOne(x => x.Profile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.Id);
        }
    }
}