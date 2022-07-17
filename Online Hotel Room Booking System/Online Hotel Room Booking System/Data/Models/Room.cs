namespace Online_Hotel_Room_Booking_System.Data.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public ushort Price { get; set; }
        public string Desc { get; set; }
        public string Img { get; set; }
        public bool Accessed { get; set; }
        public int IdRoomCategory { get; set; }

    }
}
