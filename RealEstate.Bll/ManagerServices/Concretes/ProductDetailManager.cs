using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Bll.ManagerServices.Concretes;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;


namespace RealEstate.Bll.ManagerServices.Concretes
{
    public class OrderDetailManager:BaseManager<ProductDetail>,IOrderDetailManager
    {
        IProductDetailRepository _pdRep;
        public OrderDetailManager(IProductDetailRepository pdRep):base(pdRep)
        {
            _pdRep = pdRep;
        }
    }
}