using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmKetNoiDB : Form
    {
        public frmKetNoiDB()
        {
            InitializeComponent();
        }

        SqlConnection GetCon(string server, string username, string passwd, string database)
        {
            return new SqlConnection("Data Source=" + server + "; Initial Catalog=" + database + "; User ID=" + username + "; Password=" + passwd + ";");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            SqlConnection con = GetCon(txt_Server.Text, txt_Username.Text, txt_Password.Text, cbx_Database.Text);
            try
            {
                con.Open();
                MessageBox.Show("Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Fail");
            }
        }



        private void cbx_Database_MouseClick_1(object sender, MouseEventArgs e)
        {
            cbx_Database.Items.Clear();
            if (txt_Username.Text == "" && txt_Server.Text == "" && txt_Password.Text == "")
            {
                MessageBox.Show("Nhập username| server | passwd!", "Notification");

            }
            else
            {
                string conn = @"server=" + txt_Server.Text + "; User ID=" + txt_Username.Text + "; pwd=" + txt_Password.Text + ";";
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string qr = "SELECT NAME FROM SYS.DATABASES";
                SqlCommand cmd = new SqlCommand(qr, con);
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbx_Database.Items.Add(dr[0].ToString());
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string svEncrypt = txt_Server.Text;
            string usEncrypt = txt_Username.Text;
            string pwEncrypt = txt_Password.Text;
            string dbEncrypt = cbx_Database.Text;

            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Chose location save";
            sf.Filter = "Text Files (*.dba)|*.dba| AllFiles(*.*)|*.*"; //loc file

            if (sf.ShowDialog() == DialogResult.OK)
            {
                connect cn = new connect(svEncrypt, usEncrypt, pwEncrypt, dbEncrypt);
                cn.ConnectData(sf.FileName);
                MessageBox.Show("Save success!", "Notification");

            }
        }
    }
}
