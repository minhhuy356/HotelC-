using BusinessLogic;
using DataLayer;
using DevExpress.XtraEditors;
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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        KHACHHANG _kh;

        bool _them, _sua, _isThongTin = false;
        int _idkh;
        bool _gt;
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            _kh = new KHACHHANG();

        }

        void reset()
        {
            txtTen.Text = "";
            txtDienthoai.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            txtCMT.Text = "";
            checkNam.Checked = false;
            checkNu.Checked = false;
        }
        void showHideControl(bool t)
        {
            btn_Them.Visible = t;
            btn_Sua.Visible = t;
            btn_Xoa.Visible = t;
            btn_Thoat.Visible = t;
            btn_Luu.Visible = !t;
            btn_Boqua.Visible = !t;
            if (_isThongTin)
            {
                groupThongtin.Visible = t;
            }
            else
            {
                groupThongtin.Visible = !t;
            }
        }
        void loadData()
        {
            gv_Danhsach.DataSource = _kh.getAll();
            gvDanhsach.OptionsBehavior.Editable = false;
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
                tb_KhachHang kh = new tb_KhachHang();
                kh.DIACHI = txtDiachi.Text;
                kh.HOTEN = txtTen.Text;
                kh.CCCD = txtCMT.Text;
                kh.EMAIL = txtEmail.Text;
                kh.DIENTHOAI = txtDienthoai.Text;
                kh.GIOITINH = _gt;
                _kh.add(kh);
            }
            else
            {
                if (_idkh != null)
                {
                    tb_KhachHang kh = new tb_KhachHang();
                    kh.IDKH = _idkh;
                    kh.DIACHI = txtDiachi.Text;
                    kh.HOTEN = txtTen.Text;
                    kh.CCCD = txtCMT.Text;
                    kh.EMAIL = txtEmail.Text;
                    kh.DIENTHOAI = txtDienthoai.Text;
                    kh.GIOITINH = _gt;
                    _kh.update(kh);
                }
            }
            reset();
            _sua = false;
            _them = false;
            loadData();
            showHideControl(true);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa " + _idkh + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _kh.delete(_idkh);
            }
            loadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            _sua = true;
            _them = false;
            showHideControl(false);
        }

        private void gv_Danhsach_Load(object sender, EventArgs e)
        {
            loadData();
            showHideControl(true);
        }

        private void checkNu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNu.Checked)
            {
                checkNam.Checked = false;
            }
            _gt = false;

        }

        private void checkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNam.Checked)
            {
                checkNu.Checked = false;
            }
            _gt = true;
        }

        private void gv_Danhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _idkh = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDKH").ToString());
                txtDienthoai.Text = gvDanhsach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtCMT.Text = gvDanhsach.GetFocusedRowCellValue("CCCD").ToString();
                txtDiachi.Text = gvDanhsach.GetFocusedRowCellValue("DIACHI").ToString();
                txtEmail.Text = gvDanhsach.GetFocusedRowCellValue("EMAIL").ToString();
                txtTen.Text = gvDanhsach.GetFocusedRowCellValue("HOTEN").ToString();
                if (bool.Parse(gvDanhsach.GetFocusedRowCellValue("GIOITINH").ToString()))
                {
                    checkNam.Checked = true;
                    _gt = true;
                }
                else
                {
                    checkNu.Checked = true;
                    _gt = false;
                }

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            reset();
            _them = true;
            showHideControl(false);
        }


    }
}