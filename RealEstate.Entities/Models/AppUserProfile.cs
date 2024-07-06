namespace RealEstate.Entities.Models
{
    public class AppUserProfile : BaseEntity
    {
        public int Id { get; set; } // AppUser ile aynı anahtarı kullanır

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties
        public virtual AppUser AppUser { get; set; }

    }
}
