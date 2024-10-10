using AutoMapper;
using SimpleCrud.Data.Models;
using SimpleCrud.Services.ServiceModels;

namespace SimpleCrud.WebApp
{
    public class Program : Profile
    {
        public Program()
        {
            // Define the mapping from StudentModel to Student
            CreateMap<StudentModel, Student>();
        }
    }
}
