using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace basel.core
{
    public static class ModuleCore
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            var assemblies = new[] { Assembly.GetExecutingAssembly() };
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assemblies));
            var config = TypeAdapterConfig.GlobalSettings;
            config.Scan(assemblies);

            services.AddSingleton(config);
            services.AddScoped<IMapper,ServiceMapper>();
            return services;
        }
    }
}
