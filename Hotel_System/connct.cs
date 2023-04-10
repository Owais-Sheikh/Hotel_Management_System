using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_System
{
    public class connct
    {
        public static SqlConnection Connection()
        {
            string strConnect = "Data Source=DESKTOP-28DJHLC;Initial Catalog=Hotel;Integrated Security=True";
            SqlConnection connection = new SqlConnection(strConnect);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in connection!!!");
            }
            return connection;
        }
    }
}