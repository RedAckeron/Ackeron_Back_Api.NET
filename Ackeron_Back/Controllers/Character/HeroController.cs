using BLL.Interfaces;
using BLL.Services;
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

        [HttpGet("Read/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_heroService.Read(id));
        }

        [HttpPut("Move")]
        public IActionResult Move(int idchar,char orientation)
        {
            Console.WriteLine("IdChar:"+idchar+" Orientation:"+orientation);
            return Ok(_heroService.Move(idchar,orientation));
        }
    }
}