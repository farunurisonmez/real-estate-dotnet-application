using Microsoft.AspNetCore.Identity;
using RealEstate.Entities.Enums;
using RealEstate.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Entities.Models {

    // Uygulama kullanıcısı sınıfı, IdentityUser sınıfından türetilir ve IEntity arayüzünü uygular
    public class AppUser : IdentityUser<int>, IEntity {
        
        // Constructor
        public AppUser() {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        
        public int İd { get; set; }
        public DateTime CreatedDate { get; set; } // Oluşturulma tarihi
        public DateTime? ModifiedDate { get; set; } // Güncellenme tarihi (nullable)
        public DateTime? DeletedDate { get; set; } // Silinme tarihi (nullable)
        public DataStatus Status { get; set; } // Veri durumu

        // Relational Properties

        public virtual AppUserProfile Profile { get; set; }
    }
}