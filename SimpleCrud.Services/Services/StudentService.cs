using AutoMapper;
using SimpleCrud.Data.Interfaces;
using SimpleCrud.Data.Models;
using SimpleCrud.Services.Objects;
using SimpleCrud.Services.Interfaces;
using SimpleCrud.Services.ServiceModels;


namespace SimpleCrud.Services.Services
{
    public class StudentService : IStudentService
    {

        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public void AddStudent(StudentModel model)
        {
            var student = new Student();

            _mapper.Map(model, student);
            student.CreateDate = DateTime.Now;
            student.UpdateDate = DateTime.Now;
 
            _studentRepository.AddStudent(student);
        }

        public void DeleteStudent(string studentId)
        {
            _studentRepository.DeleteStudent(studentId);
        }

        public void EditStudent(StudentModel model)
        {
            var student = new Student
            {
                StudentId = model.StudentId,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                FamilyName = model.FamilyName,
                Course = model.Course,
                Year = model.Year,
                UpdateDate = DateTime.Now
            };

            _studentRepository.EditStudent(student);
        }

        public (bool, Student?) GetStudentById(string studentId)
        {
            var student = _studentRepository.getStudentById(studentId);

            if(student  == null)
            {
                return (false, student);
            }

            return (true, student);
        }

        public IEnumerable<StudentObj> GetStudents()
        {

            var students = _studentRepository.GetStudents();

            if (!students.Any())
            {
                return new List<StudentObj>();
            }

            // Mapping Student to StudentObj
            var studentObjs = students.Select(s => new StudentObj
            {
                StudentId = s.StudentId,
                FirstName = s.FirstName,
                MiddleName = s.MiddleName,
                FamilyName = s.FamilyName,
                Course = s.Course,
                Year = s.Year,
                UpdateDate = s.UpdateDate
            });

            return studentObjs;
        }
    }
}
