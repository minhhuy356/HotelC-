using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class myClass
    {
        static SqlConnection con = new SqlConnection();

        public static void connect()
        {
            con.ConnectionString = @"Data Source =DESKTOP-UGDIVBH\SQLEXPRESS; Initial Catalog =HOTELS; User ID =sa; Password=123456;";
            try
            {
                con.Open();
            }
            catch(Exception) 
            {
                throw;
            }
        }
        public static void disconnect()
        {
            con.Close();
        }

        public static DataTable getData(string query)
        {
            connect();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            disconnect();
            return dt;
        }
    }
}
