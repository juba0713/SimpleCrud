using SimpleCrud.Data.Interfaces;
using SimpleCrud.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Data.Repositories
{
    public class StudentRepository : IStudentRepository 
    {
        private readonly SimpleCrudDbContext _context;

        public StudentRepository(SimpleCrudDbContext context)
        {
            _context = context;
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public bool StudentExists(string studentId)
        {
            throw new NotImplementedException();
        }
    }
}
