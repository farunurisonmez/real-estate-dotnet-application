﻿using RealEstate.Entities.Models;

namespace RealEstate.Bll.ManagerServices.Abstracts
{
    public interface IAdvertManager:IManager<Advert>
    {
        List<Advert> GetAdverts(int? categoryId, string search);
    }
}
