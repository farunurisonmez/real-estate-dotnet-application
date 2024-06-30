﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Entities.Models;
using RealEstate.WebAPI.Models.AppUsers.RequestModels;

namespace RealEstate.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        IAppUserManager _appUserManager;

        public RegisterController(IAppUserManager appUserManager)
        {
            _appUserManager = appUserManager;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(UserRegisterRequestModel item)
        {
            AppUser appUser = new()
            {
                UserName = item.UserName,
                Email = item.Email,
                PasswordHash = item.Password
            };

            bool result = await _appUserManager.CreateUserAsync(appUser);
            if (result)
            {
                return Ok("Kullanıcı ekleme basarılı");
            }
            return BadRequest("Kullanıcı ekleme kısmında bir sorunla karsılasıldı");
        }
    }
}
