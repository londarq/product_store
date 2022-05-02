using DAL.Repository;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DAL.Context;

namespace DAL
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
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            //services.AddTransient<IDbConnection>(db => new SqlConnection(connectionString));

            //services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IInventoryRepository, InventoryRepository>();
        }
    }
}
