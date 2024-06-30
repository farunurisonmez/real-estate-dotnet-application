using RealEstate.Dal.Context;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Repositories.Concretes {
    public class AppUserProfileRepository : BaseRepository<AppUserProfile>, IAppUserProfileRepository
    {
        public AppUserProfileRepository(CustomDbContext context) : base(context)
        {

        }
    }
}