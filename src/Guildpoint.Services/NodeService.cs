using Guildpoint.Core;
using Guildpoint.Data;
using Microsoft.EntityFrameworkCore;

namespace Guildpoint.Services
{
    public class NodeService : INodeService
    {
        private readonly ApplicationDbContext _context;

        public NodeService(ApplicationDbContext context) 
        { 
            _context = context;
        }

        public async Task AddNodeAsync(Node node)
        {
            node.Id = new Guid().ToString();
            await _context.Nodes.AddAsync(node);
            await _context.SaveChangesAsync();
        }

        public async Task<Node> GetNodeAsync(string id)
        {
            return await _context.Nodes.FindAsync(id);
        }

        public async Task<List<Node>> GetNodesByParentIdAsync(string parentId)
        {
            return await _context.Nodes.Where(n => n.ParentId == parentId).ToListAsync();
        }
    }
}
