using Guildpoint.Core;
using Guildpoint.Services;

namespace Guildpoint.Api
{
    public class Mutation
    {
        public async Task AddNode([Service] INodeService nodeService, Node node)
        {
        }

        public async Task UpdateNode([Service] INodeService nodeService, Node node)
        {
        }

        public async Task DeleteNode([Service] INodeService nodeService, string id)
        {
        }
    }
}
