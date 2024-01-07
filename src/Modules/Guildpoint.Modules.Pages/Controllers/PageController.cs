using Guildpoint.Core;
using Guildpoint.Modules.Common.Services;
using Microsoft.AspNetCore.Mvc;

namespace Guildpoint.Modules.Pages.Controllers
{
    [Route("[controller]/[action]")]
    public class PageController : Controller
    {
        private readonly INodeService _nodeService;

        public PageController(INodeService nodeService)
        {
            _nodeService = nodeService;
        }

        [Route("/Page")]
        public async Task<IActionResult> Index()
        {
            var node = new Node();
            await _nodeService.AddNodeAsync(node);

            return View();
        }
    }
}
