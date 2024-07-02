using Microsoft.Extensions.DependencyInjection;
using RealEstate.Bll.ManagerServices.Abstracts;
using RealEstate.Bll.ManagerServices.Concretes;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Dal.Repositories.Concretes;

namespace RealEstate.Bll.DependencyResolvers
{
    public static class RepositoryManagerServiceInjection
    {
        /// <summary>
        /// AddRepositoryManagerServices metodu, çeşitli repository ve manager hizmetlerini ekler.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRepositoryManagerServices(this IServiceCollection services)
        {
            // Generic repository ve manager için bağımlılıkları ekler.
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));

            // Spesifik repository ve manager sınıflarını ekler.
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
