using RealEstate.Dal.Context;
using RealEstate.Dal.Repositories.Abstract;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Repositories.Concretes {
    public class AppUserProfileRepository : BaseRepository<AppUserProfile>, IAppUserProfileRepository
    {
        public AppUserProfileRepository(DbContext context) : base(context)
        {

        }
    }
}