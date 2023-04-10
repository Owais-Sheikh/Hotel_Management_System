using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System.RoomControl
{
    public partial class Dashboard : UserControl
    {
        Classes.Room room = new Classes.Room();
        Classes.Customer customer = new Classes.Customer();
        Classes.Reservation reservation = new Classes.Reservation();
        public Dashboard()
        {
            InitializeComponent();
        }
        public void show()
        {
            label1.Text = customer.totalGuest();
            label6.Text = room.totalRoom();
            label3.Text = reservation.totalReservation();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            show();
        }

    }
}
