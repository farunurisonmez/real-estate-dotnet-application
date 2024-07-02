using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstate.Dal.Context;

namespace RealEstate.Bll.DependencyResolvers
{
    public static class CustomContextServiceInjection
    {
        /// <summary>
        /// Bu metot, CustomContext sınıfını dependency injection yapısına ekler.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddCustomContextService(this IServiceCollection services)
        {
            //Service sağlayıcısını oluşturuyoruz.
            ServiceProvider provider = services.BuildServiceProvider(); 

            //Configuration servisini alıyoruz. Connection string için.
            IConfiguration configuration = provider.GetService<IConfiguration>();

            services.AddDbContextPool<CustomContext>(options => options.UseNpgsql(configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies());
            return services;
        }
    }
}
