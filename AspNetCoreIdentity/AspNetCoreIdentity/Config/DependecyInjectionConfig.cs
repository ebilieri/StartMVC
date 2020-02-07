using AspNetCoreIdentity.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Config
{
    public  static class DependecyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //Registrar DI para classe
            services.AddSingleton<IAuthorizationHandler, PermissaoNecessariaHandler>();

            return services;
        }
    }
}
