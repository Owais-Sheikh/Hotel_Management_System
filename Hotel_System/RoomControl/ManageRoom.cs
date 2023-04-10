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
    public partial class ManageRoom : UserControl
    {
        Classes.Manager manager = new Classes.Manager();

        private static string choice;
        public ManageRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please enter room details !!!");
            }
            else
            {
                try
                {
                    choice = "Add Room";
                    manager.Managerooms(new Classes.Room(textBox1.Text.Trim(), comboBox1.Text.Trim(), comboBox2.Text.Trim(), textBox4.Text.Trim()),choice);
                    textBox1.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    textBox4.Text = "";
                }
                catch (SqlException)
                {
                    MessageBox.Show("Room can't added!!!");
                }
            }

        }


        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            choice = "Search Room";
            dataGridView1.DataSource = manager.ShowRoom(new Classes.Room(txtRoomNumber.Text),choice);
        }

        private void btnShowRoom_Click(object sender, EventArgs e)
        {
            choice = "Show All Room";
            dataGridView1.DataSource = manager.ShowRoom(new Classes.Room(),choice);
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomno.Text == "" || cmbRoomtype.Text == "" || cmbRoomsize.Text == "" || txtrent.Text == "")
            {
                MessageBox.Show("Please fill every box!!!");
            }
            else
            {
                try
                {
                    choice = "Update Room";
                    manager.Managerooms(new Classes.Room(txtRoomno.Text.Trim(), cmbRoomtype.Text.Trim(), cmbRoomsize.Text.Trim(), txtrent.Text.Trim()),choice);
                    txtRoomno.Text = "";
                    cmbRoomtype.Text = "";
                    cmbRoomsize.Text = "";
                    txtrent.Text = "";
                }
                catch (SqlException)
                {
                    MessageBox.Show("Room can't be updated!!");
                    txtRoomno.Text = "";
                    cmbRoomtype.Text = "";
                    cmbRoomsize.Text = "";
                    txtrent.Text = "";
                }
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomno.Text == "")
            {
                MessageBox.Show("Please enter room No!!!");
            }
            else
            {
                try
                {
                    choice = "Delete Room";
                    manager.Managerooms(new Classes.Room(txtRoomno.Text.Trim()),choice);
                    txtRoomno.Text = "";
                }
                catch (SqlException)
                {
                    MessageBox.Show("Room can't be Deleted !!!");
                    txtRoomno.Text = "";
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
