using Microsoft.AspNetCore.Identity;
using RealEstate.Dal.Context;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Repositories.Concretes {

    //<summary>
    //AppUserRepository sınıfı BaseRepository sınıfından kalıtım alır ve IAppUserRepository interface'sini implemente eder.
    //</summary>
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
      UserManager<AppUser> _userManager;

      //Constructor metodu ile DbContext tipinde bir parametre alır ve bu parametreyi BaseRepository sınıfının constructor metoduna gönderir.
      public AppUserRepository(CustomDbContext context, UserManager<AppUser> userManager) : base(context)
      {
        _userManager = userManager;
      }

      public async Task<bool> AddUser(AppUser item) {
        IdentityResult result = await _userManager.CreateAsync(item, item.PasswordHash);
        if(result.Succeeded) return true;
        return false;
      }
    }
}