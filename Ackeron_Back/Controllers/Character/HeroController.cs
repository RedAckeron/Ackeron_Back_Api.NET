using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers.Character
{
    [Route("/[controller]")]
    [ApiController]
    public class HeroController : Controller
    {
        private readonly IHeroService _heroService;
        public HeroController(IHeroService heroService)
        {
            _heroService = heroService;
        }

        [HttpPost("Create")]
        public IActionResult Create(Hero hero)
        {
        return Ok(_heroService.Create(hero));
        }

        [HttpPost("Read")]
        public IActionResult Read(int id)
        {
            return Ok(_heroService.Read(id));
        }
    }
}