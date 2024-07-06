using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;

namespace RealEstate.Bll.ManagerServices.Concretes
{
    public class AdvertManager : BaseManager<Advert>, IAdvertManager
    {
        IAdvertRepository _advertRepo;
        public AdvertManager(IAdvertRepository advertRep) : base(advertRep)
        {
            _advertRepo = advertRep;
        }
        public List<Advert> GetAdverts(int? categoryId, string search)
        {
            var query = _advertRepo.GetAll();

            if(categoryId.HasValue){
                query = query.Where(x => x.CategoryId == categoryId);
            }

            if(!string.IsNullOrEmpty(search)){
                query = query.Where(x => x.AdvertName.Contains(search));
            }
            
            return query.ToList();
        }
    }

}
