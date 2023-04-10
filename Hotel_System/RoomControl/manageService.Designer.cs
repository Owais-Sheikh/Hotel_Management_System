namespace Hotel_System.RoomControl
{
    partial class manageService
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.btnServices = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtServiceid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShowService = new System.Windows.Forms.Button();
            this.btnSearchService = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtServiceNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbST = new System.Windows.Forms.ComboBox();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbSType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnProvideService = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(45, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1453, 634);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbServiceType);
            this.tabPage1.Controls.Add(this.btnServices);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPrice);
            this.tabPage1.Controls.Add(this.txtServiceid);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1445, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Service";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Items.AddRange(new object[] {
            "Break Fast",
            "Lunch",
            "Dinner",
            "Refereshment"});
            this.cmbServiceType.Location = new System.Drawing.Point(639, 245);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(270, 28);
            this.cmbServiceType.TabIndex = 15;
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(201)))), ((int)(((byte)(143)))));
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.Location = new System.Drawing.Point(639, 404);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(178, 48);
            this.btnServices.TabIndex = 14;
            this.btnServices.Text = "Add Services";
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(462, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Service Type :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(639, 326);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(270, 26);
            this.txtPrice.TabIndex = 13;
            // 
            // txtServiceid
            // 
            this.txtServiceid.Location = new System.Drawing.Point(639, 162);
            this.txtServiceid.Name = "txtServiceid";
            this.txtServiceid.Size = new System.Drawing.Size(270, 26);
            this.txtServiceid.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(462, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Service Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(462, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Service Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(201)))), ((int)(((byte)(143)))));
            this.label1.Location = new System.Drawing.Point(92, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add Services";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShowService);
            this.tabPage2.Controls.Add(this.btnSearchService);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.txtServiceNumber);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1445, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Services";
            // 
            // btnShowService
            // 
            this.btnShowService.BackColor = System.Drawing.Color.HotPink;
            this.btnShowService.FlatAppearance.BorderSize = 0;
            this.btnShowService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowService.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowService.Location = new System.Drawing.Point(685, 152);
            this.btnShowService.Name = "btnShowService";
            this.btnShowService.Size = new System.Drawing.Size(173, 54);
            this.btnShowService.TabIndex = 11;
            this.btnShowService.Text = "Show All Service";
            this.btnShowService.UseVisualStyleBackColor = false;
            this.btnShowService.Click += new System.EventHandler(this.btnShowService_Click);
            // 
            // btnSearchService
            // 
            this.btnSearchService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(201)))), ((int)(((byte)(143)))));
            this.btnSearchService.FlatAppearance.BorderSize = 0;
            this.btnSearchService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchService.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchService.Location = new System.Drawing.Point(464, 152);
            this.btnSearchService.Name = "btnSearchService";
            this.btnSearchService.Size = new System.Drawing.Size(176, 54);
            this.btnSearchService.TabIndex = 10;
            this.btnSearchService.Text = "Search Service ";
            this.btnSearchService.UseVisualStyleBackColor = false;
            this.btnSearchService.Click += new System.EventHandler(this.btnSearchService_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(201)))), ((int)(((byte)(143)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1397, 345);
            this.dataGridView1.TabIndex = 9;
            // 
            // txtServiceNumber
            // 
            this.txtServiceNumber.Location = new System.Drawing.Point(611, 69);
            this.txtServiceNumber.Name = "txtServiceNumber";
            this.txtServiceNumber.Size = new System.Drawing.Size(247, 26);
            this.txtServiceNumber.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Service Id :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(201)))), ((int)(((byte)(143)))));
            this.label6.Location = new System.Drawing.Point(34, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Search Service";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeleteService);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.cmbST);
            this.tabPage3.Controls.Add(this.btnUpdateService);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtSP);
            this.tabPage3.Controls.Add(this.txtSID);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1445, 601);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update and Delete Service";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbST
            // 
            this.cmbST.FormattingEnabled = true;
            this.cmbST.Items.AddRange(new object[] {
            "Break Fast",
            "Lunch",
            "Dinner",
            "Refereshment"});
            this.cmbST.Location = new System.Drawing.Point(632, 225);
            this.cmbST.Name = "cmbST";
            this.cmbST.Size = new System.Drawing.Size(270, 28);
            this.cmbST.TabIndex = 22;
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(201)))), ((int)(((byte)(143)))));
            this.btnUpdateService.FlatAppearance.BorderSize = 0;
            this.btnUpdateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateService.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateService.Location = new System.Drawing.Point(460, 425);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(178, 48);
            this.btnUpdateService.TabIndex = 21;
            this.btnUpdateService.Text = "Update Services";
            this.btnUpdateService.UseVisualStyleBackColor = false;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(455, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Service Type :";
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(632, 306);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(270, 26);
            this.txtSP.TabIndex = 19;
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(632, 142);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(270, 26);
            this.txtSID.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(455, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Service Price :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(455, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Service Id :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(201)))), ((int)(((byte)(143)))));
            this.label10.Location = new System.Drawing.Point(73, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(276, 29);
            this.label10.TabIndex = 23;
            this.label10.Text = "Update and Delete Service";
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.BackColor = System.Drawing.Color.Red;
            this.btnDeleteService.FlatAppearance.BorderSize = 0;
            this.btnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteService.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteService.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteService.Location = new System.Drawing.Point(712, 425);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(190, 48);
            this.btnDeleteService.TabIndex = 24;
            this.btnDeleteService.Text = "Delete Service";
            this.btnDeleteService.UseVisualStyleBackColor = false;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnProvideService);
            this.tabPage4.Controls.Add(this.txtRNo);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.cmbSType);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1445, 601);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Provide Services";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmbSType
            // 
            this.cmbSType.FormattingEnabled = true;
            this.cmbSType.Items.AddRange(new object[] {
            "Break Fast",
            "Lunch",
            "Dinner",
            "Refereshment"});
            this.cmbSType.Location = new System.Drawing.Point(676, 299);
            this.cmbSType.Name = "cmbSType";
            this.cmbSType.Size = new System.Drawing.Size(270, 28);
            this.cmbSType.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(453, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "Service Type :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtRNo
            // 
            this.txtRNo.Location = new System.Drawing.Point(676, 195);
            this.txtRNo.Name = "txtRNo";
            this.txtRNo.Size = new System.Drawing.Size(270, 26);
            this.txtRNo.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(453, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "Reservation No :";
            // 
            // btnProvideService
            // 
            this.btnProvideService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(201)))), ((int)(((byte)(143)))));
            this.btnProvideService.FlatAppearance.BorderSize = 0;
            this.btnProvideService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvideService.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvideService.Location = new System.Drawing.Point(583, 423);
            this.btnProvideService.Name = "btnProvideService";
            this.btnProvideService.Size = new System.Drawing.Size(178, 48);
            this.btnProvideService.TabIndex = 22;
            this.btnProvideService.Text = "Provide Services";
            this.btnProvideService.UseVisualStyleBackColor = false;
            this.btnProvideService.Click += new System.EventHandler(this.btnProvideService_Click);
            // 
            // manageService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "manageService";
            this.Size = new System.Drawing.Size(1521, 704);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbServiceType;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServiceid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShowService;
        private System.Windows.Forms.Button btnSearchService;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtServiceNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbST;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtRNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnProvideService;

    }
}
