using MySql.Data.MySqlClient;
using System;

namespace ServerBookingRoom
{
    public class Login
    {
        public (bool, string, string, int) LoginStaff(string username, string password, string connectionString)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT StaffID, Name, Department FROM Staff WHERE Username=@username AND Password=@password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int staffID = Convert.ToInt32(reader["StaffID"]);
                    string name = reader["Name"].ToString();
                    string department = reader["Department"].ToString();
                    return (true, name, department, staffID);
                }
                else
                {
                    return (false, null, null, 0);
                }
            }
        }
        public bool VerifyPassword(int staffID, string oldPassword, string connectionString)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Staff WHERE StaffID = @staffID AND Password = @oldPassword";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@staffID", staffID);
                    cmd.Parameters.AddWithValue("@oldPassword", oldPassword);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public bool ChangePassword(int staffID, string newPassword, string connectionString)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Staff SET Password = @newPassword WHERE StaffID = @staffID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@staffID", staffID);
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);

                    int changePassword = cmd.ExecuteNonQuery();
                    return changePassword > 0;
                }
            }
        }
    }
}