using Guildpoint.Core;
using Guildpoint.Services;

namespace Guildpoint.Api
{
    public class Mutation
    {
        public async Task AddNodeAsync([Service] INodeService nodeService, Node node)
            => await nodeService.AddNodeAsync(node);

        public async Task UpdateNode([Service] INodeService nodeService, Node node)
        {
        }

        public async Task DeleteNode([Service] INodeService nodeService, string id)
        {
        }
    }
}
