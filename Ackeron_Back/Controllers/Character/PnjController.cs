using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers.Character
{
    public class PnjController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
