using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Configurations
{
    public class AdvertDetailConfiguration:BaseConfig<AdvertDetail>
    {
        public override void Configure(EntityTypeBuilder<AdvertDetail> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
        }
    }
}
