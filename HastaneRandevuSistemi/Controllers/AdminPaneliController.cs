﻿using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class AdminPaneliController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
