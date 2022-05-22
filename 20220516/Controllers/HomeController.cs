﻿using _0516.Models;
using _0516.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace _0516.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly MyService _myService;

        public HomeController(ILogger<HomeController> logger, MyService myService)
        {
            _logger = logger;
            _myService = myService;
        }

        public IActionResult Index()
        {
            ViewData["_myService"] = _myService.getMyService;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}