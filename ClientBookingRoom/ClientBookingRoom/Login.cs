using System;
using System.Windows.Forms;
using ClientBookingRoom.RoomServiceReference;

namespace ClientBookingRoom
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.Owner = this;
            this.Hide();
            if (forgotPasswordForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Password reset request sent successfully!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;

            RoomServiceSoapClient client = new RoomServiceSoapClient();
            var loginResult = client.Login(username, password);

            if (loginResult.Item1)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                MainForm mainForm = new MainForm(loginResult.Item2, loginResult.Item3, loginResult.Item4);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
