namespace Hotel_System
{
    partial class Customer_View_s
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.invoice1 = new Hotel_System.RoomControl.Invoice();
            this.manageRoom1 = new Hotel_System.RoomControl.ManageRoom();
            this.dashboard1 = new Hotel_System.RoomControl.Dashboard();
            this.manageReservation1 = new Hotel_System.RoomControl.ManageReservation();
            this.manageGuest1 = new Hotel_System.RoomControl.ManageGuest();
            this.manageService1 = new Hotel_System.RoomControl.manageService();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(201)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(297, 1050);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 693);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(297, 85);
            this.button5.TabIndex = 3;
            this.button5.Text = "Generate Invoice";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.Location = new System.Drawing.Point(0, 612);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(297, 84);
            this.btnReservation.TabIndex = 2;
            this.btnReservation.Text = "Manage Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(6, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dash Board";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(3, 521);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(291, 85);
            this.button4.TabIndex = 1;
            this.button4.Text = "Manage Services";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(3, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(291, 85);
            this.button3.TabIndex = 1;
            this.button3.Text = "Manage Rooms";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(6, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "Manage Guest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(149)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblHotel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 251);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "System";
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(43, 133);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(206, 29);
            this.lblHotel.TabIndex = 1;
            this.lblHotel.Text = "Hotel Management";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(149)))), ((int)(((byte)(106)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(297, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1627, 176);
            this.panel3.TabIndex = 1;
            // 
            // invoice1
            // 
            this.invoice1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invoice1.BackColor = System.Drawing.Color.White;
            this.invoice1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice1.Location = new System.Drawing.Point(297, 176);
            this.invoice1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.invoice1.Name = "invoice1";
            this.invoice1.Size = new System.Drawing.Size(1627, 874);
            this.invoice1.TabIndex = 7;
            this.invoice1.Visible = false;
            // 
            // manageRoom1
            // 
            this.manageRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageRoom1.Location = new System.Drawing.Point(297, 176);
            this.manageRoom1.Name = "manageRoom1";
            this.manageRoom1.Size = new System.Drawing.Size(1627, 874);
            this.manageRoom1.TabIndex = 6;
            this.manageRoom1.Visible = false;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.White;
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(297, 176);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1627, 874);
            this.dashboard1.TabIndex = 5;
            // 
            // manageReservation1
            // 
            this.manageReservation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageReservation1.Location = new System.Drawing.Point(297, 176);
            this.manageReservation1.Name = "manageReservation1";
            this.manageReservation1.Size = new System.Drawing.Size(1627, 874);
            this.manageReservation1.TabIndex = 4;
            this.manageReservation1.Visible = false;
            // 
            // manageGuest1
            // 
            this.manageGuest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageGuest1.Location = new System.Drawing.Point(297, 176);
            this.manageGuest1.Name = "manageGuest1";
            this.manageGuest1.Size = new System.Drawing.Size(1627, 874);
            this.manageGuest1.TabIndex = 3;
            this.manageGuest1.Visible = false;
            // 
            // manageService1
            // 
            this.manageService1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageService1.Location = new System.Drawing.Point(297, 176);
            this.manageService1.Name = "manageService1";
            this.manageService1.Size = new System.Drawing.Size(1627, 874);
            this.manageService1.TabIndex = 8;
            this.manageService1.Visible = false;
            // 
            // Customer_View_s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.manageService1);
            this.Controls.Add(this.invoice1);
            this.Controls.Add(this.manageRoom1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.manageReservation1);
            this.Controls.Add(this.manageGuest1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Customer_View_s";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_View_s";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Panel panel3;
        private RoomControl.ManageGuest manageGuest1;
        private System.Windows.Forms.Button btnReservation;
        private RoomControl.ManageReservation manageReservation1;
        private RoomControl.Dashboard dashboard1;
        private System.Windows.Forms.Button button5;
        private RoomControl.ManageRoom manageRoom1;
        private RoomControl.Invoice invoice1;
        private RoomControl.manageService manageService1;
    }
}