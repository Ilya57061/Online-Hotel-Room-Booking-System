using System.Collections.Generic;

namespace Online_Hotel_Room_Booking_System.Data.Models
{
    public class RoomCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Desc { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
