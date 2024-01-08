using Business.Maps;
using Business.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RanApp.Business.Services;

namespace RanApp.Business.Extensions
{
    public static class BusinessRegistrations
    {
        public static IServiceCollection RegisterBusiness(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<IRiderService, RiderService>();
            services.AddScoped<IRiderAddressService, RiderAddressService>();
            
            services.AddAutoMapper(typeof(RiderMaps));
            return services;
        }
    }
}