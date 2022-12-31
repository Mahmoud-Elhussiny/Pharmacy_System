using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pharmacy.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Persistence.Dependency_Injection
{
    public static class Dependency_InjectionPersistence
    {
        public static IServiceCollection AddDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseService>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("PharmacyConnection"));
            });
            return services;
        }
    }
}
