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
    public partial class manageService : UserControl
    {
        Classes.Manager manager = new Classes.Manager();
        string choice;
        public manageService()
        {
            InitializeComponent();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            if (txtServiceid.Text == "" || cmbServiceType.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Please fill every requirement");
            }
            else
            {
                try
                {

                    choice = "Add Service";
                    manager.manageServices(new Classes.Service(txtServiceid.Text.Trim(), cmbServiceType.Text.Trim(), txtPrice.Text.Trim()), choice);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Service can't be added");
                }
            }
        }

        private void btnSearchService_Click(object sender, EventArgs e)
        {
            if (txtServiceNumber.Text == "")
            {
                MessageBox.Show("Please enter Service Id");
            }
            else
            {
                choice = "Search Service";
                 dataGridView1.DataSource = manager.showServices(new Classes.Service(txtServiceNumber.Text.Trim()), choice);
            }
        }

        private void btnShowService_Click(object sender, EventArgs e)
        {
            choice = "Show All Service";
            dataGridView1.DataSource = manager.showServices(new Classes.Service(), choice);
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            if (txtSID.Text == "" || cmbST.Text == "" || txtSP.Text == "")
            {
                MessageBox.Show("Please fill every requirement");
            }
            else
            {
                try
                {
                      choice = "Update Service";
                      manager.manageServices(new Classes.Service(txtSID.Text.Trim(), cmbST.Text.Trim(), txtSP.Text.Trim()), choice);
            
                }
                catch (SqlException)
                {
                    MessageBox.Show("Service can't be updated");
                }
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (txtSID.Text == "")
            {
                MessageBox.Show("Please enter service id");
            }
            else
            {
                try
                {
                    choice = "Cancel Service";
                    manager.manageServices(new Classes.Service(txtSID.Text.Trim()), choice);

                }
                catch (SqlException)
                {
                    MessageBox.Show("Service can't be deleted");

                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnProvideService_Click(object sender, EventArgs e)
        {
            if (cmbSType.Text == "" || txtRNo.Text == "")
            {
                MessageBox.Show("Please fill every requirement");
            }
            else
            {
                Classes.Service service = new Classes.Service();
                manager.provideServices(new Classes.Reservation(txtRNo.Text.Trim()), service.serviceType = cmbSType.Text.Trim());
            }
        }

    }
}
