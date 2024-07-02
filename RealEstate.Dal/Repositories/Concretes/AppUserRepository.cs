using Microsoft.AspNetCore.Identity;
using RealEstate.Dal.Context;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Dal.Repositories.Concretes
{
    public class AppUserRepository:BaseRepository<AppUser>,IAppUserRepository
    {
        UserManager<AppUser> _userManager;

        public AppUserRepository(CustomContext db,UserManager<AppUser> userManager):base(db)
        {
            
            _userManager = userManager;
        }

        public async Task<bool> AddUser(AppUser item)
        {
            IdentityResult result = await _userManager.CreateAsync(item, item.PasswordHash);
            
            if (result.Succeeded) return true;
            return false;
        }

    }
}
