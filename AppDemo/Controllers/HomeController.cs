﻿using Microsoft.AspNetCore.Mvc;

namespace AppDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
