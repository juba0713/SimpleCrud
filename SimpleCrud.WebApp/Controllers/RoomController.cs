using SimpleCrud.Data.Models;
using SimpleCrud.Services.Interfaces;
using SimpleCrud.Services.ServiceModels;
using SimpleCrud.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCrud.WebApp.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var rooms = _roomService.GetRooms();

            var viewModel = new RoomViewModel
            {
                Rooms = rooms
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(RoomModel model)
        {
            if (ModelState.IsValid)
            {
                _roomService.AddRoom(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(RoomModel model)
        {
            if (ModelState.IsValid)
            {
                _roomService.EditRoom(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(string roomId)
        {
            _roomService.DeleteRoom(roomId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetRoomById(string roomId)
        {
            var (result, room) = _roomService.GetRoomById(roomId);

            if (!result || room == null)
            {
                return NotFound();
            }

            return Json(new
            {
                roomId = room.Id.ToString(),
                roomName = room.RoomName,
                location = room.Location,
                description = room.Description,
                updatedAt = room.Updated_at
            });
        }
    }
}
