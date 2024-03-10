using Microsoft.AspNetCore.Mvc;

namespace AppDemo.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
