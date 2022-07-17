using Microsoft.AspNetCore.Mvc;
using Online_Hotel_Room_Booking_System.Data.interfaces;
using Online_Hotel_Room_Booking_System.Data.Models;
using Online_Hotel_Room_Booking_System.ViewsModels;

namespace Online_Hotel_Room_Booking_System.Controllers
{
    public class RoomsController : Controller
    {
        private readonly IAllRooms _allRooms;
        private readonly IRoomsCategory _roomsCategories;
        public RoomsController(IAllRooms allRooms, IRoomsCategory roomsCategories)
        {
            _allRooms = allRooms;
            _roomsCategories = roomsCategories;
        }
        public ActionResult Booking(int id)
        {
            ViewBag.Id = id;
            RoomsListViewModel obj = new RoomsListViewModel();
            obj.Room = _allRooms.GetRoom(id);
            return View(obj);
        }
     

        public ViewResult ListRooms()
        {
            ViewBag.Title = "Доступные номера";
            RoomsListViewModel obj = new RoomsListViewModel();
            obj.getAllRooms = _allRooms.Rooms;
            return View(obj);
        }
    }
}
