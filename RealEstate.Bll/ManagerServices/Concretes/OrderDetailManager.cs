using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;

namespace RealEstate.Bll.ManagerServices.Concretes
{
    public class AdvertDetailManager:BaseManager<AdvertDetail>,IAdvertDetailManager
    {
        IAdvertDetailRepository _odRep;
        public AdvertDetailManager(IAdvertDetailRepository odRep):base(odRep)
        {
            _odRep = odRep;
        }
    }
}
