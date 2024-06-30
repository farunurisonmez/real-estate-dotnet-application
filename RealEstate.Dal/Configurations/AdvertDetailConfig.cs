using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
