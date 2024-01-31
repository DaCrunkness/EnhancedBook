using DataAccess.Repository.IRepository;
using DataAccess.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using Models.IdentityModels;

namespace Web.Configurations
{
    public static class ServiceExtensions
    {
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IDbInitializer, DbInitializer>();

        }

        public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddCascadingAuthenticationState();
            

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            })
                .AddIdentityCookies();

            var connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(connectionString));
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            //services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders().AddDefaultUI();
            //services.Configure<IdentityOptions>(options =>
            //{
            //    options.Password.RequiredLength = 5;
            //    options.Password.RequireLowercase = true;
            //    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(30);
            //    options.Lockout.MaxFailedAccessAttempts = 5;
            //});

            services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<DataContext>()
                .AddSignInManager()
                .AddDefaultTokenProviders();
        }
    }
}
