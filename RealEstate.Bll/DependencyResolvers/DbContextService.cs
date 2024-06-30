using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstate.Dal.Context;

namespace RealEstate.Bll.DependencyResolvers
{
    public static class DbContextServiceInjection
    {
        public static IServiceCollection AddDbContextService(this IServiceCollection services)
        {
            ServiceProvider provider = services.BuildServiceProvider(); 
            IConfiguration configuration = provider.GetService<IConfiguration>();
            services.AddDbContextPool<CustomDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies());
            return services;
        }
    }
}