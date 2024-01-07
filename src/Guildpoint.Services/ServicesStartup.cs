using Microsoft.Extensions.DependencyInjection;

namespace Guildpoint.Services
{
    public static class ServicesStartup
    {
        public static void AddGuildpointServices(this IServiceCollection services)
        {
            services.AddScoped<INodeService, NodeService>();
        }
    }
}
