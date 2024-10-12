using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Data.Models
{
    public class Room
    {
        public int Id { get; set; }

        public string? RoomName { get; set; }

        public string? Location { get; set; }

        public string? Description { get; set; }

        public DateTime Created_at { get; set; } = DateTime.Now;

        public DateTime Updated_at { get; set; } = DateTime.Now;
    }
}
