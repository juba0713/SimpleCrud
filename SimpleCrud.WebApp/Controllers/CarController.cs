using Microsoft.AspNetCore.Mvc;
using SimpleCrud.Data.Models;
using SimpleCrud.Services.Interfaces;

namespace SimpleCrud.WebApp.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            IEnumerable<Car> cars = _carService.GetCars().ToList();
            return View(cars);
        }

        public IActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.AddCar(car);
                return RedirectToAction("Index");
            }
            return View(car);
        }

        public IActionResult UpdateCar(int id)
        {
            Car? car = _carService.GetCar(id);

            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        [HttpPost]
        public IActionResult UpdateCar(Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.UpdateCar(car);
                return RedirectToAction("Index");
            }
            return View(car);
        }

        public IActionResult DeleteCar(int id)
        {
            _carService.DeleteCar(id);
            return RedirectToAction("Index");
        }
    }
}
