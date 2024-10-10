    using SimpleCrud.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace SimpleCrud.Services.Interfaces
    {
        public interface IUserService
        {
            void AddUser(User user);
            void DeleteUser(int userId);
            IEnumerable<User> GetUsers();
            User? GetUser(int userId);
            void UpdateUser(User user);
        }
    }

