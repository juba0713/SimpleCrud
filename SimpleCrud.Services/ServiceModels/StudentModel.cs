using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Services.ServiceModels
{
    public class StudentModel
    {

        public string? StudentId { get; set; }

        [Required(ErrorMessage = "First Name is required!")]
        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "Family Name is required!")]
        public string? FamilyName { get; set; }

        [Required(ErrorMessage = "Course is required!")]
        public string? Course { get; set; }

        [Required(ErrorMessage = "Year is required!")]
        public string? Year { get; set; }
    }
}
