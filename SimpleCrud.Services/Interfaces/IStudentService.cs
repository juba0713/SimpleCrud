using SimpleCrud.Data.Models;
using SimpleCrud.Services.Objects;
using SimpleCrud.Services.ServiceModels;


namespace SimpleCrud.Services.Interfaces
{
    public interface IStudentService
    {
        void AddStudent(StudentModel model);

        void EditStudent(StudentModel model);

        void DeleteStudent(string studentId); 

        (bool, Student?) GetStudentById(string studentId);

        IEnumerable<StudentObj> GetStudents();
    }
}
