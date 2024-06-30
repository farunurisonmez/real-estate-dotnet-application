﻿using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Bll.ManagerServices.Concretes
{
    public class AppUserProfileManager:BaseManager<AppUserProfile>,IAppUserProfileManager
    {
        IAppUserProfileRepository _proRep;
        public AppUserProfileManager(IAppUserProfileRepository proRep):base(proRep)
        {
            _proRep = proRep;   
        }
    }
}
