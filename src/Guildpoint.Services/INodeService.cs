using Guildpoint.Core;

namespace Guildpoint.Services
{
    public interface INodeService
    {
        Node GetNode(string id);
        List<Node> GetNodesByParentId(string parentId);
        List<Node> GetLinkedNodes(string linkedNodeId, string linkType);
    }
}
