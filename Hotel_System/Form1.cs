using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hotel_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void OpenCustomerView(object obj)
        {
            Application.Run(new Customer_View_s());
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "owais@gmail.com" && txtPassword.Text == "123456")
            {
                this.Close();
                Thread th = new Thread(OpenCustomerView);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Incorrect email password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
