using RealEstate.Entities.Models;

namespace RealEstate.BLL.ManagerServices.Abstract
{
    public interface IAppUserManager : IManager<AppUser>
    {
        Task<bool> CreateUser(AppUser item);
    }
}