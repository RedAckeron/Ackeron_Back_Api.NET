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

            return Ok(_localisatorService.Read(Id));
        }

        [HttpPut("/Localisator/Update")]
        public IActionResult Update(Localisator Loc)
        {
            return Ok(_localisatorService.Update(Loc));
        }

        [HttpDelete("/Localisator/Delete/{Id}")]
        public IActionResult Delete(int Id)
        {
            return null;
        }
        
    }
}
