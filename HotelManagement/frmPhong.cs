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
    public partial class frmPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        PHONG _p;
        TANG _t;
        LOAIPHONG _lp;

        bool _them, _sua, _isThongTin = false;
        int _idp;
        bool _gt;
        private void frmPhong_Load(object sender, EventArgs e)
        {
            _p = new PHONG();
            _t = new TANG();
            _lp = new LOAIPHONG();
        }
        private void gv_Danhsach_Load(object sender, EventArgs e)
        {
            loadData();
            loadCbxTang();
            loadCbxLoaiPhong();
            showHideControl(true);
        }
        void loadData()
        {
            gv_Danhsach.DataSource = _p.getAll();
            gvDanhsach.OptionsBehavior.Editable = false;
  
        }
        void loadCbxTang()
        {
            cbxTang.DataSource = _t.getAll();
            cbxTang.DisplayMember = "TENTANG";
            cbxTang.ValueMember= "IDTANG";
            cbxTang.SelectedIndex = -1;
        }
        void loadCbxLoaiPhong()
        {
            cbxLoaiphong.DataSource = _lp.getAll();
            cbxLoaiphong.DisplayMember = "TENLOAIPHONG";
            cbxLoaiphong.ValueMember = "IDLOAIPHONG";
            cbxLoaiphong.SelectedIndex= -1;
        }

        void reset()
        {
            txtTenphong.Text = "";
            cbxLoaiphong.SelectedIndex = -1;
            cbxTang.SelectedIndex = -1;
            checkTrangthai.Checked = false;
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
                tb_Phong p = new tb_Phong();
                p.TENPHONG = txtTenphong.Text;
                p.TRANGTHAI = checkTrangthai.Checked;
                p.IDLOAIPHONG = int.Parse(cbxLoaiphong.SelectedValue.ToString());
                p.IDTANG = int.Parse(cbxTang.SelectedValue.ToString());
                _p.add(p);
            }
            else
            {
                if (_idp != null)
                {
                    tb_Phong p = new tb_Phong();
                    p.IDPHONG = _idp;
                    p.TENPHONG = txtTenphong.Text;
                    p.TRANGTHAI = checkTrangthai.Checked;
                    p.IDLOAIPHONG = int.Parse(cbxLoaiphong.SelectedValue.ToString());
                    p.IDTANG = int.Parse(cbxTang.SelectedValue.ToString());
                    _p.update(p);
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
            if (MessageBox.Show("Bạn có chắc muốn xóa " + _idp + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _p.delete(_idp);
            }
            loadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            _sua = true;
            _them = false;
            showHideControl(false);
        }

        private void gv_Danhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _idp = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDPHONG").ToString());
                txtTenphong.Text = gvDanhsach.GetFocusedRowCellValue("TENPHONG").ToString();
                checkTrangthai.Checked = bool.Parse(gvDanhsach.GetFocusedRowCellValue("TRANGTHAI").ToString());
                cbxLoaiphong.Text = gvDanhsach.GetFocusedRowCellValue("TENLOAIPHONG").ToString();
                cbxTang.Text = gvDanhsach.GetFocusedRowCellValue("TENTANG").ToString();
            }
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            reset();
            _them = true;
            showHideControl(false);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}