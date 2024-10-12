using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCrud.Data.Models;
using SimpleCrud.Services.Objects;
using SimpleCrud.Services.ServiceModels;

namespace SimpleCrud.Services.Interfaces
{
    public interface IRoomService
    {

        void AddRoom(RoomModel model);

        void EditRoom(RoomModel model);

        void DeleteRoom(string roomId);

        (bool, Room?) GetRoomById(string roomId);

        IEnumerable<RoomObj> GetRooms();

    }
}
