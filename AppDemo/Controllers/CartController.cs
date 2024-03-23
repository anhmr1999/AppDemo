using Microsoft.AspNetCore.Mvc;

namespace AppDemo.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
