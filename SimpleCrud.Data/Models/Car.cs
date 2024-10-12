using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Data.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string carName { get; set; }

        [Required]
        public required string carType { get; set; }

        [Required]
        public required string carBrand { get; set; }

        [Required]
        public required string carColor { get; set; }

        [Required]
        public DateTime DateCreated { get; private set; }

        public DateTime DateTUpdated { get; set; }

        public Car()
        {
            DateCreated = DateTime.Now;
        }
    }
}
