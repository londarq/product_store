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
            //services.AddScoped<IProductService, ProductService>();
            //services.AddScoped<IProductTypeService, ProductTypeService>();

            DAL.Startup.ConfigureServices(services, connectionString);
        }
    }
}
