using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ScSoft.Infrastructure;

    public static class DependencyInjection
    {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
    //public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
    //{
    //    return app;
    //}
}

