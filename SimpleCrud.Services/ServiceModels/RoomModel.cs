using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Services.ServiceModels
{
    public class RoomModel
    {

        public string? RoomId { get; set; }

        [Required(ErrorMessage = "Room Name is required!")]
        public string? RoomName { get; set; }

        [Required(ErrorMessage = "Location is required!")]
        public string? Location { get; set; }
        public string? Description { get; set; }


    }
}
