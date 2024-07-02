using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Configurations
{
    public class AppUserProfileConfig:BaseConfig<AppUserProfile>
    {
        public override void Configure(EntityTypeBuilder<AppUserProfile> builder)
        {
            base.Configure(builder);
        }
    }
}
