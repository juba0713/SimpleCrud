using SimpleCrud.Services.Objects;

namespace SimpleCrud.WebApp.Models
{
    public class RoomViewModel
    {
        public IEnumerable<RoomObj> Rooms { get; set; } = new List<RoomObj>();
    }
}
