using BusinessLogic;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmKhachSan : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachSan()
        {
            InitializeComponent();
        }
        KHACHSAN _ks;
        
        bool _them, _sua, _isThongTin = false;
        string _maks;
        private void frmKhachSan_Load(object sender, EventArgs e)
        {
            _ks = new KHACHSAN();
            LoadData();
            showHideControl(true);
        }

        void reset()
        {
            txt_MaKS.Text = "";
            txt_Email.Text = "";
            txt_Dienthoai.Text = "";
            txt_Diachi.Text = "";
            txt_Ten.Text = "";
            check_Disabled.Checked = false;
            
        }
        void showHideControl(bool t)
        {
            btn_Them.Visible = t;
            btn_Sua.Visible = t;
            btn_Xoa.Visible = t;
            btn_Thoat.Visible = t;
            btn_Luu.Visible = !t;
            btn_Boqua.Visible = !t;
            if(_sua )
            {
                txt_MaKS.Enabled = false;
            }
            else
            {
                txt_MaKS.Enabled = true;
            }
            if (_isThongTin)
            {
                groupThongtin.Visible = t;
            }
            else
            {
                groupThongtin.Visible = !t;
            }
        }
        void LoadData()
        {
            gv_DanhSach.DataSource = _ks.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Boqua_Click(object sender, EventArgs e)
        {
            groupThongtin.Visible = false;
            _sua = false;
            _them = false;
            showHideControl(true);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_KhachSan ks = new tb_KhachSan();
                ks.MAKS = txt_MaKS.Text;
                ks.TENKS = txt_Ten.Text;
                ks.DIACHI = txt_Diachi.Text;
                ks.DIENTHOAI = txt_Dienthoai.Text;
                ks.EMAIL = txt_Email.Text;
                ks.DISABLE = check_Disabled.Checked;
                _ks.add(ks);
            }
            else
            {
                if(txt_MaKS.Text != "")
                {
                    tb_KhachSan ks = _ks.getItem(_maks);
                    ks.MAKS = txt_MaKS.Text;
                    ks.TENKS = txt_Ten.Text;
                    ks.DIACHI = txt_Diachi.Text;
                    ks.DIENTHOAI = txt_Dienthoai.Text;
                    ks.EMAIL = txt_Email.Text;
                    ks.DISABLE = check_Disabled.Checked;
                    _ks.update(ks);
                }
            }
            reset();
            _sua = false;
            _them = false;
            LoadData();
            showHideControl(true);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa "+_maks+" không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ks.delete(_maks);
            }
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            _sua = true;
            _them = false;
            showHideControl(false);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            _them = true;
            showHideControl(false);
        }

        private void gv_DanhSach_Click(object sender, EventArgs e)
        {

        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _maks = gvDanhSach.GetFocusedRowCellValue("MAKS").ToString();
                txt_MaKS.Text = gvDanhSach.GetFocusedRowCellValue("MAKS").ToString();
                txt_Ten.Text = gvDanhSach.GetFocusedRowCellValue("TENKS").ToString();
                txt_Dienthoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txt_Email.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                txt_Diachi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
                check_Disabled.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLE").ToString());
            }
        }


    }
}