using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Dal.Configurations
{
    public class AdvertConfig:BaseConfig<Advert>
    {
        public override void Configure(EntityTypeBuilder<Advert> builder)
        {
            base.Configure(builder);
            //builder.Property(x => x.UnitPrice).HasColumnType("money");
        }
    }
}
