using Guildpoint.Core;
using Guildpoint.Services;

namespace Guildpoint.Api
{
    public class Query
    {
        public Node GetNode([Service] INodeService nodeService, string id)
            => nodeService.GetNode(id);

        public List<Node> GetNodesByParenetId([Service] INodeService nodeService, string parentId) 
            => nodeService.GetNodesByParentId(parentId);

        public List<Node> GetLinkedNodes([Service] INodeService nodeService, string linkedNodeId, string linkType)
            => nodeService.GetLinkedNodes(linkedNodeId, linkType);
    }
}
