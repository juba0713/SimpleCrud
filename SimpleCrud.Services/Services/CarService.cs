using SimpleCrud.Data.Interfaces;
using SimpleCrud.Data.Models;
using SimpleCrud.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Services.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;
        public CarService(ICarRepository repository)
        {
            _repository = repository;
        }
        public void AddCar(Car car)
        {
            _repository.AddCar(car);
        }
        public void DeleteCar(int carId)
        {
            _repository.DeleteCar(carId);
        }
        public IEnumerable<Car> GetCars()
        {
            return _repository.GetCars().ToList();
        }
        public Car? GetCar(int carId)
        {
            return _repository.GetCar(carId);
        }
        public void UpdateCar(Car car)
        {
            _repository.UpdateCar(car);
        }
    }
}
