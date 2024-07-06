using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Entities.Models;
using RealEstate.WebAPI.Models.Adverts.RequestModels;
using RealEstate.WebAPI.Models.Adverts.ResponseModels;

namespace RealEstate.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertController : ControllerBase
    {
        IAdvertManager _advertManager;

        public AdvertController(IAdvertManager advertManager)
        {
            _advertManager = advertManager;
        }

         [HttpPost]
        public async Task<IActionResult> CreateAdvert(CreateAdvertRequestModel item)
        {
            Advert p = new()
            {
                AdvertName = item.AdvertName,
                UnitPrice = item.UnitPrice,
                CategoryId = item.CategoryId
            };

            string result = _advertManager.Add(p);
            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetAdverts(int? categoryId, string? search)
        {
            var adverts = _advertManager.GetAdverts(categoryId, search)
            .Select(advert => new AdvertResponseModel {
                Id = advert.Id,
                AdvertName = advert.AdvertName,
                UnitPrice = advert.UnitPrice,
                Name = advert.Category.Name
            }).ToList();

            return Ok(adverts);
        }
    }
}
