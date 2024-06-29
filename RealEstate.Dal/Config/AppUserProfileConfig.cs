using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Dal.Configurations;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Config
{
    public class AppUserProfileConfig:BaseConfig<AppUserProfile>
    {
        public override void Configure(EntityTypeBuilder<AppUserProfile> builder)
        {
            base.Configure(builder);
        }
    }
}