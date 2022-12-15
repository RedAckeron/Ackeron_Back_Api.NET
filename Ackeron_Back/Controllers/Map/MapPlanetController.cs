using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers.Map
{
    [Route("ackeron/MapPlanet/[controller]")]
    [ApiController]
    public class MapPlanetController : ControllerBase
    {
        private readonly IMapService _mapService;

        public MapPlanetController(IMapService mapService)
        {
            _mapService = mapService;
        }


        [HttpGet("/Map/Planet/GetMap/{IdPlanet}")]
        public IActionResult GetMap(int IdPlanet)
        {
            return Ok(_mapService.GetMap(IdPlanet));
        }
       
       
    }
}
