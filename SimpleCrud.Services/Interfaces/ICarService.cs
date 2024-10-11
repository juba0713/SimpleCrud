using SimpleCrud.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Services.Interfaces
{
    public interface ICarService
    {
        void AddCar(Car car);
        void DeleteCar(int carId);
        IEnumerable<Car> GetCars();
        Car? GetCar(int carId);
        void UpdateCar(Car car);
    }
}
