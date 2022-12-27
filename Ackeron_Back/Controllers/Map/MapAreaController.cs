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

        [HttpPost("/MapArea/Create")]
        public IActionResult Create(Localisator Loc)
        {
            return Ok(_mapService.ChkAreaReachable(Loc));
        }
        
        [HttpGet("/MapArea/Read/{IdArea}")]
        public IActionResult Read(Localisator Loc)
        {
            return Ok(_mapService.ChkAreaReachable(Loc));
        }
        
        [HttpPut("/MapArea/Update/")]
        public IActionResult Update(Localisator Loc)
        {
            return Ok(_mapService.ChkAreaReachable(Loc));
        }
        
        [HttpDelete("/MapArea/Delete/")]
        public IActionResult Delete(Localisator Loc)
        {
            return Ok(_mapService.ChkAreaReachable(Loc));
        }

        [HttpPost("/MapArea/ChkAreaReachable/")]
        public IActionResult ChkAreaReachable(Localisator Loc)
        {
            return Ok(_mapService.ChkAreaReachable(Loc));
        }
    }
}
