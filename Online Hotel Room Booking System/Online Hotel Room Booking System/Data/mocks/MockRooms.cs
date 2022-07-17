using Online_Hotel_Room_Booking_System.Data.interfaces;
using Online_Hotel_Room_Booking_System.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Online_Hotel_Room_Booking_System.Data.mocks
{
    public class MockRooms : IAllRooms
    {
        private AppDB db = new AppDB();
        public IEnumerable<Room> Rooms
        {
            get
            {
                return db.GetRoom();
            }
        }

        public Room GetRoom(int idRoom)
        {
            return Rooms.ToList()[idRoom-1];
        }
    }
}
