using Guildpoint.Core;

namespace Guildpoint.Modules.Common.Services
{
    public interface INodeService
    {
        Task AddNodeAsync(Node node);
    }
}
