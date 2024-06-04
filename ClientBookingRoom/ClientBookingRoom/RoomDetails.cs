using ClientBookingRoom.RoomServiceReference;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClientBookingRoom
{
    public partial class RoomDetails : Form
    {
        private string _staffID;
        private int _roomID;
        private string _roomName;
        private string _name;
        public RoomDetails(string staffID, int roomID, string roomName, string name)
        {
            InitializeComponent();
            _roomID = roomID;
            _staffID = staffID;
            _roomName = roomName;
            _name = name;

            dtgvSchedule.Font = new Font("Arial", 12);

            lbRoomID.Text = $"Room ID: {roomID.ToString()}";
            lbRoomName.Text = $"Room Name: {roomName}";

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            dtgvSchedule.Rows.Clear();

            DateTime bookingDate = dtpBookingDate.Value.Date;
            DataGridViewRow newRow = new DataGridViewRow();

            DataGridViewCell dateCell = new DataGridViewTextBoxCell();
            dateCell.Value = bookingDate.ToString("dd/MM/yyyy");
            newRow.Cells.Add(dateCell);

            for (int i = 1; i < dtgvSchedule.Columns.Count; i++)
            {
                string shift = dtgvSchedule.Columns[i].HeaderText;
                string bookedBy = GetBookedBy(shift, bookingDate);

                DataGridViewCell cell = new DataGridViewTextBoxCell();
                if (!string.IsNullOrEmpty(bookedBy))
                {
                    cell.Value = $"Booked by {bookedBy}";
                }
                else
                {
                    cell.Value = "Available";
                }
                newRow.Cells.Add(cell);
            }
            newRow.Height = 40;
            dtgvSchedule.Rows.Add(newRow);

            
        }
        private string GetBookedBy(string shift, DateTime bookingDate)
        {
            RoomServiceSoapClient client = new RoomServiceSoapClient();
            var bookings = client.GetBookingDetails(int.Parse(_staffID), bookingDate, _roomID);
            foreach (var booking in bookings)
            {
                if (booking.StartTime.TimeOfDay <= GetShiftStartTime(shift) &&
            booking.EndTime.TimeOfDay >= GetShiftEndTime(shift))
                {
                    return booking.Name;
                }
            }
            return null;
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
        private void RoomDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (dtgvSchedule.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dtgvSchedule.SelectedCells[0];
                int row = selectedCell.RowIndex;
                int column = selectedCell.ColumnIndex;

                if (dtgvSchedule.Rows[row].Cells[column].Value.ToString() == "Available")
                {
                    DateTime bookingDate = dtpBookingDate.Value.Date;
                    if (bookingDate.Date <= DateTime.Today)
                    {
                        MessageBox.Show("Cannot book for the past date.");
                        return;
                    }
                    DialogResult result = MessageBox.Show("Are you sure you want to book this slot?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        RoomServiceSoapClient client = new RoomServiceSoapClient();
                        string shift = dtgvSchedule.Columns[column].HeaderText;
                        bool success = client.BookingRoom(_staffID, _roomID, bookingDate, shift);
                        if (success)
                        {
                            MessageBox.Show("Booking successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Booking failed. The room might have been booked by someone else.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This slot is not available for booking.");
                }
            }
            else
            {
                MessageBox.Show("Please select a slot to book.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dtgvSchedule.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dtgvSchedule.SelectedCells[0];
                int row = selectedCell.RowIndex;
                int column = selectedCell.ColumnIndex;

                DateTime bookingDate = dtpBookingDate.Value.Date;
                string shift = dtgvSchedule.Columns[column].HeaderText;
                string bookedBy = GetBookedBy(shift, bookingDate);

                MessageBox.Show(_name);
                if (dtgvSchedule.Rows[row].Cells[column].Value.ToString() != "Available" && dtgvSchedule.Rows[row].Cells[column].Value.ToString() == $"Booked by {_name}")
                {

                    DialogResult result = MessageBox.Show("Are you sure you want to cancel this booking?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        RoomServiceSoapClient client = new RoomServiceSoapClient();
                        bool success = client.CancelBooking(_staffID, _roomID, bookingDate, shift);
                        if (success)
                        {
                            MessageBox.Show("Booking canceled successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Failed to cancel booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This slot is available and not booked.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a booked slot to cancel.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void lkbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form ownerForm = this.Owner;
            ownerForm.Show();
            ownerForm.Focus();
            this.Hide();
        }
        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            EditRoom editRoom = new EditRoom();
            if (editRoom.ShowDialog() == DialogResult.OK)
            {
                string roomName = editRoom.RoomName;
                string capacity = editRoom.Capacity;
                RoomServiceSoapClient client = new RoomServiceSoapClient();
                bool success = client.EditRoom(_staffID, _roomID, roomName, capacity);

                if (success)
                {
                    MessageBox.Show("Room information updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbRoomName.Text = $"Room Name: {roomName}";

                    ((MainForm)this.Owner).UpdateRoomInfo(_roomID, roomName, capacity);
                }
                else
                {
                    MessageBox.Show("Failed to update room information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    } 
}
