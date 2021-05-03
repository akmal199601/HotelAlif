using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotelAlif.Models;

namespace HotelAlif.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult gallery()
        {
            return View();
        }
        public IActionResult book()
        {
            return View();
        }
        public IActionResult single()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
        public IActionResult about()
        {
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
