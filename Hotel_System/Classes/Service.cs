using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Hotel_System.Classes
{
    class Service
    {
        public string serviceId { get; set; }
        public string serviceType { get; set; }
        public string servicePrice { get; set; }
        public Service() { }
        public Service(string serviceId) { this.serviceId = serviceId; }
        public Service(string serviceId, string serviceType, string servicePrice)
        {
            this.serviceId = serviceId;
            this.serviceType = serviceType;
            this.servicePrice = servicePrice;
        }

        public void addService(string serviceId, string serviceType, string servicePrice)
        {
            string query = "INSERT INTO Service(serviceId,serviceType,servicePrice) VALUES(@serviceId,@serviceType,@servicePrice)";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@serviceId", serviceId);
            cmd.Parameters.AddWithValue("@serviceType", serviceType);
            cmd.Parameters.AddWithValue("@servicePrice", servicePrice);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Services added Succesfully!!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Services can't be added!!!");
            }
        }

        public void deleteService(string serviceId)
        {
            string query = "DELETE FROM Service WHERE serviceId = @serviceId";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@serviceId", serviceId);


            string query2 = "SELECT serviceId FROM Service WHERE serviceId = @serviceId";
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            cmd2.Parameters.AddWithValue("@serviceId", serviceId);
            SqlDataReader read;
            read = cmd2.ExecuteReader();

            if (read.Read())
            {
                read.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Service deleted Sucessfully");
            }
            else
            {

                MessageBox.Show("Service not Exists !!!");
            }
        }

        public DataTable searchService(string serviceId)
        {
            string query = "SELECT * FROM Service WHERE serviceId = @serviceId";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@serviceId", serviceId);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable showService()
        {
            string query = "SELECT * FROM Service";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }


        public void updateService(string serviceId, string serviceType, string servicePrice)
        {
            string query1 = "UPDATE Service SET serviceId = @serviceId,serviceType= @serviceType, servicePrice = @servicePrice WHERE serviceId = @serviceId";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd1 = new SqlCommand(query1, connection);

            cmd1.Parameters.AddWithValue("@serviceId", serviceId);
            cmd1.Parameters.AddWithValue("@serviceType", serviceType);
            cmd1.Parameters.AddWithValue("@servicePrice", servicePrice);


            string query2 = "SELECT serviceId FROM Service WHERE serviceId = @serviceId";
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            cmd2.Parameters.AddWithValue("@serviceId", serviceId);
            SqlDataReader read;
            read = cmd2.ExecuteReader();

            if (read.Read())
            {
                read.Close();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Services Updated Successfully!!!");
            }
            else
            {
                MessageBox.Show("Services Not Exists !!!");
            }

        }
        public void provideService(string serviceType, string ReservationNo)
        {
            string query = "UPDATE Reservation SET serviceId = (SELECT serviceId FROM Service WHERE serviceType = @serviceType) WHERE ReservationNo = @ReservationNo";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@serviceType", serviceType);
            cmd.Parameters.AddWithValue("@ReservationNo", ReservationNo);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Services Provided");
            }
            catch (SqlException)
            {
                MessageBox.Show("Services not Provided");
            }

        }
    }
}
