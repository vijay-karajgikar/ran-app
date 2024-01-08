using RanApp.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RanApp.DataAccess.Extensions
{
    public static class DataAccessRegistrations
    {
        public static IServiceCollection RegisterDataAccess(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<RanDbContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("RanConnectionString")));

            return services;    
        }
    }
}