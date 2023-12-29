using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Extensions
{
    public static class BusinessRegistrations
    {
        public static IServiceCollection RegisterBusiness(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            
            return services;
        }
    }
}