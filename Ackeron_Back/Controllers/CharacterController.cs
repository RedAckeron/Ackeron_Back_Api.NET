using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using DAL.Models;
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

        [HttpGet("/Character/GetOne/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_characterService.GetOneCharacter(id));
        }

        [HttpGet("/Character/GetLocalisator/{id}")]
        public IActionResult GetLocalisator(int id)
        {
            return Ok(_characterService.GetLocalisator(id));
        }
        
        [HttpPut("/Character/UpdateLocalisator/{id}")]
        public IActionResult UpdateLocalisator(int Id,Localisator Loc)
        {
            
            return Ok(_characterService.UpdateLocalisator(Id,Loc));
        }

        [HttpPost("/Character/Add")]
        public IActionResult AddCharacter(Character c)
        {
            return Ok(_characterService.AddCharacter(c));
        }

        [HttpPut("/Character/Update/{id}")]
        public IActionResult UpdateCharacter(Character c)
        {
            return Ok(_characterService.UpdateCharacter(c));
        }
    }
}
