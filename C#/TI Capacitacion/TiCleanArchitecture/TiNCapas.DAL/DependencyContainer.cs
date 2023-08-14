using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiNCapas.Bussiness;
using TiNcapas.Entities;
using TiNCapas.DAL;

namespace TiNCapas.DAL
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepository(this IServiceCollection services) {

            services.AddScoped<IUserRepository,UserRepository>();
            return services;
        }

    }
}
