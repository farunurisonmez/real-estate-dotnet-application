using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Entities.Models
{
    public class Category : BaseEntity
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}