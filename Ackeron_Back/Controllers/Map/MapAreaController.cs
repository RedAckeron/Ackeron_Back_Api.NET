using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers.Map
{
    [Route("ackeron/Map/Area/[controller]")]
    [ApiController]
    public class MapAreaController : ControllerBase
    {
        private readonly IMapService _mapService;

        public MapAreaController(IMapService mapService)
        {
            _mapService = mapService;
        }
        [HttpPost("/Map/Area/ChkAreaReachable/")]
        public IActionResult ChkAreaReachable(Localisator Loc)
        {
            return Ok(_mapService.ChkAreaReachable(Loc));
        }
    }
}
