using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers
{
    [Route("ackeron/map/[controller]")]
    [ApiController]
    public class LocalisatorController : Controller
    {
        private readonly ILocalisatorService _localisatorService;

        public LocalisatorController(ILocalisatorService localisatorService)
        {
            _localisatorService = localisatorService;
        }




        [HttpGet("/GetLocalisator/{Id}")]
        public IActionResult GetLocalisator(int Id)
        {
            Console.WriteLine("couche controller");
            return Ok(_localisatorService.GetLocalisator(Id));
            return null;
        }
    }
}
