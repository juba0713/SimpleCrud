using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SimpleCrud.Data.Interfaces;
using SimpleCrud.Data.Models;
using SimpleCrud.Services.Objects;
using SimpleCrud.Services.Interfaces;
using SimpleCrud.Services.ServiceModels;

namespace SimpleCrud.Services.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public void AddRoom(RoomModel model)
        {
            var room = new Room
            {
                RoomName = model.RoomName,
                Location = model.Location,
                Description = model.Description,
                Created_at = DateTime.Now
            };

            _roomRepository.AddRoom(room);
        }

        public void DeleteRoom(string roomId)
        {
            _roomRepository.DeleteRoom(roomId);
        }

        public void EditRoom(RoomModel model)
        {
            if (string.IsNullOrWhiteSpace(model.RoomId))
            {
                throw new ArgumentException("RoomId cannot be null or empty", nameof(model.RoomId));
            }

            var room = new Room
            {
                Id = int.Parse(model.RoomId),
                RoomName = model.RoomName,
                Location = model.Location,
                Description = model.Description,
                Updated_at = DateTime.Now
            };

            _roomRepository.EditRoom(room);
        }

        public (bool, Room?) GetRoomById(string roomId)
        {
            var room = _roomRepository.getRoomById(roomId);

            if (room == null)
            {
                return (false, room);
            }

            return (true, room);
        }

        public IEnumerable<RoomObj> GetRooms()
        {
            var rooms = _roomRepository.GetRooms();

            if (!rooms.Any())
            {
                return new List<RoomObj>();
            }

            var roomObjs = rooms.Select(r => new RoomObj
            {
                RoomId = r.Id.ToString(),
                RoomName = r.RoomName,
                Location = r.Location,
                Description = r.Description,
                Updated_at = r.Updated_at
            });

            return roomObjs;
        }
    }
}