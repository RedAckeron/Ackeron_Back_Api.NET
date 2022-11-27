using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers
{
    [Route("ackeron/map/[controller]")]
    [ApiController]
    public class MapController : Controller
    {
        private readonly IMapService _mapService;

        public MapController(IMapService mapService)
        {
            _mapService = mapService;
        }

        [HttpGet("/ChkTargetWalking/")]
        public IActionResult GetItem(CharacterLoc CLoc)
        {
            return Ok(_mapService.ChkTargetWalking(CLoc));
        }
    }
}
