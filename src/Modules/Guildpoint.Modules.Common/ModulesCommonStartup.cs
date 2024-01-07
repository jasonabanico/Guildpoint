using Guildpoint.Modules.Common.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Guildpoint.Modules.Common
{
    public static class ModulesCommonStartup
    {
        public static void AddGuildpointModulesCommon(this IServiceCollection services)
        {
            services.AddScoped<INodeService, NodeService>();
            services.AddHttpClient("Api", client =>
            {
                client.BaseAddress = new Uri("/graphql");
            });
        }
    }
}
