using SimpleCrud.Data.Interfaces;
using SimpleCrud.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Data.Repositories
{
    public class RoomRepository : IRoomRepository
    {

        private readonly SimpleCrudDbContext _context;

        public RoomRepository(SimpleCrudDbContext context)
        {
            _context = context;
        }

        public void AddRoom(Room room)
        {
            room.Created_at = DateTime.Now;

            _context.Rooms.Add(room);
            _context.SaveChanges();
        }

        public void DeleteRoom(string roomId)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id.ToString() == roomId);

            if (room == null)
            {
                throw new Exception("Room not found");
            }

            _context.Rooms.Remove(room);
            _context.SaveChanges();
        }

        public void EditRoom(Room room)
        {
            var existingRoom = _context.Rooms.FirstOrDefault(r => r.Id.ToString() == room.Id.ToString());

            if (existingRoom == null)
            {
                throw new Exception("Room not found");
            }

            existingRoom.RoomName = room.RoomName;
            existingRoom.Location = room.Location;
            existingRoom.Description = room.Description;
            existingRoom.Updated_at = DateTime.Now;

            _context.SaveChanges();
        }

        public Room getRoomById(string roomId)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id.ToString() == roomId);

            if (room == null)
            {
                throw new Exception("Room not found");
            }

            return room;
        }

        public IEnumerable<Room> GetRooms()
        {
            return _context.Rooms.ToList();
        }

        public bool RoomExists(string roomId)
        {
            return _context.Rooms.Any(r => r.Id.ToString() == roomId);
        }
    }
}
