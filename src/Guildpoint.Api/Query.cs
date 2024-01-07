using Guildpoint.Core;
using Guildpoint.Services;

namespace Guildpoint.Api
{
    public class Query
    {
        public async Task<Node> GetNodeAsync([Service] INodeService nodeService, string id)
            => await nodeService.GetNodeAsync(id);

        public async Task<List<Node>> GetNodesByParentIdAsync([Service] INodeService nodeService, string parentId) 
            => await nodeService.GetNodesByParentIdAsync(parentId);
    }
}
