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
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        SANPHAM _sp;


        bool _them, _sua, _isThongTin = false;
        int _idsp;
        bool _gt;
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            _sp = new SANPHAM();
        }
        private void gv_Danhsach_Load(object sender, EventArgs e)
        {
            loadData();
            showHideControl(true);
        }
        void loadData()
        {
            gv_Danhsach.DataSource = _sp.getAll();
            gvDanhsach.OptionsBehavior.Editable = false;

        }

        void reset()
        {
            txtTensanpham.Text = "";
            nudDongia.Value = 0;
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
                tb_SanPham sp = new tb_SanPham();
                sp.TENSP = txtTensanpham.Text;
                sp.DONGIA = double.Parse(nudDongia.Value.ToString());
                _sp.add(sp);
            }
            else
            {
                if (_idsp != null)
                {
                    tb_SanPham sp = new tb_SanPham();
                    sp.IDSP = _idsp;
                    sp.TENSP = txtTensanpham.Text;
                    sp.DONGIA = double.Parse(nudDongia.Value.ToString());
                    _sp.update(sp);
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
            if (MessageBox.Show("Bạn có chắc muốn xóa " + _idsp + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _sp.delete(_idsp);
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
                _idsp = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDSP").ToString());
                txtTensanpham.Text = gvDanhsach.GetFocusedRowCellValue("TENSP").ToString();
                nudDongia.Value = int.Parse(gvDanhsach.GetFocusedRowCellValue("DONGIA").ToString());
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