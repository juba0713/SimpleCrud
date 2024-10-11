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
    public class UserRepository : IUserRepository
    {
        private readonly SimpleCrudDbContext _context;

        public UserRepository(SimpleCrudDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public void DeleteUser(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }
        public User? GetUser(int userId)
        {
            return _context.Users.FirstOrDefault(u => u.Id == userId);
        }
        public void UpdateUser(User user)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                existingUser.Phone = user.Phone;
                existingUser.Address = user.Address;

                _context.SaveChanges();
            }
        }
    }
}
