using RealEstate.Dal.Context;
using RealEstate.Dal.Repositories.Abstract;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Repositories.Concretes {

    //<summary>
    //CategoryRepository sınıfı BaseRepository sınıfından kalıtım alır ve ICategoryRepository interface'sini implemente eder.
    //</summary>
    public class ProductDetailRepository : BaseRepository<ProductDetail>, IProductDetailRepository
    {
      //Constructor metodu ile DbContext tipinde bir parametre alır ve bu parametreyi BaseRepository sınıfının constructor metoduna gönderir.
      public ProductDetailRepository(DbContext context) : base(context)
      {

      }
    }
}