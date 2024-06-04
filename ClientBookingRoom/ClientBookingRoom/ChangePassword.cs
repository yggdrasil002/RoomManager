using System;
using System.Windows.Forms;
using ClientBookingRoom.RoomServiceReference;

namespace ClientBookingRoom
{
    public partial class ChangePassword : Form
    {
        private int _staffID;
        public ChangePassword(int staffID)
        {
            InitializeComponent();

            _staffID = staffID;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = txbOldPassword.Text;
            string newPassword = txbNewPassword.Text;

            RoomServiceSoapClient client = new RoomServiceSoapClient();
            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Password fields cannot be empty.");
                return;
            }
            if (!client.VerifyPassword(_staffID, oldPassword))
            {
                MessageBox.Show("Old password is incorrect.");
                return;
            }
            bool result = client.ChangePassword(_staffID, newPassword);
            if (result)
            {
                MessageBox.Show("Password changed successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error changing password.");
            }
        }
    }
}
