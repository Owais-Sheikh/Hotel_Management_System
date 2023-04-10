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
    public partial class ManageGuest : UserControl
    {
        Classes.Manager manager = new Classes.Manager();
        string choice;
        public ManageGuest()
        {
            InitializeComponent();
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            if (txtGuestid.Text == "" || txtname.Text == "" || txtphoneno.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill every requirement");
            }
            else
            {
                try
                {
                    choice = "Add Guest";
                    manager.ManageGuests(new Classes.Customer(txtGuestid.Text, txtname.Text, txtphoneno.Text, txtAddress.Text), choice);
                    txtGuestid.Text = ""; txtname.Text = ""; txtphoneno.Text = ""; txtAddress.Text = "";

                }
                catch(SqlException)
                {
                    MessageBox.Show("Guest can't be added");
                }
            }
        }

        private void btnSearchGuest_Click(object sender, EventArgs e)
        {
            if (txtGID.Text == "")
            {
                MessageBox.Show("Please enter id");
            }
            else
            {
              
                    choice = "Search Guest";
                   dataGridViewGuest.DataSource = manager.ShowGuest(new Classes.Customer(txtGID.Text.Trim()), choice);
                    txtGID.Text = "";
                
            }
        }

        private void btnShowGuest_Click(object sender, EventArgs e)
        {
            choice = "Show All Guest";
           dataGridViewGuest.DataSource =  manager.ShowGuest(new Classes.Customer(), choice);
        }

        private void btnUpdateGuest_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtNameGuest.Text == "" || txtphone.Text == "" || txtguestAddress.Text == "")
            {
                MessageBox.Show("Please fill every requirement");
            }
            else
            {
                try
                {
                    choice = "Update Guest";
                manager.ManageGuests(new Classes.Customer(txtid.Text.Trim(), txtNameGuest.Text.Trim(), txtphone.Text.Trim(), txtguestAddress.Text.Trim()), choice);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Room can't be updated");
                }
            }
        }

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Please enter id");
            }
            else
            {
                try
                {
                    choice = "Delete Guest";
                    manager.ManageGuests(new Classes.Customer(txtid.Text.Trim()), choice);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Guest can't be deleted");
                }
            }
        }

    }
}
