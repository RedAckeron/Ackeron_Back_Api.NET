using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers.Character
{
    [Route("ackeron/[controller]")]
    [ApiController]
    public class MobController : Controller
    {
        private readonly IMobService _mobService;
        public MobController(IMobService mobService)
        {
            _mobService = mobService;
        }


        [HttpPost("/Mob/Create")]
        public IActionResult Create(Mob m)
        {
            return Ok(_mobService.Create(m));
        }

        [HttpGet("/Mob/Read/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_mobService.Read(id));
        }

        [HttpGet("/Mob/ReadAllOfPlanet/{id}")]
        public IActionResult ReadAllOfPlanet(int id)
        {
            return Ok(_mobService.ReadAllOfPlanet(id));
        }

        [HttpPut("/Mob/Update/{id}")]
        public IActionResult Update(Mob M)
        {
            return Ok(_mobService.Update(M));
        }

        [HttpDelete("/Mob/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_mobService.Delete(id));
        }
    }
}
