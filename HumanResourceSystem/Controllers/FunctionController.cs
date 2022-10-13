using Microsoft.AspNetCore.Mvc;

namespace HumanResourceSystem.Controllers
{
    public class FunctionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
