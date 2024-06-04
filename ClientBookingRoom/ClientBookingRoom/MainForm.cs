using System;
using System.Windows.Forms;
using ClientBookingRoom.RoomServiceReference;

namespace ClientBookingRoom
{
    public partial class MainForm : Form
    {
        private string _name;
        private string _department;
        private int _staffID;
        public MainForm(string name, string department, int staffID)
        {
            InitializeComponent();
            _name = name;
            _department = department;
            _staffID = staffID;
            DisplayUserInfo();

            LoadRooms();

            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void DisplayUserInfo()
        {
            lbName.Text = $"Name: {_name}";
            lbDepartment.Text = $"Department: {_department}";
            lbStaffID.Text = $"StaffID: {_staffID}";
        }
        private void LoadRooms()
        {
            RoomServiceSoapClient client = new RoomServiceSoapClient();
            var rooms = client.GetListRoom();

            lsvRoom.Items.Clear();

            foreach (var room in rooms)
            {
                ListViewItem item = new ListViewItem(room.RoomID.ToString());
                item.SubItems.Add(room.RoomName);
                item.SubItems.Add(room.Capacity.ToString());
                lsvRoom.Items.Add(item);
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lsvRoom_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lsvRoom.SelectedItems.Count > 0)
            {
                int roomID = int.Parse(lsvRoom.SelectedItems[0].Text);
                string roomName = lsvRoom.SelectedItems[0].SubItems[1].Text;
                string staffID = _staffID.ToString();
                this.Hide();
                RoomDetails roomDetails = new RoomDetails(staffID, roomID, roomName, _name);
                roomDetails.Owner = this;
                roomDetails.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(_staffID);
            changePassword.Show();
        }
        public void UpdateRoomInfo(int roomID, string roomName, string capacity)
        {
            foreach (ListViewItem item in lsvRoom.Items)
            {
                if (int.Parse(item.Text) == roomID)
                {
                    item.SubItems[1].Text = roomName;
                    item.SubItems[2].Text = capacity;
                    break;
                }
            }
        }
    }
}
