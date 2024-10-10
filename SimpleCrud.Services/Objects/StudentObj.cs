using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Services.Objects
{
    public class StudentObj
    {
        public string? StudentId { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? FamilyName { get; set; }

        public string? Course { get; set; }

        public string? Year { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
