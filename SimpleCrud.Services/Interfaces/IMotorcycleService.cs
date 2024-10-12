using SimpleCrud.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Services.Interfaces
{
    public interface IMotorcycleService
    {
        void AddMotorcycle(Motorcycle motorcycle);
        void DeleteMotorcycle(int motorcycleId);
        IEnumerable<Motorcycle> GetMotorcycles();
        Motorcycle? GetMotorcycle(int motorcycleId);
        void UpdateMotorcycle(Motorcycle motorcycle);
    }
}
