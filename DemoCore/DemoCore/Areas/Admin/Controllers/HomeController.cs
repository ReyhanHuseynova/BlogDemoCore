﻿using Microsoft.AspNetCore.Mvc;

namespace DemoCore.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
