using System;
using System.Windows.Forms;
using ClientBookingRoom.RoomServiceReference;

namespace ClientBookingRoom
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnResetPassWord_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string email = txbEmail.Text;

            RoomServiceSoapClient client = new RoomServiceSoapClient();
            string resetResult = client.ForgotPassword(username, email);

            if (resetResult == "Password reset successfully!")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(resetResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ownerForm = this.Owner;
            ownerForm.Show();
            ownerForm.Focus();
        }

    }
}
