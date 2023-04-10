using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_System.Classes
{
    public class Room
    {
        public string roomNumber { get; set; }
        public string roomType { get; set; }
        public string roomSize { get; set; }
        public string dailyRent { get; set; }
        public string roomStatus { get; set; }
        public Room() { }
        public Room(string roomNumber) { this.roomNumber = roomNumber; }
        public Room(string roomNumber, string roomType, string roomSize, string dailyRent)
        {
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.roomSize = roomSize;
            this.dailyRent = dailyRent;
        }

        public void addRoom(string roomNumber, string roomType, string roomSize, string dailyRent)
        {
            string query = "INSERT INTO Room(RoomNo,RoomType,Roomsize,dailyRent) VALUES(@roomNumber,@roomType,@roomSize,@dailyRent)";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
            cmd.Parameters.AddWithValue("@roomType", roomType);
            cmd.Parameters.AddWithValue("@roomSize", roomSize);
            cmd.Parameters.AddWithValue("@dailyRent", dailyRent);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room added successfully!!!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Room can't added!!!");
            }
        }

        public void deleteRoom(string roomNumber)
        {
            string query = "DELETE FROM Room WHERE RoomNo = @roomNumber";
                SqlConnection connection = connct.Connection();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@roomNumber", roomNumber);


                string query2 = "SELECT RoomNo FROM Room WHERE RoomNo = @RoomNo";
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                cmd2.Parameters.AddWithValue("@RoomNo", roomNumber);
                SqlDataReader read;
                read = cmd2.ExecuteReader();
                
                    if (read.Read())
                    {
                        read.Close();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Room Deleted Successfully!!!");
                    }
                    else
                    {

                        MessageBox.Show("Room can't be Exists !!!");
                    }
}

        public DataTable searchRoom(string roomNumber)
        {
            string query = "SELECT * FROM Room WHERE RoomNo = @roomNumber";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable showRoom()
        {
            string query = "SELECT * FROM Room";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public string totalRoom()
        {
            string query = "SELECT COUNT(*) FROM Room";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            return cmd.ExecuteScalar().ToString(); 
        }

        public void updateRoom(string roomNumber, string roomType, string roomSize, string dailyRent)
        {
                string query1 = "UPDATE Room SET RoomType = @RoomType, Roomsize = @Roomsize, dailyRent = @dailyRent WHERE RoomNo = @RoomNo";
                SqlConnection connection = connct.Connection();
                SqlCommand cmd1 = new SqlCommand(query1, connection);

                cmd1.Parameters.AddWithValue("@RoomNo", roomNumber);
                cmd1.Parameters.AddWithValue("@RoomType", roomType);
                cmd1.Parameters.AddWithValue("@Roomsize", roomSize);
                cmd1.Parameters.AddWithValue("@dailyRent", dailyRent);

                string query2 = "SELECT RoomNo FROM Room WHERE RoomNo = @RoomNo";
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                cmd2.Parameters.AddWithValue("@RoomNo", roomNumber);
                SqlDataReader read;
                read = cmd2.ExecuteReader();
                
                    if (read.Read())
                    {
                        read.Close();
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Room Updated Successfully!!!");
                    }
                    else
                    {
                        MessageBox.Show("Room can't be Exists !!!");
                    }
        }



        public DataTable checkAvailability(string roomNumber)
        {
            string query = "SELECT * FROM Room WHERE roomStatus = 'Available' AND RoomNo = @roomNumber";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
    }
    }

