using SimpleCrud.Data.Interfaces;
using SimpleCrud.Data.Models;
using SimpleCrud.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Data.Repositories
{
    public class MotorcycleRepository : IMotorcycleRepository
    {
        private readonly SimpleCrudDbContext _context;

        public MotorcycleRepository(SimpleCrudDbContext context)
        {
            _context = context;
        }

        public void AddMotorcycle(Motorcycle motorcycle)
        {
            _context.Motorcycles.Add(motorcycle);
            _context.SaveChanges();
        }

        public void DeleteMotorcycle(int motorcycleId)
        {
            var motorcycle = _context.Motorcycles.FirstOrDefault(c => c.Id == motorcycleId);
            if (motorcycle != null)
            {
                _context.Motorcycles.Remove(motorcycle);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Motorcycle> GetMotorcycles()
        {
            return _context.Motorcycles.ToList();
        }

        public Motorcycle? GetMotorcycle(int motorcycleid)
        {
            return this._context.Motorcycles.FirstOrDefault(c => c.Id == motorcycleid);
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            var existingMotorcycle = this._context.Motorcycles.FirstOrDefault(c => c.Id == motorcycle.Id);
            if (existingMotorcycle != null)
            {
                existingMotorcycle.Brand = motorcycle.Brand;
                existingMotorcycle.Model = motorcycle.Model;
                existingMotorcycle.Color = motorcycle.Color;
                _context.SaveChanges();
            }
        }

    }
}
