namespace RealEstate.Entities.Models
{
    public class Advert:BaseEntity
    {
        public string AdvertName { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CategoryId { get; set; }


        //Relational Properties
        public virtual Category Category { get; set; }
    }
}
