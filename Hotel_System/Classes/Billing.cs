using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_System.Classes

{
    class Billing
    {
        public string payment(string column)
        {
            string query = "EXEC usp_GetColumnData @column, 1";            
            SqlConnection connection = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@column", column);
            return cmd.ExecuteScalar().ToString();
        }
        public string TotalBill()
        {
            string query = "EXEC showTotalBill 3";
            SqlConnection con = connct.Connection();
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteScalar().ToString();

       }

    }
}
