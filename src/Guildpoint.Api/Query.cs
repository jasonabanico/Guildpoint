using Guildpoint.Core;
using Guildpoint.Services;

namespace Guildpoint.Api
{
    public class Query
    {
        public async Task<Node> GetNode([Service] INodeService nodeService, string id)
            => await nodeService.GetNodeAsync(id);

        public List<Node> GetNodesByParentId([Service] INodeService nodeService, string parentId) 
            => nodeService.GetNodesByParentId(parentId);
    }
}
