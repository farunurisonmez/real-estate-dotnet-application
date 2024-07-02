namespace RealEstate.Entities.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual List<Advert> Adverts { get; set; }


    }
}
