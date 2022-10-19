using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers
{

    [Route("ackeron/[controller]")]
    [ApiController]
    public class character : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return null;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return null;
        }
    }
}
