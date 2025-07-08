using basel.infra.Abstract;
using basel.infra.Generic;
using basel.infra.Repo;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basel.infra
{
    public static class ModuleInfra
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepo, StudentRepo>();
            services.AddTransient(typeof(IGenericRepo<>), typeof(GenericRepo<>));
            return services;
        }
    }
}
