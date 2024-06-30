using RealEstate.BLL.ManagerServices.Abstract;
using RealEstate.Dal.Repositories.Abstract;
using RealEstate.Entities.Models;

namespace RealEstate.BLL.ManagerServices.Concretes
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