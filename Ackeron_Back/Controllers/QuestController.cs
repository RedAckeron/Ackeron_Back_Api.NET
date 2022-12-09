using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Ackeron_Back.Controllers
{
    [Route("ackeron/map/[controller]")]
    [ApiController]
    public class QuestController : Controller
    {
        private readonly IQuestService _questService;
        public QuestController(IQuestService questservice)
        {
            _questService = questservice;
        }


        [HttpGet("/GetCharacterAllQuest/{IdChar}")]
        public IActionResult GetCharacterAllQuest(int IdChar)
        {
            Console.WriteLine("couche controller");
            return Ok(_questService.GetCharacterAllQuest(IdChar));
        }

    }
}