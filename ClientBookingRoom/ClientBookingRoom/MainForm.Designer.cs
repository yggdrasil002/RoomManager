namespace ClientBookingRoom
{
    partial class MainForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbStaffID = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lsvRoom = new System.Windows.Forms.ListView();
            this.RoomID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnchangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(52, 57);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(81, 29);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // lbStaffID
            // 
            this.lbStaffID.AutoSize = true;
            this.lbStaffID.BackColor = System.Drawing.Color.Cyan;
            this.lbStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffID.Location = new System.Drawing.Point(409, 57);
            this.lbStaffID.Name = "lbStaffID";
            this.lbStaffID.Size = new System.Drawing.Size(96, 29);
            this.lbStaffID.TabIndex = 1;
            this.lbStaffID.Text = "Staff ID";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.BackColor = System.Drawing.Color.Cyan;
            this.lbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment.Location = new System.Drawing.Point(52, 109);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(145, 29);
            this.lbDepartment.TabIndex = 2;
            this.lbDepartment.Text = "Department";
            // 
            // lsvRoom
            // 
            this.lsvRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RoomID,
            this.RoomName,
            this.RoomCapacity});
            this.lsvRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvRoom.FullRowSelect = true;
            this.lsvRoom.GridLines = true;
            this.lsvRoom.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvRoom.HideSelection = false;
            this.lsvRoom.Location = new System.Drawing.Point(129, 157);
            this.lsvRoom.Name = "lsvRoom";
            this.lsvRoom.Size = new System.Drawing.Size(622, 305);
            this.lsvRoom.TabIndex = 3;
            this.lsvRoom.UseCompatibleStateImageBehavior = false;
            this.lsvRoom.View = System.Windows.Forms.View.Details;
            this.lsvRoom.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvRoom_MouseDoubleClick);
            // 
            // RoomID
            // 
            this.RoomID.Text = "ID Room";
            this.RoomID.Width = 100;
            // 
            // RoomName
            // 
            this.RoomName.Text = "Room Name";
            this.RoomName.Width = 270;
            // 
            // RoomCapacity
            // 
            this.RoomCapacity.Text = "Capacity";
            this.RoomCapacity.Width = 90;
            // 
            // btnchangePassword
            // 
            this.btnchangePassword.Location = new System.Drawing.Point(773, 12);
            this.btnchangePassword.Name = "btnchangePassword";
            this.btnchangePassword.Size = new System.Drawing.Size(139, 30);
            this.btnchangePassword.TabIndex = 4;
            this.btnchangePassword.Text = "Change Password";
            this.btnchangePassword.UseVisualStyleBackColor = true;
            this.btnchangePassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(924, 519);
            this.Controls.Add(this.btnchangePassword);
            this.Controls.Add(this.lsvRoom);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.lbStaffID);
            this.Controls.Add(this.lbName);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbStaffID;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.ListView lsvRoom;
        private System.Windows.Forms.ColumnHeader RoomID;
        private System.Windows.Forms.ColumnHeader RoomName;
        private System.Windows.Forms.ColumnHeader RoomCapacity;
        private System.Windows.Forms.Button btnchangePassword;
    }
}