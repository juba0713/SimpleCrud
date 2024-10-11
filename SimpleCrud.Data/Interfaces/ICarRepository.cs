using SimpleCrud.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Data.Interfaces
{
    public interface ICarRepository
    {
        void AddCar(Car car);
        void DeleteCar(int carId);
        IEnumerable<Car> GetCars();
        Car? GetCar(int carId);
        void UpdateCar(Car car);
    }
}
