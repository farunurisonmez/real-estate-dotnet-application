using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
