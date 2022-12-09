using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers.Map
{
    [Route("ackeron/MapArea/[controller]")]
    [ApiController]
    public class MapAreaController : ControllerBase
    {
        private readonly IMapService _mapService;

        public MapAreaController(IMapService mapService)
        {
            _mapService = mapService;
        }
        [HttpPost("/ChkAreaReachable/")]
        public IActionResult ChkAreaReachable(Localisator Loc)
        {
            return Ok(_mapService.ChkAreaReachable(Loc));
        }
    }
}
