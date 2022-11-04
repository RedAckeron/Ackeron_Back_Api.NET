using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Ackeron_Back.Controllers
{

    [Route("ackeron/character/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        
        [HttpGet("/GetAll")]
        public IActionResult GetAll()
        {
            return null;
        }
        

        [HttpGet("/GetOne/{id}")]
        public IActionResult GetById(int id)
        {
        return Ok(_characterService.GetOneCharacter(id));
        }
        
        [HttpPost("/Add")]
        public IActionResult AddCharacter(Character c)
        {
            return Ok(_characterService.AddCharacter(c));
        }
        [HttpPut("/Update")]
        public IActionResult UpdateCharacter(Character c)
        {
            return Ok(_characterService.UpdateCharacter(c));
        }
    }
}
