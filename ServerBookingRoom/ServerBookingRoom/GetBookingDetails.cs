using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ServerBookingRoom
{
    public class BookingDetails
    {
        public string Name { get; set; }
        public DateTime BookingDate { get; set; }
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
    public class GetBookingDetails
    {

        public List<BookingDetails> GetBookingInfo(int staffID, DateTime bookingDate, int roomID, string connectionString)
        {
            List<BookingDetails> bookingDetails = new List<BookingDetails>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT rb.*, s.Name AS StaffName " +
                                "FROM RoomBooking rb " +
                                "INNER JOIN Staff s ON rb.StaffID = s.StaffID " +
                                "WHERE rb.BookingDate = @bookingDate AND rb.RoomID = @roomID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@staffID", staffID);
                cmd.Parameters.AddWithValue("@bookingDate", bookingDate);
                cmd.Parameters.AddWithValue("@roomID", roomID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BookingDetails bookingDetail = new BookingDetails
                        {
                            Name = reader.GetString("StaffName"),
                            BookingDate = reader.GetDateTime("BookingDate"),
                            RoomID = reader.GetInt32("RoomID"),
                            StartTime = bookingDate.Date.Add(reader.GetTimeSpan("StartTime")),
                            EndTime = bookingDate.Date.Add(reader.GetTimeSpan("EndTime"))
                        };
                        bookingDetails.Add(bookingDetail);
                    }
                }
            }
            return bookingDetails;
        }
    }
}