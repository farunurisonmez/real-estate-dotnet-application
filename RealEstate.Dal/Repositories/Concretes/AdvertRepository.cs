using RealEstate.Dal.Context;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;

namespace RealEstate.Dal.Repositories.Concretes
{
    public class AdvertRepository:BaseRepository<Advert>,IAdvertRepository
    {
        public AdvertRepository(CustomContext db):base(db)
        {

        }
    }
}
