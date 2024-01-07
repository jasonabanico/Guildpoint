using Microsoft.Extensions.DependencyInjection;

namespace Guildpoint.Services
{
    public static class ServicesStartup
    {
        public static void AddGuildpointServices(this IServiceCollection services)
        {
            services.AddSingleton<INodeService, NodeService>();
        }
    }
}
