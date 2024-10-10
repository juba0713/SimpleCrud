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
