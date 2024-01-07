using Guildpoint.Core;

namespace Guildpoint.Services
{
    public interface INodeService
    {
        Task AddNodeAsync(Node node);
        Task<Node> GetNodeAsync(string id);
        Task<List<Node>> GetNodesByParentIdAsync(string parentId);
    }
}
