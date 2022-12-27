using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
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

        [HttpPut("/Localisator/Create/")]
        public IActionResult Create(Localisator Loc)
        {
            return Ok(_localisatorService.Create(Loc));
        }

        [HttpGet("/Localisator/Read/{Id}")]
        public IActionResult ReadLocalisator(int Id)
        {
            Console.WriteLine("couche controller");
            return Ok(_localisatorService.Read(Id));
        }

        [HttpPost("/Localisator/Update/{Id}")]
        public IActionResult Update(int Id)
        {
            return null;
        }

        [HttpDelete("/Localisator/Delete/{Id}")]
        public IActionResult Delete(int Id)
        {
            return null;
        }
    }
}
