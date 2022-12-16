using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers
{
    [Route("ackeron/Localisator/[controller]")]
    [ApiController]
    public class LocalisatorController : Controller
    {
        private readonly ILocalisatorService _localisatorService;

        public LocalisatorController(ILocalisatorService localisatorService)
        {
            _localisatorService = localisatorService;
        }

        [HttpPut("/Localisator/Create/{Id}")]
        public IActionResult CreateLocalisator(int Id)
        {
            return null;
        }

        [HttpGet("/Localisator/Read/{Id}")]
        public IActionResult ReadLocalisator(int Id)
        {
            Console.WriteLine("couche controller");
            return Ok(_localisatorService.ReadLocalisator(Id));
        }

        [HttpPost("/Localisator/Update/{Id}")]
        public IActionResult UpdateLocalisator(int Id)
        {
            return null;
        }

        [HttpDelete("/Localisator/Delete/{Id}")]
        public IActionResult DeleteLocalisator(int Id)
        {
            return null;
        }
    }
}
