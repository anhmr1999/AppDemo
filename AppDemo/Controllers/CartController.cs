using Microsoft.AspNetCore.Mvc;

namespace AppDemo.Controllers
{
    [Route("cart-view")]
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View("ViewContent");
        }
    }
}
