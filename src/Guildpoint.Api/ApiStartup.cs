using Microsoft.Extensions.DependencyInjection;

namespace Guildpoint.Api
{
    public static class ApiStartup
    {
        public static void AddGuildpointApi(this IServiceCollection services)
        {
            services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();
        }
    }
}
