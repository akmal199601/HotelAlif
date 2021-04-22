using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.IO;
using System.Threading.Tasks;
using HotelAlif.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace HotelAlif.Controllers
{
    public class AdminController : Controller
    {
        private HotelAlifContext context;

        public AdminController(HotelAlifContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
             return View();
        }
    }
}

