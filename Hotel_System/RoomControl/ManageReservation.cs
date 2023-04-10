using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_System.RoomControl
{
    public partial class ManageReservation : UserControl
    {
        Classes.Manager manager = new Classes.Manager();
        private string choice; 
        public ManageReservation()
        {
            InitializeComponent();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (txtReservationNo.Text == "" || txtroomNo.Text == "" || txtguesId.Text == "" || txtNam.Text == "" || dateTimePickerCheckIn.Text == "" || dateTimePickerCheckOut.Text == "" || txtNoofDays.Text == "")
            {
                MessageBox.Show("Please fill every requirement");
            }
            else
            {
                choice = "Add Reservation";
                manager.manageReservation(new Classes.Reservation(txtReservationNo.Text.Trim(), dateTimePickerCheckIn.Text.Trim(), dateTimePickerCheckOut.Text.Trim(),txtNoofDays.Text.Trim()), (new Classes.Customer(txtguesId.Text.Trim(), txtNam.Text.Trim())), (new Classes.Room(txtroomNo.Text.Trim())), choice);
                txtReservationNo.Text = ""; txtroomNo.Text = ""; txtguesId.Text = ""; txtNam.Text = ""; dateTimePickerCheckIn.Text = ""; dateTimePickerCheckOut.Text = "";txtNoofDays.Text = "" ;
                dataGridView1.Visible = false;
            }
        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            if (txtroomNo.Text == "")
            {
                MessageBox.Show("Please enter room no");
            }
            else
            {
                choice = "Check Availability";
                dataGridView1.Visible = true;
                dataGridView1.DataSource = manager.ShowRoom(new Classes.Room(txtroomNo.Text.Trim()), choice);
            }
        }

        private void btnSearchReservation_Click(object sender, EventArgs e)
        {
            if (txtReservationNumber.Text == "")
            {
                MessageBox.Show("Please enter reservation no");
            }
            else
            {
                choice = "Search Reservation";
                dataGridView2.DataSource = manager.showReservation(new Classes.Reservation(txtReservationNumber.Text.Trim()),choice);
            }
        }

        private void btnShowReservation_Click(object sender, EventArgs e)
        {
            choice = "Show All Reservation";
            dataGridView2.DataSource = manager.showReservation(new Classes.Reservation(), choice);
        }

        private void btnUpdateReservation_Click(object sender, EventArgs e)
        {
            if (txtReservationN.Text == "" || txtGuestiD.Text == "" || txtGuestName.Text == "" || txtroomN.Text == "" || dateTimeCheckIn.Text == "" || dateTimeCheckOut.Text == "" || txtDays.Text == "")
            {
                MessageBox.Show("Please fill every requirement");
            }
            else
            {
                choice = "Update Reservation";
                manager.manageReservation(new Classes.Reservation(txtReservationN.Text.Trim(), dateTimeCheckIn.Text.Trim(), dateTimeCheckOut.Text.Trim(),txtDays.Text.Trim()), new Classes.Customer(txtGuestiD.Text.Trim(), txtGuestName.Text.Trim()), new Classes.Room(txtroomN.Text.Trim()), choice);
                txtReservationN.Text = ""; txtGuestiD.Text = ""; txtGuestName.Text = ""; txtroomN.Text = ""; dateTimeCheckIn.Text = ""; dateTimeCheckOut.Text = ""; txtDays.Text = "";
                dataGridView3.Visible = false;
            }
            
        }

        private void btnavailable_Click(object sender, EventArgs e)
        {
            if (txtroomN.Text == "")
            {
                MessageBox.Show("Please enter room no");
            }
            else
            {
                choice = "Check Availability";
                dataGridView3.Visible = true;
                dataGridView3.DataSource = manager.ShowRoom(new Classes.Room(txtroomNo.Text.Trim()), choice);
            }
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (txtReservationN.Text == "")
            {
                MessageBox.Show("Please enter reservation number");
            }
            else
            {
                choice = "Cancel Reservation";
                manager.manageReservation(new Classes.Reservation(txtReservationN.Text.Trim()), new Classes.Customer(), new Classes.Room(), choice);
                txtReservationN.Text = "";
            }
        }
    }
}
