using Microsoft.AspNetCore.Mvc;

namespace Ackeron_Back.Controllers.Character
{
    public class HeroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
