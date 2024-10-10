using SimpleCrud.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Data.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        bool StudentExists(string studentId);
        void AddStudent(Student user);
    }
}
