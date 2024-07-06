using Microsoft.AspNetCore.Identity;
using RealEstate.Entities.Enums;
using RealEstate.Entities.Interfaces;

namespace RealEstate.Entities.Models
{
    /// <summary>
    // AppUser sınıfı, IdentityUser sınıfını kalıtım alır ve IEntity arayüzünü uygular.
    // Bu sınıf uygulama kullanıcılarını temsil eder.
    /// </summary>
    public class AppUser : IdentityUser<int>, IEntity
    {
        // Varsayılan yapıcı metot. Kullanıcı oluşturulduğunda başlangıç değerlerini atar.
        public AppUser()
        {
            // Kullanıcı oluşturulduğunda CreatedDate'yi o anki zamana ayarlar.
            CreatedDate = DateTime.UtcNow;
            // Kullanıcı oluşturulduğunda Status'u Inserted olarak ayarlar.
            Status = DataStatus.Inserted;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        // İlişkisel özellik: Kullanıcının profili
        public virtual AppUserProfile Profile { get; set; }
    }
}
