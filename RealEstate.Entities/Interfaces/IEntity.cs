using RealEstate.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Entities.Interfaces
{
    /// <summary>
    /// Tüm varlık sınıflarının ortak özelliklere sahip olmasını sağlayan arayüz.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Varlığın benzersiz kimliğini alır veya ayarlar.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Varlığın oluşturulma tarihini alır veya ayarlar.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Varlığın son değiştirilme tarihini alır veya ayarlar.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Varlığın silinme tarihini alır veya ayarlar.
        /// </summary>
        public DateTime? DeletedDate { get; set; }

        /// <summary>
        /// Varlığın durumunu (Eklendi, Güncellendi, Silindi) alır veya ayarlar.
        /// </summary>
        public DataStatus Status { get; set; }
    }
}