using SimpleCrud.Data.Interfaces;
using SimpleCrud.Data.Models;
using SimpleCrud.Services.Objects;
using SimpleCrud.Services.Interfaces;
using SimpleCrud.Services.ServiceModels;

namespace SimpleCrud.Services.Services
{   
    public class UserService : IUserService
        {
            private readonly IUserRepository _repository;
            public UserService(IUserRepository repository)
            {
                _repository = repository;
            }
            public void AddUser(User user)
            {
                _repository.AddUser(user);
            }
            public void DeleteUser(int userId)
            {
                _repository.DeleteUser(userId);
            }
            public IEnumerable<User> GetUsers()
            {
                return _repository.GetUsers().ToList();
            }
            public User? GetUser(int userId)
            {
                return _repository.GetUser(userId);
            }
            public void UpdateUser(User user)
            {
                _repository.UpdateUser(user);
            }
        }
}