﻿using System.ComponentModel.DataAnnotations;

namespace RealEstate.WebAPI.Models.AppUsers.RequestModels
{
    public class UserRegisterRequestModel
    {
       
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }

    }
}
