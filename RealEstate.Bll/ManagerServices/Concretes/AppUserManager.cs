using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;

namespace RealEstate.Bll.ManagerServices.Concretes
{
    public class AppUserManager:BaseManager<AppUser>, IAppUserManager{
        IAppUserRepository _repository;

        public AppUserManager(IAppUserRepository repository):base(repository){
            _repository = repository;
        }

        public async Task<bool> CreateUser(AppUser item)
        {
            return await _repository.AddUser(item);
        }
    }
}