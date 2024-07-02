using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Entities.Interfaces;

namespace RealEstate.Dal.Configurations
{
    public abstract class BaseConfig<T> : IEntityTypeConfiguration<T> where T : class, IEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
          
        }
    }
}
