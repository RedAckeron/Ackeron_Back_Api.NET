using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_characterService.GetCharacter(id));
           
        }
        */
        [HttpPost]
        public IActionResult AddCharacter(Character c)
        {
            return Ok(_characterService.AddCharacter(c));
        }
    }
}
