using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class InvoiceForm : Form
    {
        Classes.Manager manager = new Classes.Manager();
        RoomControl.Invoice invoice = new RoomControl.Invoice();
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            lblReservationNo.Text = manager.payment("ReservationNo");
            lblCustomerName.Text = manager.payment("C_Name");
            lblCustomerPhone.Text = manager.payment("Guest.PhoneNo");
            lblCustomerAddress.Text = manager.payment("Address");
            lblRoomNo.Text = manager.payment("Reservation.RoomNo");
            lblServiceType.Text = manager.payment("serviceType");
            lblServicePrice.Text = manager.payment("servicePrice");
            lblDailyRent.Text = manager.payment("dailyRent");
            lblServicePrice.Text = manager.payment("servicePrice");
            lblTotalBill.Text = manager.payment("Total Charges");
        }
    }
}
