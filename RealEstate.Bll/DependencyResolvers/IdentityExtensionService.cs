using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using RealEstate.Dal.Context;
using RealEstate.Entities.Models;

namespace RealEstate.Bll.DependencyResolvers
{
    /// <summary>
    // IdentityExtensionService sınıfı, kimlik hizmetlerinin eklenmesini sağlar.
    /// </summary>
    public static class IdentityExtensionService
    {
        /// <summary>
        /// AddIdentityService metodu, kimlik hizmetlerini ekler.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddIdentityService(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole<int>>(x =>
            {

                x.Password.RequiredUniqueChars = 0;
                x.Password.RequiredLength = 3;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireDigit = false;
                x.Password.RequireLowercase = false;
                x.Password.RequireUppercase = false;
                // Kimlik hizmetlerini Entity Framework Core ile entegre eder.
            }).AddEntityFrameworkStores<CustomContext>();
            return services;
        }
    }
}
