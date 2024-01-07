using Guildpoint.Core;
using Guildpoint.Modules.Common.Services;
using Microsoft.AspNetCore.Mvc;

namespace Guildpoint.Modules.Pages.Controllers
{
    [Route("/page")]
    public class PageController : Controller
    {
        private readonly NodeService _nodeService;

        public PageController(NodeService nodeService)
        {
            _nodeService = nodeService;
        }

        public async Task<IActionResult> Index()
        {
            var node = new Node();
            await _nodeService.AddNodeAsync(node);

            return View();
        }
    }
}
