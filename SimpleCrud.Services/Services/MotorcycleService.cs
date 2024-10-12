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
    public class MotorcycleService : IMotorcycleService
    {
        private readonly IMotorcycleRepository _repository;
        
        public MotorcycleService(IMotorcycleRepository repository)
        {
            _repository = repository;
        }
        public void AddMotorcycle(Motorcycle motorcycle)
        {
            _repository.AddMotorcycle(motorcycle);
        }
        public void DeleteMotorcycle(int motorcycleId)
        {
            _repository.DeleteMotorcycle(motorcycleId);
        }
        public IEnumerable<Motorcycle> GetMotorcycles()
        {
            return _repository.GetMotorcycles().ToList();
        }
        public Motorcycle? GetMotorcycle(int motorcycleId)
        {
            return _repository.GetMotorcycle(motorcycleId);
        }
        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            _repository.UpdateMotorcycle(motorcycle);
        }
    }
}
