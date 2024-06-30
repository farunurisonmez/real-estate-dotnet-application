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
    public class CategoryRepository:BaseRepository<Category>,ICategoryRepository
    {
        public CategoryRepository(CustomContext db):base(db)
        {

        }
    }
}
