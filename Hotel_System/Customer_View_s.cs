using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_System
{
    public partial class Customer_View_s: Form
    {
        Classes.Manager manager = new Classes.Manager();
        Classes.Room room = new Classes.Room();
        public Customer_View_s()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manageRoom1.Show();
            manageGuest1.Visible = false;
            manageReservation1.Visible = false;
            dashboard1.Visible = false;
            invoice1.Visible = false;
            manageService1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            manageService1.Show();
            manageGuest1.Visible = false;
            manageReservation1.Visible = false;
            dashboard1.Visible = false;
            manageRoom1.Visible = false;
            invoice1.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            manageGuest1.Show();
            manageReservation1.Visible = false;
            dashboard1.Visible = false;
            manageRoom1.Visible = false;
            invoice1.Visible = false;
            manageService1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard1.Show();
            RoomControl.Dashboard dashboard = new RoomControl.Dashboard();
            dashboard.show();
            manageGuest1.Visible = false;
            manageReservation1.Visible = false;
            manageRoom1.Visible = false;
            invoice1.Visible = false;
            manageService1.Visible = false;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            manageReservation1.Show();
            manageGuest1.Visible = false;
            manageRoom1.Visible = false;
            dashboard1.Visible = false;
            invoice1.Visible = false;
            manageService1.Visible = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Classes.Room room = new Classes.Room();
            room.totalRoom();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            invoice1.Show();
            manageGuest1.Visible = false;
            manageRoom1.Visible = false;
            dashboard1.Visible = false;
            manageReservation1.Visible = false;
            manageService1.Visible = false;
        }
    }
}
