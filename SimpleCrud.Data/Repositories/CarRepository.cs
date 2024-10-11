using SimpleCrud.Data.Interfaces;
using SimpleCrud.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Data.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly SimpleCrudDbContext _context;

        public CarRepository(SimpleCrudDbContext context)
        {
            _context = context;
        }

        public void AddCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }
        public void DeleteCar(int carId)
        {
            var car = _context.Cars.FirstOrDefault(c => c.Id == carId);
            if (car != null)
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }
        public IEnumerable<Car> GetCars()
        {
            return _context.Cars.ToList();
        }
        public Car? GetCar(int carId)
        {
            return this._context.Cars.FirstOrDefault(c => c.Id == carId);
        }
        public void UpdateCar(Car car)
        {
            var existingCar = this._context.Cars.FirstOrDefault(c => c.Id == car.Id);
            if (existingCar != null)
            {
                existingCar.carName = car.carName;
                _context.SaveChanges();
            }
        }
    }
}
