using RealEstate.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Dal.Repositories.Abstracts
{
    public interface IAdvertRepository:IRepository<Advert>
    {
        //IRepostory'den gelen metotlar dışında özel metotlarımız olacak.
    }
}
