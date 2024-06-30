using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Bll.ManagerServices.Concretes;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Bll.ManagerServices.Concretes
{
    public class ProductManager:BaseManager<Product>,IProductManager
    {
        IProductRepository _proRepo;
        public ProductManager(IProductRepository proRep):base(proRep) 
        {
            _proRepo = proRep;
        }
    }
}