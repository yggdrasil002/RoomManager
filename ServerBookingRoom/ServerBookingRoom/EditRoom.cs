using System;
using System.Web.Services;
using MySql.Data.MySqlClient;

namespace ServerBookingRoom
{
    public class EditRoom
    {
        public bool EditRoomInfo(string staffID, int roomID, string roomName, string capacity, string connectionString)
        {
            if (IsManager(staffID, connectionString))
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Room SET RoomName = @RoomName, Capacity = @Capacity WHERE RoomID = @RoomID";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@RoomName", roomName);
                        cmd.Parameters.AddWithValue("@Capacity", capacity);
                        cmd.Parameters.AddWithValue("@RoomID", roomID);
                        cmd.ExecuteNonQuery();
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error editing room information in the database: " + ex.Message);
                }
            }
            else
            {
                throw new Exception("Only managers can edit room information.");
            }
        }
        private bool IsManager(string staffID, string connectionString)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT IsManager FROM Staff WHERE StaffID = @StaffID";
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToBoolean(result);
                    }
                    else
                    {
                        throw new Exception("StaffID not found.");
                    }
                }
            }
        }
    }
}