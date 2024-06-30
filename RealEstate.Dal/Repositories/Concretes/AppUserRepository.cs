using RealEstate.Dal.Context;
using RealEstate.Dal.Repositories.Abstract;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Repositories.Concretes {

    //<summary>
    //AppUserRepository sınıfı BaseRepository sınıfından kalıtım alır ve IAppUserRepository interface'sini implemente eder.
    //</summary>
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
      //Constructor metodu ile DbContext tipinde bir parametre alır ve bu parametreyi BaseRepository sınıfının constructor metoduna gönderir.
      public AppUserRepository(DbContext context) : base(context)
      {

      }
    }
}