using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Configurations
{
    public class AdvertConfig:BaseConfig<Advert>
    {
        public override void Configure(EntityTypeBuilder<Advert> builder)
        {
            base.Configure(builder);
        }
    }
}
