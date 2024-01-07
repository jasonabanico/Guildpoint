using Guildpoint.Core;

namespace Guildpoint.Modules.Common.Services
{
    public class NodeService : INodeService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public NodeService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task AddNodeAsync(Node node)
        {
            var httpClient = _httpClientFactory.CreateClient("Api");
            var content = MutationHelper.AddNodeMutation(node);
            var response = await httpClient.PostAsync("/graphql", new StringContent(content));
        }

    }
}
