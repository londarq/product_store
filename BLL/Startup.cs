using BLL.Services;
using BLL.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BLL
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            services.AddAutoMapper(typeof(Startup));

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductCategoryService, ProductCategoryService>();
            services.AddScoped<IProductInventoryService, ProductInventoryService>();

            //object p = new DAL.SampleContextFactory(connectionString);
            DAL.Startup.ConfigureServices(services, connectionString);
        }
    }
}
