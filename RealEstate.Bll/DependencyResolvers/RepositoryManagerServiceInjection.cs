using Microsoft.Extensions.DependencyInjection;
using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Bll.ManagerServices.Concretes;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Dal.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Bll.DependencyResolvers
{
    public static class RepositoryManagerServiceInjection
    {
        public static IServiceCollection AddRepositoryManagerServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));
            services.AddScoped<IAdvertRepository, AdvertRepository>();
            services.AddScoped<IAdvertManager, AdvertManager>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IAdvertDetailRepository,AdvertDetailRepository>();
            services.AddScoped<IAdvertDetailManager, AdvertDetailManager>();
            services.AddScoped<IAppUserProfileRepository, AppUserProfileRepository>();
            services.AddScoped<IAppUserProfileManager, AppUserProfileManager>();

            return services;

        }
    }
}
