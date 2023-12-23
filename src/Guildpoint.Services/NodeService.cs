using Guildpoint.Core;
using Guildpoint.Data;

namespace Guildpoint.Services
{
    public class NodeService : INodeService
    {
        private readonly ApplicationDbContext _context;

        public NodeService(ApplicationDbContext context) 
        { 
            _context = context;
        }

        public async Task<Node> GetNodeAsync(string id)
        {
            return await _context.Nodes.FindAsync(id);
        }

        public List<Node> GetNodesByParentId(string parentId)
        {
            return _context.Nodes.Where(n => n.ParentId == parentId).ToList();
        }
    }
}
