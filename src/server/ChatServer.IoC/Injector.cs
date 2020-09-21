using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ChatServer.IoC
{
    public static class Injector
    {
        public static IServiceCollection Register(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
