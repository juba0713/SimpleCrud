using SimpleCrud.Data.Models;
using SimpleCrud.Services.Interfaces;
using SimpleCrud.Services.ServiceModels;
using SimpleCrud.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCrud.WebApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var students = _studentService.GetStudents();

            var viewModel = new StudentViewModel
            {
                Students = students
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(StudentModel model)
        {

            _studentService.AddStudent(model);

            return RedirectToAction("Index");
        }
    }
}
