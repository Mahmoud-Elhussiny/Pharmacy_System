using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Pharmacy.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book.Application.DependencyInjectionApplication
{
    public static class Dependency_InjectionApplication
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient<IConfirmEmail, ConfirmEmail>();
            
            return services;
        }
    }
}
