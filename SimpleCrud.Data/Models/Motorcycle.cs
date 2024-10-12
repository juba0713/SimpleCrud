using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Data.Models
{
    public class Motorcycle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Brand { get; set; }
        [Required]
        public required string Model { get; set; }
        [Required]
        public required string Color { get; set; }
        [Required]
        public DateTime Created_at { get; }
        public DateTime Updated_at;

    }
}
