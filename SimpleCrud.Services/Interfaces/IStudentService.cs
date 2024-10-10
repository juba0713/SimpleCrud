using SimpleCrud.Services.Objects;
using SimpleCrud.Services.ServiceModels;


namespace SimpleCrud.Services.Interfaces
{
    public interface IStudentService
    {
        void AddStudent(StudentModel model);

        IEnumerable<StudentObj> GetStudents();
    }
}
