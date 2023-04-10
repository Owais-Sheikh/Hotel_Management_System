using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_System.Classes
{
    class Reservation
    {
        public string ReservatonId { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string NoofDays { get; set; }
    
        public Reservation(string ReservatonId)
        {
            this.ReservatonId = ReservatonId;
        }
        public Reservation(string ReservatonId, string CheckIn, string CheckOut, string NoofDays)
        {
            this.ReservatonId = ReservatonId;
            this.CheckIn = CheckIn;
            this.CheckOut = CheckOut;
            this.NoofDays = NoofDays;
        }
        public Reservation()
        {

        }
        public void handleBooking(string reservationId, string roomNo, string Id, string Name, string checkIn, string checkOut, string NoofDays)
        {
            string query1 = "INSERT INTO Reservation(ReservationNo,RoomNo,C_ID,C_Name,Check_In,Check_Out,NoofDays) VALUES(@ReservatonId,@roomNumber,@Id,@Name,@checkIn,@checkOut,@NoofDays)";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query1, connection);
            cmd.Parameters.AddWithValue("@ReservatonId", reservationId);
            cmd.Parameters.AddWithValue("@roomNumber", roomNo);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@checkIn", checkIn);
            cmd.Parameters.AddWithValue("@checkOut", checkOut);
            cmd.Parameters.AddWithValue("@NoofDays", NoofDays);
            string query2 = "UPDATE Room SET roomStatus = 'Occupied' WHERE RoomNo = @roomNumber";
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            cmd2.Parameters.AddWithValue("@roomNumber", roomNo);

            string query3 = "SELECT RoomNo FROM Room WHERE RoomNo = @roomNumber AND roomStatus = 'Available'";
            SqlCommand cmd3 = new SqlCommand(query3, connection);
            cmd3.Parameters.AddWithValue("@roomNumber", roomNo);
            SqlDataReader read;
            read = cmd3.ExecuteReader();
            try
            {
                if (read.Read())
                {
                    read.Close();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Reservation added successfully!!!");
                }
                else
                {
                    MessageBox.Show("Room can't be available");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Reservation can't added!!!");
            }
        }
        public DataTable searchReservation(string reservationId)
        {
            string query = "SELECT * FROM Reservation WHERE ReservationNo = @reservationId";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@reservationId", reservationId);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public void cancelBooking(string ReservationNo)
        {
            string query = "DELETE FROM Reservation WHERE ReservationNo = @ReservationNo";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ReservationNo", ReservationNo);

            string query3 = "UPDATE Room SET roomStatus = 'Available' WHERE RoomNo = (SELECT RoomNo FROM Reservation WHERE ReservationNo = @ReservationNo)";
            SqlCommand cmd3 = new SqlCommand(query3, connection);
            cmd3.Parameters.AddWithValue("@ReservationNo", ReservationNo);

            string query2 = "SELECT ReservationNo FROM Reservation WHERE ReservationNo = @ReservationNo";
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            cmd2.Parameters.AddWithValue("@ReservationNo", ReservationNo);
            SqlDataReader read;
            read = cmd2.ExecuteReader();
            try
            {
                if (read.Read())
                {
                    read.Close();
                    cmd3.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation Cancelled Successfully!!!");
                }
                else
                {

                    MessageBox.Show("Reservation can't be Exists !!!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Reservation can't be Cancelled !!!");
            }

        }

        public void updateBooking(string reservationId, string roomNo, string Id, string Name, string checkIn, string checkOut, string NoofDays)
        {
            string query1 = "UPDATE Reservation SET RoomNo = @roomNo, C_ID = @Id, C_Name = @Name, Check_In = @checkIn, Check_Out = @checkOut, NoofDays = @NoofDays  WHERE ReservationNo = @reservationId";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd1 = new SqlCommand(query1, connection);

            cmd1.Parameters.AddWithValue("@reservationId", reservationId);
            cmd1.Parameters.AddWithValue("@roomNo", roomNo);
            cmd1.Parameters.AddWithValue("@Id", Id);
            cmd1.Parameters.AddWithValue("@Name", Name);
            cmd1.Parameters.AddWithValue("@checkIn", checkIn);
            cmd1.Parameters.AddWithValue("@checkOut", checkOut);
            cmd1.Parameters.AddWithValue("@NoofDays", NoofDays);
            string query2 = "SELECT ReservationNo FROM Reservation WHERE ReservationNo = @reservationId";
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            cmd2.Parameters.AddWithValue("@reservationId", reservationId);
            SqlDataReader read;
            read = cmd2.ExecuteReader();

            if (read.Read())
            {
                read.Close();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Reservation Updated Successfully!!!");
            }
            else
            {
                MessageBox.Show("Reservation can't be Exists !!!");
            }
        }
        public DataTable showReservation()
        {
            string query = "SELECT * FROM Reservation";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public string totalReservation()
        {
            string query = "SELECT COUNT(*) FROM Reservation";
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            return cmd.ExecuteScalar().ToString();
        }
    }
}
