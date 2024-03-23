using Microsoft.AspNetCore.Mvc;

namespace AppDemo.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
