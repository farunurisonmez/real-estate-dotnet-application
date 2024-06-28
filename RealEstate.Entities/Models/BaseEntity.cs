using RealEstate.Entities.Enums;
using RealEstate.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RealEstate.Entities.Models
{
    /// <summary>
    /// Tüm varlıklar için temel özellikleri sağlayan soyut sınıf.
    /// </summary>
    public abstract class BaseEntity : IEntity
    {
        //Constructor
        public BaseEntity()
        {
            // Yeni bir varlık oluşturulduğunda, oluşturulma tarihi şimdi olarak ayarlanır ve durum 'Inserted' olur.
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        
        public int Id { get; set; }  // Benzersiz kimlik.
        public DateTime CreatedDate { get; set; } // Oluşturulma tarihi.
        public DateTime? ModifiedDate { get; set; } // Güncellenme tarihi.
        public DateTime? DeletedDate { get; set; } // Silinme tarihi.
        public DataStatus Status { get; set; } // Verinin durumu.
    }
}