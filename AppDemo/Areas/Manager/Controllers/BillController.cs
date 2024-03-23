using Microsoft.AspNetCore.Mvc;

namespace AppDemo.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class BillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
