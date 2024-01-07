using Guildpoint.Core;
using Guildpoint.Modules.Common.Mutations;
using Newtonsoft.Json;

namespace Guildpoint.Modules.Common
{
    public static class MutationHelper
    {
        public static string AddNodeMutation(Node node)
        {
            var addNodeMutation = new AddNode()
            {
                Node = node
            };
            return JsonConvert.SerializeObject(addNodeMutation);
        }
    }
}
