using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
namespace Ackeron_Back.Controllers
{

    [Route("ackeron/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
        /*
        [HttpGet]
        public IActionResult GetAll()
        {
            return null;
        }
        */

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Character c = new();
            
            Loc loc = new();


            c.Loc = loc;//on ajoute la loc a l objet char            
            return Ok(c);
           
        }
        
        [HttpPost]
        public IActionResult AddCharacter(Character c)
        {
            return Ok(_characterService.AddCharacter(c));
        }
    }
}
