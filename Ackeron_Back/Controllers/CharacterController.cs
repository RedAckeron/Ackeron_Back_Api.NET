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

        /*
        [HttpGet("/GetAll")]
        public IActionResult GetAll()
        {
            return null;
        }
        */

        [HttpGet("/Character/GetOne/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_characterService.GetOneCharacter(id));
        }

        [HttpGet("/Character/GetLoc/{id}")]
        public IActionResult GetCharacterLoc(int id)
        {
            return Ok(_characterService.GetCharacterLoc(id));
        }
        
        [HttpPut("/Character/UpdateLoc/{id}")]
        public IActionResult UpdateCharacterLoc(CharacterLoc CLoc)
        {
            Console.WriteLine("Mise a jours de la position du char "+CLoc.IdChar+":"+CLoc.LocP+" - "+CLoc.LocA_X+"/"+CLoc.LocA_Y);
            return Ok(_characterService.UpdateCharacterLoc(CLoc));
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
