using RealEstate.Dal.Context;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Dal.Repositories.Concretes
{
    public class AdvertRepository:BaseRepository<Advert>,IAdvertRepository
    {
        public AdvertRepository(CustomContext db):base(db)
        {

        }
    }
}
