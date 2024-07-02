using Microsoft.AspNetCore.Identity;
using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;

namespace RealEstate.Bll.ManagerServices.Concretes
{
    public class AppUserManager : BaseManager<AppUser>, IAppUserManager
    {

        IAppUserRepository _apRep;

        public AppUserManager(IAppUserRepository apRep) : base(apRep)
        {
            _apRep = apRep;
        }

        public async Task<bool> CreateUserAsync(AppUser item)
        {
            return await _apRep.AddUser(item);
        }


    }
}
