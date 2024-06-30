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

        [HttpGet]
        public async Task<IActionResult> GetAdverts(int? categoryID, string? search)
        {
            List<AdvertResponseModel> adverts;

            if (categoryID.HasValue)
            {
                if (!string.IsNullOrEmpty(search))
                {
                    adverts = _advertManager
                        .Where(x => x.CategoryID == categoryID &&
                                    (x.AdvertName.Contains(search) ||
                                     x.Category.Name.Contains(search)))
                        .Select(x => new AdvertResponseModel
                        {
                            ID = x.ID,
                            AdvertName = x.AdvertName,
                            UnitPrice = x.UnitPrice,
                            Name = x.Category.Name
                        })
                        .ToList();
                }
                else
                {
                    adverts = _advertManager
                        .Where(x => x.CategoryID == categoryID)
                        .Select(x => new AdvertResponseModel
                        {
                            ID = x.ID,
                            AdvertName = x.AdvertName,
                            UnitPrice = x.UnitPrice,
                            Name = x.Category.Name
                        })
                        .ToList();
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(search))
                {
                    adverts = _advertManager
                        .Where(x => x.AdvertName.Contains(search) ||
                                    x.Category.Name.Contains(search))
                        .Select(x => new AdvertResponseModel
                        {
                            ID = x.ID,
                            AdvertName = x.AdvertName,
                            UnitPrice = x.UnitPrice,
                            Name = x.Category.Name
                        })
                        .ToList();
                }
                else
                {
                    adverts = _advertManager
                        .Select(x => new AdvertResponseModel
                        {
                            ID = x.ID,
                            AdvertName = x.AdvertName,
                            UnitPrice = x.UnitPrice,
                            Name = x.Category.Name
                        })
                        .ToList();
                }
            }

            return Ok(adverts);
        }

    }
}
