using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Bll.ManagerServices.Concretes
{
    public class AdvertManager:BaseManager<Advert>,IAdvertManager
    {
        IAdvertRepository _proRepo;
        public AdvertManager(IAdvertRepository proRep):base(proRep) 
        {
            _proRepo = proRep;
        }
    }
}
