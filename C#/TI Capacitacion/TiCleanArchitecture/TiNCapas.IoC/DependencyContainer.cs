using Microsoft.Extensions.DependencyInjection;
using TiNcapas.Entities;
using TiNCapas.Bussiness;
using TiNCapas.DAL;

namespace TiNCapas.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUserManagerServices(this IServiceCollection services)
        {
            services.AddScoped<UserService>();
            services.AddRepository();
            return services;
        }
    }
}