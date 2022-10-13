using Microsoft.AspNetCore.Mvc;

namespace HumanResourceSystem.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
