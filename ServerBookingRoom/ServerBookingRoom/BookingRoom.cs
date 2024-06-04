using MySql.Data.MySqlClient;
using System;

namespace ServerBookingRoom
{
    public class BookingRoom
    {
        public bool Booking(string staffID, int roomID, DateTime bookingDate, string shift, string connectionString)
        {
            if (bookingDate < DateTime.Today)
            {
                return false;
            }
            if (IsRoomBooked(roomID, bookingDate, GetShiftStartTime(shift), GetShiftEndTime(shift), connectionString))
            {
                return false;
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO RoomBooking (StaffID, RoomID, BookingDate, StartTime, EndTime) VALUES (@StaffID, @RoomID, @BookingDate, @StartTime, @EndTime)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffID);
                    cmd.Parameters.AddWithValue("@RoomID", roomID);
                    cmd.Parameters.AddWithValue("@BookingDate", bookingDate);
                    cmd.Parameters.AddWithValue("@StartTime", GetShiftStartTime(shift));
                    cmd.Parameters.AddWithValue("@EndTime", GetShiftEndTime(shift));

                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool CancelBooking(string staffID, int roomID, DateTime bookingDate, string shift, string connectionString)
        {
            if (!IsRoomBooked(roomID, bookingDate, GetShiftStartTime(shift), GetShiftEndTime(shift), connectionString))
            {
                 return false;
            }
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM RoomBooking WHERE StaffID = @StaffID AND RoomID = @RoomID AND BookingDate = @BookingDate AND StartTime = @StartTime AND EndTime = @EndTime";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffID);
                    cmd.Parameters.AddWithValue("@RoomID", roomID);
                    cmd.Parameters.AddWithValue("@BookingDate", bookingDate);
                    cmd.Parameters.AddWithValue("@StartTime", GetShiftStartTime(shift));
                    cmd.Parameters.AddWithValue("@EndTime", GetShiftEndTime(shift));

                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }
        private bool IsRoomBooked(int roomID, DateTime bookingDate, System.TimeSpan shiftStartTime, System.TimeSpan shiftEndTime, string connectionString)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM RoomBooking WHERE RoomID = @roomID AND BookingDate = @bookingDate " +
                       "AND StartTime <= @shiftEndTime AND EndTime >= @shiftStartTime";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@roomID", roomID);
                cmd.Parameters.AddWithValue("@bookingDate", bookingDate);
                cmd.Parameters.AddWithValue("@shiftStartTime", shiftStartTime);
                cmd.Parameters.AddWithValue("@shiftEndTime", shiftEndTime);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        private TimeSpan GetShiftStartTime(string shift)
        {
            switch (shift)
            {
                case "Shift 1 (8h - 9h30h)":
                    return new TimeSpan(8, 0, 0); // 8:00 AM
                case "Shift 2 (9h30 - 11h)":
                    return new TimeSpan(9, 30, 1); // 9:30 AM
                case "Shift 3 (11h - 12h30)":
                    return new TimeSpan(11, 0, 1); // 11:00 AM
                case "Shift 4 (12h30 - 14h)":
                    return new TimeSpan(12, 30, 1); // 12:30 AM
                case "Shift 5 (14h - 15h30)":
                    return new TimeSpan(14, 0, 1); // 2:00 PM
                case "Shift 6 (15h30 - 17h)":
                    return new TimeSpan(15, 30, 1); // 3:30 PM
                default:
                    return TimeSpan.Zero;
            }
        }
        private TimeSpan GetShiftEndTime(string shift)
        {
            switch (shift)
            {
                case "Shift 1 (8h - 9h30h)":
                    return new TimeSpan(9, 30, 0); // 9:30 AM
                case "Shift 2 (9h30 - 11h)":
                    return new TimeSpan(11, 0, 0); // 11:00 AM
                case "Shift 3 (11h - 12h30)":
                    return new TimeSpan(12, 30, 0); // 12:30 PM
                case "Shift 4 (12h30 - 14h)":
                    return new TimeSpan(14, 0, 0); // 2:00 PM
                case "Shift 5 (14h - 15h30)":
                    return new TimeSpan(15, 30, 0); // 3:30 PM
                case "Shift 6 (15h30 - 17h)":
                    return new TimeSpan(17, 00, 0); // 5:00 PM
                default:
                    return TimeSpan.Zero;
            }
        }
    }
}