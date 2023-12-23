using Guildpoint.Core;

namespace Guildpoint.Services
{
    public interface INodeService
    {
        Task<Node> GetNodeAsync(string id);
        List<Node> GetNodesByParentId(string parentId);
    }
}
