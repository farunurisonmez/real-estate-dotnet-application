using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Configurations
{
    public class AppUserConfig : BaseConfig<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);


            builder.HasKey(user => user.Id);
            builder.HasOne(user => user.Profile)
            .WithOne(user => user.AppUser)
            .HasForeignKey<AppUserProfile>(user => user.Id);
        }
    }
}
