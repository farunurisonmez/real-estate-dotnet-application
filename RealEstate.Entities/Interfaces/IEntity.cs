using RealEstate.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Entities.Interfaces
{
    public interface IEntity
    {
        public int ID { get; set; }
        // Varlığın oluşturulma tarihini alır veya ayarlar.
        public DateTime CreatedDate { get; set; }
        //Varlığın son değiştirilme tarihini alır veya ayarlar.
        public DateTime? ModifiedDate { get; set; }
        // Varlığın silinme tarihini alır veya ayarlar.
        public DateTime? DeletedDate { get; set; }
        // Varlığın durumunu (Eklendi, Güncellendi, Silindi) alır veya ayarlar.

        public DataStatus Status { get; set; }
    }
}
