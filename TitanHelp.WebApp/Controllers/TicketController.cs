﻿using Microsoft.AspNetCore.Mvc;

namespace TitanHelp.WebApp.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
