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
            Console.WriteLine(model.Course);
            _studentService.AddStudent(model);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(StudentModel model)
        {

            _studentService.EditStudent(model);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(string studentId)
        {

            _studentService.DeleteStudent(studentId);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetStudentById(string studentId)
        {
            var (result, student) = _studentService.GetStudentById(studentId);

            if (!result)
            {
                return NotFound();
            }
            Console.WriteLine("Course: " + student.Course);
            // Return student data as JSON
            return Json(new
            {
                studentId = student.StudentId,
                firstName = student.FirstName,
                middleName = student.MiddleName,
                familyName = student.FamilyName,
                course = student.Course,
                year = student.Year
            });
        }
    }
}
