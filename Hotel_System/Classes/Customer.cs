using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;
using System.Data;

namespace Hotel_System.Classes
{
    class Customer
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        

        public Customer() { }
        public Customer(string Id) { this.Id = Id; }
        public Customer(string Id, string Name) { this.Id = Id; this.Name = Name; }
        public Customer(string Id, string Name, string PhoneNo, string Address)
        {
            this.Id = Id;
            this.Name = Name;
            this.PhoneNo = PhoneNo;
            this.Address = Address;
        }

        public void addGuest(string Id, string Name, string PhoneNo,string Address)
        {
            string query = "INSERT INTO Guest VALUES(@Id,@Name,@PhoneNo,@Address)";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
            cmd.Parameters.AddWithValue("@Address", Address);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Guest added successfully!!!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Guest can't added!!!");
            }
        }
        public void deleteGuest(string Id)
        {
            string query = "DELETE FROM Guest WHERE Id = @Id";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", Id);


            string query2 = "SELECT Id FROM Guest WHERE Id = @Id";
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            cmd2.Parameters.AddWithValue("@Id", Id);
            SqlDataReader read;
            read = cmd2.ExecuteReader();

            if (read.Read())
            {
                read.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Guest Deleted Successfully!!!");
            }
            else
            {

                MessageBox.Show("Guest can't be Exists !!!");
            }
        }
        public DataTable searchGuest(string Id)
        {
            string query = "SELECT * FROM Guest WHERE Id = @ID";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", Id);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public void updateGuest(string Id, string Name, string PhoneNo, string Address)
        {
            string query1 = "UPDATE Guest SET Name = @Name, PhoneNo = @PhoneNo, Address = @Address WHERE Id = @Id";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd1 = new SqlCommand(query1, connection);

            cmd1.Parameters.AddWithValue("@Id", Id);
            cmd1.Parameters.AddWithValue("@Name", Name);
            cmd1.Parameters.AddWithValue("@PhoneNo", PhoneNo);
            cmd1.Parameters.AddWithValue("@Address", Address);

            string query2 = "SELECT Id FROM Guest WHERE Id = @Id";
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            cmd2.Parameters.AddWithValue("@Id", Id);
            SqlDataReader read;
            read = cmd2.ExecuteReader();

            if (read.Read())
            {
                read.Close();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Guest Updated Successfully!!!");
            }
            else
            {
                MessageBox.Show("Guest can't be Exists !!!");
            }
        }
        public DataTable showGuest()
        {
            string query = "SELECT * FROM Guest";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public string totalGuest()
        {
            string query = "SELECT COUNT(*) FROM Guest";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            return cmd.ExecuteScalar().ToString();
        }
    }
    }

