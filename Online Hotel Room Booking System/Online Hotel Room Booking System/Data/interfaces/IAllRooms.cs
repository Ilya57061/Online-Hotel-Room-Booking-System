﻿using Online_Hotel_Room_Booking_System.Data.Models;
using System.Collections.Generic;

namespace Online_Hotel_Room_Booking_System.Data.interfaces
{
    public interface IAllRooms
    {   
        IEnumerable<Room> Rooms { get; }
        Room GetRoom(int idRoom);
    }
}
