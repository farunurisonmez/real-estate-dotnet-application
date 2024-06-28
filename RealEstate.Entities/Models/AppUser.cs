using Microsoft.AspNetCore.Identity;
using RealEstate.Entities.Enums;
using RealEstate.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Entities.Models {
    public class AppUser : IdentityUser<int>, IEntity {
        public AppUser() {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        
        public int İd { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        // Relational Properties
        
        public virtual AppUserProfile Profile { get; set; }
    }
}