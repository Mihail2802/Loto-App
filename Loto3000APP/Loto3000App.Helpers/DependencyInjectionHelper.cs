using Loto3000App.Services.Implementation;
using Loto3000App.Services.Interfaces;
using LotoApp_DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Loto3000App.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static IServiceCollection InjectDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<TicketsDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddScoped<ICarouselInteface,CarouselServise>();
            return services;
        }
    }
}
