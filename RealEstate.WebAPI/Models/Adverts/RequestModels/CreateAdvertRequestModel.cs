namespace RealEstate.WebAPI.Models.Adverts.RequestModels
{
    public class CreateAdvertRequestModel
    {
        public string AdvertName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }

    }
}
