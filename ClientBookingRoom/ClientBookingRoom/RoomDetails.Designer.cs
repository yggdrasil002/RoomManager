namespace ClientBookingRoom
{
    partial class RoomDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.lbRoomName = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.dtgvSchedule = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lkbBack = new System.Windows.Forms.LinkLabel();
            this.btnEditRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.BackColor = System.Drawing.Color.Yellow;
            this.lbRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomID.Location = new System.Drawing.Point(32, 29);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(112, 29);
            this.lbRoomID.TabIndex = 0;
            this.lbRoomID.Text = "Room ID";
            // 
            // lbRoomName
            // 
            this.lbRoomName.AutoSize = true;
            this.lbRoomName.BackColor = System.Drawing.Color.Yellow;
            this.lbRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomName.Location = new System.Drawing.Point(32, 78);
            this.lbRoomName.Name = "lbRoomName";
            this.lbRoomName.Size = new System.Drawing.Size(156, 29);
            this.lbRoomName.TabIndex = 1;
            this.lbRoomName.Text = "Room Name";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(37, 137);
            this.dtpBookingDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(279, 26);
            this.dtpBookingDate.TabIndex = 2;
            this.dtpBookingDate.ValueChanged += new System.EventHandler(this.dtpBookingDate_ValueChanged);
            // 
            // dtgvSchedule
            // 
            this.dtgvSchedule.AllowUserToAddRows = false;
            this.dtgvSchedule.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvSchedule.ColumnHeadersHeight = 90;
            this.dtgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.Shift_1,
            this.Shift_2,
            this.Shift_3,
            this.Shift_4,
            this.Shift_5,
            this.Shift_6});
            this.dtgvSchedule.Location = new System.Drawing.Point(29, 194);
            this.dtgvSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvSchedule.Name = "dtgvSchedule";
            this.dtgvSchedule.ReadOnly = true;
            this.dtgvSchedule.RowHeadersVisible = false;
            this.dtgvSchedule.RowHeadersWidth = 51;
            this.dtgvSchedule.RowTemplate.Height = 40;
            this.dtgvSchedule.Size = new System.Drawing.Size(1186, 131);
            this.dtgvSchedule.TabIndex = 3;
            // 
            // Column
            // 
            this.Column.HeaderText = "";
            this.Column.MinimumWidth = 6;
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.Column.Width = 150;
            // 
            // Shift_1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Shift_1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Shift_1.HeaderText = "Shift 1 (8h - 9h30h)";
            this.Shift_1.MinimumWidth = 6;
            this.Shift_1.Name = "Shift_1";
            this.Shift_1.ReadOnly = true;
            this.Shift_1.Width = 172;
            // 
            // Shift_2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Shift_2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Shift_2.HeaderText = "Shift 2 (9h30 - 11h)";
            this.Shift_2.MinimumWidth = 6;
            this.Shift_2.Name = "Shift_2";
            this.Shift_2.ReadOnly = true;
            this.Shift_2.Width = 172;
            // 
            // Shift_3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Shift_3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Shift_3.HeaderText = "Shift 3 (11h - 12h30)";
            this.Shift_3.MinimumWidth = 6;
            this.Shift_3.Name = "Shift_3";
            this.Shift_3.ReadOnly = true;
            this.Shift_3.Width = 172;
            // 
            // Shift_4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Shift_4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Shift_4.HeaderText = "Shift 4 (12h30 - 14h)";
            this.Shift_4.MinimumWidth = 6;
            this.Shift_4.Name = "Shift_4";
            this.Shift_4.ReadOnly = true;
            this.Shift_4.Width = 172;
            // 
            // Shift_5
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Shift_5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Shift_5.HeaderText = "Shift 5 (14h - 15h30)";
            this.Shift_5.MinimumWidth = 6;
            this.Shift_5.Name = "Shift_5";
            this.Shift_5.ReadOnly = true;
            this.Shift_5.Width = 172;
            // 
            // Shift_6
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Shift_6.DefaultCellStyle = dataGridViewCellStyle7;
            this.Shift_6.HeaderText = "Shift 6 (15h30 - 17h)";
            this.Shift_6.MinimumWidth = 6;
            this.Shift_6.Name = "Shift_6";
            this.Shift_6.ReadOnly = true;
            this.Shift_6.Width = 172;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Red;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(1099, 349);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(116, 60);
            this.btnBooking.TabIndex = 4;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(944, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 60);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lkbBack
            // 
            this.lkbBack.AutoSize = true;
            this.lkbBack.Location = new System.Drawing.Point(1139, 38);
            this.lkbBack.Name = "lkbBack";
            this.lkbBack.Size = new System.Drawing.Size(62, 20);
            this.lkbBack.TabIndex = 7;
            this.lkbBack.TabStop = true;
            this.lkbBack.Text = "< Back";
            this.lkbBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbBack_LinkClicked);
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.BackColor = System.Drawing.Color.Red;
            this.btnEditRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRoom.ForeColor = System.Drawing.Color.White;
            this.btnEditRoom.Location = new System.Drawing.Point(72, 349);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(152, 60);
            this.btnEditRoom.TabIndex = 8;
            this.btnEditRoom.Text = "Edit Room";
            this.btnEditRoom.UseVisualStyleBackColor = false;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // RoomDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1252, 445);
            this.Controls.Add(this.btnEditRoom);
            this.Controls.Add(this.lkbBack);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.dtgvSchedule);
            this.Controls.Add(this.dtpBookingDate);
            this.Controls.Add(this.lbRoomName);
            this.Controls.Add(this.lbRoomID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RoomDetails";
            this.Text = "RoomDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoomDetails_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.Label lbRoomName;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.DataGridView dtgvSchedule;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift_6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lkbBack;
        private System.Windows.Forms.Button btnEditRoom;
    }
}