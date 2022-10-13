using Microsoft.AspNetCore.Mvc;

namespace HumanResourceSystem.Controllers
{
    public class DaysOffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
