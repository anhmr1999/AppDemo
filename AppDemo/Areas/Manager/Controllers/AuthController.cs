using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace AppDemo.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class AuthController : Controller
    {
        [Route("/admin/login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/admin/forgot-password")]
        public IActionResult Forgot()
        {
            return View();
        }
    }
}
