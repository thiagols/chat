using ChatClient.Domain;
using ChatClient.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ChatClient.App
{
    public class Startup
    {
        private static IConfiguration _configuration;

        public static IServiceCollection ConfigureServices()
        {
            _configuration = ConfigureApp();
            IServiceCollection services = new ServiceCollection();

            services.AddScoped<IChatService, ChatService>();

            return services;
        }

        public static IConfiguration ConfigureApp()
        {
            var configuration = new ConfigurationBuilder();
                //.SetBasePath(Directory.GetCurrentDirectory());

            var build = configuration.Build();
            return build;
        }
    }
}
