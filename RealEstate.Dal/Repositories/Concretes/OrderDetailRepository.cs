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
    public class AdvertDetailRepository:BaseRepository<AdvertDetail>,IAdvertDetailRepository
    {
        public AdvertDetailRepository(CustomContext db):base(db)
        {

        }
    }
}
