using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers
{
    [Route("ackeron/map/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        private readonly IMapService _mapService;

        public MapController(IMapService mapService)
        {
            _mapService = mapService;
        }

        [HttpPost("/ChkTargetWalking/")]
        public IActionResult ChkTargetWalking(CharacterLoc CLoc)
        {
            Console.WriteLine("couche controller");
           
            return Ok(_mapService.ChkTargetWalking(CLoc));
        }
        [HttpGet("/map/GetMap/{IdPlanet}")]
        public IActionResult GetMap(int IdPlanet)
        {
            return Ok(_mapService.GetMap(IdPlanet));
        }
    }
}
