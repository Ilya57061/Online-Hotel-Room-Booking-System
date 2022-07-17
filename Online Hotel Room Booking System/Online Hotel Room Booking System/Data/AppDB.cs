using Microsoft.Data.SqlClient;
using Online_Hotel_Room_Booking_System.Data.Models;
using System;
using System.Collections.Generic;

namespace Online_Hotel_Room_Booking_System.Data
{
    public class AppDB
    {
        private string _connectString = "Server=localhost\\SQLEXPRESS;Database=Hotel;trusted_connection=true; Encrypt=False;TrustServerCertificate=False";

        public IEnumerable<Room> GetRoom()
        {
            List<Room> rooms = new List<Room>();
            using (SqlConnection con = new(_connectString))
            {
                string getRooms = "select * from Room";
                SqlCommand cmd = new SqlCommand(getRooms, con);
                con.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    rooms.Add(new Room
                    {
                        Id = (int)dataReader["Id"],
                        Number = (int)dataReader["Number"],
                        Price = (ushort)((decimal)dataReader["Price"]),
                        Desc = (string)dataReader["Desc"],
                        Accessed = (bool)dataReader["Accessed"],
                        IdRoomCategory = (int)dataReader["RoomCategory"],
                        Img = (string)dataReader["Img"]
                    });
                }
                con.Close();
            }
            return rooms;
        }
        public IEnumerable<RoomCategory> GetCategory()
        {
            List<RoomCategory> roomCategories = new List<RoomCategory>();
            using (SqlConnection con = new(_connectString))
            {

                string getRooms = "select * from Category";
                SqlCommand cmd = new SqlCommand(getRooms, con);
                con.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    roomCategories.Add(new RoomCategory
                    {
                        Id = (int)dataReader["Id"],
                        CategoryName = (string)dataReader["CategoryName"],
                        Desc = (string)dataReader["Desc"]
                    });
                }
                con.Close();
            }
            return roomCategories;
        }
        public void AddCategory(RoomCategory category)
        {
            using (SqlConnection con = new(_connectString))
            {
                con.Open();
                string addCategory = $"insert into Category values('{category.Id}','{category.CategoryName}', '{category.Desc}'";
                SqlCommand cmd = new SqlCommand(addCategory, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void AddRoom(Room room)
        {
            using (SqlConnection con = new(_connectString))
            {
                con.Open();
                string addCategory = $"insert into Room values('{room.Id}','{room.IdRoomCategory}','{room.Number}','{room.Price}','{room.Desc}','{room.Img}','{room.Accessed}')";
                SqlCommand cmd = new SqlCommand(addCategory, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void ChangeAccessed(int id)
        {
            using (SqlConnection con = new(_connectString))
            {
                con.Open();
                string change = $"Update Room SET Accessed=0 where Id like '{id}'";
                SqlCommand cmd = new SqlCommand(change, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        
        }
  
    }
}
