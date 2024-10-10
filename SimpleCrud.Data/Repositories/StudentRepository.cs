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
        private readonly Group7CRUDDbContext _context;

        public StudentRepository(Group7CRUDDbContext context)
        {
            _context = context;
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void DeleteStudent(string studentId)
        {
            var student = _context.Students.FirstOrDefault(s => s.StudentId.Equals(studentId));

            if (student == null)
            {
                throw new Exception("Student not found");
            }

            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public void EditStudent(Student user)
        {
            var existingStudent = _context.Students.FirstOrDefault(s => s.StudentId.Equals(user.StudentId));

            if (existingStudent == null)
            {
                throw new Exception("Student not found");
            }

            existingStudent.FirstName = user.FirstName;
            existingStudent.MiddleName = user.MiddleName;
            existingStudent.FamilyName = user.FamilyName;
            existingStudent.Course = user.Course;
            existingStudent.Year = user.Year;
            existingStudent.UpdateDate = user.UpdateDate;

            _context.SaveChanges();
        }

        public Student getStudentById(string studentId)
        {
            var student = _context.Students.FirstOrDefault(s => s.StudentId.Equals(studentId));

            if (student == null)
            {
                throw new Exception("Student not found");
            }

            return student;
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
