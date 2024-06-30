using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;


namespace RealEstate.Bll.ManagerServices.Concretes
{
    public class CategoryManager:BaseManager<Category>, ICategoryManager
    {
        ICategoryRepository _catRepository;

        public CategoryManager(ICategoryRepository catRepository):base(catRepository)
        {
            _catRepository = catRepository;
        }
    }
}