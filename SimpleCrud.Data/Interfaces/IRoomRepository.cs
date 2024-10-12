using SimpleCrud.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Data.Interfaces
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetRooms();

        bool RoomExists(string roomId);

        Room getRoomById(string roomId);

        void AddRoom(Room room);

        void EditRoom(Room room);

        void DeleteRoom(string roomId);
    }
}
