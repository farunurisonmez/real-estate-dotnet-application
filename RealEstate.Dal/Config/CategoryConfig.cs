using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Entities.Models;
using RealEstate.Dal.Configurations;

namespace RealEstate.Dal.Config {
    public class CategoryConfiguration:BaseConfig<Category>{
        public override void Configure(EntityTypeBuilder<Category> builder){
            base.Configure(builder);
            //Bir kategorinin birden fazla ürünü olabilir.
            //Bir ürünün sadece bir kategorisi olabilir.
            builder.HasMany(x=>x.Products).WithOne(x=>x.Category).HasForeignKey(x=>x.Id);
        }
    }
}