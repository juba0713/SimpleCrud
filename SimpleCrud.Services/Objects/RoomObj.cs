using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Services.Objects
{
    public class RoomObj
    {

        public string? RoomId { get; set; }

        public string? RoomName { get; set; }

        public string? Location { get; set; }

        public string? Description { get; set; }

        public DateTime Updated_at { get; set; }

    }
}
