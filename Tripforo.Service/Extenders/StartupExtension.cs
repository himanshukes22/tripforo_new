using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tripforo.Repository.EFCoreModels.ScaffoldedEntity;
using Tripforo.Repository.Repositories.Supplier;
using Tripforo.Repository.RepositoryContracts.Supplier;
using Tripforo.Service.ServiceContracts.Supplier;
using Tripforo.Service.Services.Supplier;

namespace Tripforo.Service.Extenders
{
    public static class StartupExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // do all shorts of service configuration like DI, Authentications etc
            services.AddDbContext<FlyrajaContext>(options => options.UseSqlServer(configuration["dbconn:Flyraja"]));
            // Add application services.        
            //services.AddScoped<ISupplierService, SupplierService>();
            //// Add repos as scoped dependency so they are shared per request.   
            //services.AddScoped<ISupplierRepository, SupplierRepository>();
            return services;
        }
    }
}
