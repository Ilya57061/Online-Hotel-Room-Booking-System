using Online_Hotel_Room_Booking_System.Data.Models;
using Online_Hotel_Room_Booking_System.Data.mocks;
using Online_Hotel_Room_Booking_System.Data;
using System.Collections.Generic;

namespace Online_Hotel_Room_Booking_System.ViewsModels
{
    public class RoomsListViewModel
    {
       
        public IEnumerable<Room> getAllRooms { get; set; }
        public Room Room { get; set; }
     

    }
}
