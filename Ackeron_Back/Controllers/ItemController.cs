using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers
{
    [Route("ackeron/item/[controller]")]
    [ApiController]

    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost("/AddItem")]
        public IActionResult AddItem(Item item)
        {
            return Ok(_itemService.AddItem(item));
        }

        [HttpGet("/GetItem/{id}")]
        public IActionResult GetItem(int id)
        {
            return Ok(_itemService.GetItem(id));
        }

    }
       
       
}
