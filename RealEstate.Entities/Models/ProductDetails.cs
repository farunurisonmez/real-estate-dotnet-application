using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Entities.Models {
    public class ProductDetail:BaseEntity {
        public int ProductDetailID { get; set; }

        // Relational Properties
        public virtual Product Product { get; set; } 
    }
}