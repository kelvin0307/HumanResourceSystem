using Microsoft.AspNetCore.Mvc;

namespace HumanResourceSystem.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
