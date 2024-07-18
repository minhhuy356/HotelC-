using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class myFuntions
    {
        public static string _srv;
        public static string _us;
        public static string _pw;
        public static string _db;
        static SqlConnection con = new SqlConnection();

        public static void connect()
        {
            con.ConnectionString = @"Data Source =DESKTOP-UGDIVBH\SQLEXPRESS; Initial Catalog =HOTELS; User ID =sa; Password=123456;";
            try
            {
                con.Open();
            }
            catch (Exception)
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
        public static DateTime GetFirstDayInMonth(int year, int month)
        {
            return new DateTime(year, month, 1);
        }
        bool cal(Int32 _With, GridView _view)
        {
            _view.IndicatorWidth = _view.IndicatorWidth < _With ? _With : _view.IndicatorWidth;
            return true;
        }
    }   
}
