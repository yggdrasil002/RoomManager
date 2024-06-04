using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ServerBookingRoom
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public int Capacity { get; set; }
    }
    public class GetListRoom
    {
        public List<Room> GetRooms(string connectionString)
        {
            List<Room> rooms = new List<Room>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Room", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Room room = new Room
                        {
                            RoomID = reader.GetInt32("RoomID"),
                            RoomName = reader.GetString("RoomName"),
                            Capacity = reader.GetInt32("Capacity")
                        };
                        rooms.Add(room);
                    }
                }
            }

            return rooms;
        }

    }
}