using System;
using System.Collections.Generic;
using System.Web.Services;
using MySql.Data.MySqlClient;

namespace ServerBookingRoom
{
    [WebService(Namespace = "http://yourdomain.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class RoomService : WebService
    {
        private string connectionString = "Server=localhost;Database=BookingRoom;Uid=root;";

        [WebMethod]
        public (bool, string, string, int) Login(string username, string password)
        {
            Login login = new Login();
            return login.LoginStaff(username, password, connectionString);
        }
        [WebMethod]
        public string ForgotPassword(string username, string email)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            return forgotPassword.ForgotPasswordStaff(username, email, connectionString);
        }
        [WebMethod]
        public List<Room> GetListRoom()
        {
            GetListRoom getListRoom = new GetListRoom();
            return getListRoom.GetRooms(connectionString);
        }
        [WebMethod]
        public List<BookingDetails> GetBookingDetails(int staffID, DateTime bookingDate, int roomID)
        {
            GetBookingDetails getBookingDetails = new GetBookingDetails();
            return getBookingDetails.GetBookingInfo(staffID, bookingDate, roomID, connectionString);
        }
        [WebMethod]
        public bool BookingRoom(string staffID, int roomID, DateTime bookingDate, string shift)
        {
            BookingRoom bookingRoom = new BookingRoom();
            return bookingRoom.Booking(staffID, roomID, bookingDate, shift, connectionString);
        }
        [WebMethod]
        public bool CancelBooking(string staffID, int roomID, DateTime bookingDate, string shift)
        {
            BookingRoom bookingRoom = new BookingRoom();
            return bookingRoom.CancelBooking(staffID, roomID, bookingDate, shift, connectionString);
        }
        [WebMethod]
        public bool ChangePassword(int staffID, string newPassword)
        {
            Login login = new Login();
            return login.ChangePassword(staffID, newPassword, connectionString);
        }
        [WebMethod]
        public bool VerifyPassword(int staffID, string oldPassword)
        {
            Login login = new Login();
            return login.VerifyPassword(staffID, oldPassword, connectionString);
        }
        [WebMethod]
        public bool EditRoom(string staffID, int roomID, string roomName, string capacity)
        {
            EditRoom editRoom = new EditRoom();
            return editRoom.EditRoomInfo(staffID, roomID, roomName, capacity, connectionString);
        }


    }
}