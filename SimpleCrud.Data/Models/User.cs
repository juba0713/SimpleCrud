using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Email { get; set; }
        [Required]
        public required int Phone { get; set; }
        [Required]
        public required string Address { get; set; }
        [Required]
        public DateTime DateCreated { get; }

        public DateTime DateTUpdated;
    }
}
