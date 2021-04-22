using System.Threading.Tasks;
using HotelAlif.Context;
using HotelAlif.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelAlif.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoomController : Controller
    {
        private HotelAlifContext context;

        public RoomController(HotelAlifContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            var li = await context.Rooms.ToListAsync();
            return View(li);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Room model)
        {
            if (ModelState.IsValid)
            {
                context.Rooms.Add(model);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet("edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
                return RedirectToAction("Index");
            var model = await context.Rooms.FirstAsync(p => p.Id == id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditRoom(Room model)
        {
            if (ModelState.IsValid)
            {
                context.Rooms.Update(model);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit");
        }
        [HttpGet("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id != 0)
            {
                var model = await context.Rooms.FirstAsync(p => p.Id == id);
                context.Rooms.Remove(model);
                await context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}