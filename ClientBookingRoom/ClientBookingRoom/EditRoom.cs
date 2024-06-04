using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBookingRoom
{
    public partial class EditRoom : Form
    {
        public string RoomName
        {
            get { return txbRoomName.Text; }
            set { txbRoomName.Text = value; }
        }

        public string Capacity
        {
            get { return txbCapacity.Text; }
            set { txbCapacity.Text = value; }
        }
        public EditRoom()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
