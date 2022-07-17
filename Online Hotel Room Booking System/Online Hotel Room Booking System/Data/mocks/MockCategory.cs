using Online_Hotel_Room_Booking_System.Data.interfaces;
using Online_Hotel_Room_Booking_System.Data.Models;
using System.Collections.Generic;

namespace Online_Hotel_Room_Booking_System.Data.mocks
{
    public class MockCategory : IRoomsCategory
    {
        AppDB db = new AppDB();
        public IEnumerable<RoomCategory> RoomCategories
        {
            get
            {
                return db.GetCategory();
            }
        }
   
    }
}
