using RealEstate.Entities.Models;

namespace RealEstate.Bll.ManagerServices.Abstracts
{
    public interface IAppUserManager : IManager<AppUser>
    {
        Task<bool> CreateUser(AppUser item);
    }
}