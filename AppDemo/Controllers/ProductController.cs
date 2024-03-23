using Microsoft.AspNetCore.Mvc;

namespace AppDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
