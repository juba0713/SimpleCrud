using Microsoft.AspNetCore.Mvc;
using SimpleCrud.Data.Models;
using SimpleCrud.Services.Interfaces;

namespace SimpleCrud.WebApp.Controllers
{
    public class MotorcycleController : Controller
    {
        private readonly IMotorcycleService _motorcycleService;

        public MotorcycleController(IMotorcycleService motorcycleService)
        {
            _motorcycleService = motorcycleService;
        }
        public IActionResult Index()
        {
            IEnumerable<Motorcycle> motorcycles = _motorcycleService.GetMotorcycles().ToList();
            return View(motorcycles);
        }
        public IActionResult AddMotorcycle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMotorcycle(Motorcycle motorcycle)
        {
            if (ModelState.IsValid)
            {
                _motorcycleService.AddMotorcycle(motorcycle);
                return RedirectToAction("Index");
            }
            return View(motorcycle);
        }

        public IActionResult UpdateMotorcycle(int id)
        {
            Motorcycle? motorcycle = _motorcycleService.GetMotorcycle(id);

            if (motorcycle == null)
            {
                return NotFound();
            }
            return View(motorcycle);
        }

        [HttpPost]
        public IActionResult UpdateMotorcycle(Motorcycle motorcycle)
        {
            if (ModelState.IsValid)
            {
                _motorcycleService.UpdateMotorcycle(motorcycle);
                return RedirectToAction("Index");
            }
            return View(motorcycle);
        }

        public IActionResult DeleteMotorcycle(int id)
        {
            _motorcycleService.DeleteMotorcycle(id);
            return RedirectToAction("Index");
        }
    }
}
