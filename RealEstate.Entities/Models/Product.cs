using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Entities.Models {
    public class Product:BaseEntity {

        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string CoverImage { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        // Relational Properties
        public virtual Category Category { get; set; }
        public virtual List<ProductDetail> ProductDetails { get; set; }
    }
}