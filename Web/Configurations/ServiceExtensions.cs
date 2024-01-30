using DataAccess.Repository.IRepository;
using DataAccess.Repository;
using Microsoft.AspNetCore.Authorization;

namespace Web.Configurations
{
    public static class ServiceExtensions
    {
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IDbInitializer, DbInitializer>();

        }
    }
}
