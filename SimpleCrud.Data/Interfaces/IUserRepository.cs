using SimpleCrud.Data.Models;
using System.Collections.Generic;

namespace SimpleCrud.Data.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void DeleteUser(int userId);
        IEnumerable<User> GetUsers();
        User? GetUser(int userId);
        void UpdateUser(User user);
    }
}
