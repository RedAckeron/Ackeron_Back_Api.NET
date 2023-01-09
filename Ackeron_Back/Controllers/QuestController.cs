using BLL.Interfaces;
using BLL.Services;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Ackeron_Back.Controllers
{
    [Route("ackeron/Quest/[controller]")]
    [ApiController]
    public class QuestController : Controller
    {
        private readonly IQuestService _questService;
        public QuestController(IQuestService questservice)
        {
            _questService = questservice;
        }

        [HttpPost("/Create")]
        public IActionResult Create(Quest quest)
        {
            return Ok(_questService.Create(quest));
        }
       
        [HttpGet("/GetCharacterAllQuest/{IdChar}")]
        public IActionResult GetCharacterAllQuest(int IdChar)
        {
            return Ok(_questService.GetCharacterAllQuest(IdChar));
        }

    }
}