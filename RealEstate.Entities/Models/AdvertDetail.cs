using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Entities.Models
{
    public class AdvertDetail:BaseEntity
    {
        public int AdvertID { get; set; }

        //Relational Properties
        public virtual Advert Advert { get; set; }
    }
}
