using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers
{
    [Route("/[controller]/")]
    [ApiController]
    public class InventoryController :ControllerBase
    {

        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
            {
            _inventoryService = inventoryService;
            }

            [HttpPost("Add")]
            public IActionResult Add(int IdItem,int IdChar,int Qt)
            {
                return Ok(_inventoryService.Add(IdItem, IdChar, Qt));
            }
            [HttpGet("Get/{IdChar}")]
            public IActionResult Get(int IdChar)
            {
                return Ok(_inventoryService.Get(IdChar));
            }

    }
}
