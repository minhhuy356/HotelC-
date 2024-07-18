using BusinessLogic;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask.Design;
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
    public partial class frmDonVi : DevExpress.XtraEditors.XtraForm
    {
        public frmDonVi()
        {
            InitializeComponent();
        }
        DONVI _dvi;
        KHACHSAN _ks;

        bool _them, _sua, _isThongTin = false;
        string _madvi;
        bool clickGV;
        private void gv_DONVI_Load(object sender, EventArgs e)
        {
            _dvi = new DONVI();
            _ks = new KHACHSAN();
            loadData();
            loadKhachSan();
            showHideControl(true);
            cbxCTCN.SelectedIndex = -1;

        }
        void reset()
        {
            txt_MaDVI.Text = "";
            txt_Email.Text = "";
            txt_Dienthoai.Text = "";
            txt_Diachi.Text = "";
            txt_Ten.Text = "";
        }
        void showHideControl(bool t)
        {
            btn_Them.Visible = t;
            btn_Sua.Visible = t;
            btn_Xoa.Visible = t;
            btn_Thoat.Visible = t;
            btn_Luu.Visible = !t;
            btn_Boqua.Visible = !t;
            if (_sua)
            {
                txt_MaDVI.Enabled = false;
            }
            else
            {
                txt_MaDVI.Enabled = true;
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
        void loadData()
        {
            gv_DONVI.DataSource = _dvi.getAll();
            gvDonVi.OptionsBehavior.Editable = false;
         
        }
        void loadKhachSan()
        {
            cbxCTCN.DataSource = _ks.getAll();
            cbxCTCN.DisplayMember = "TENKS";
            cbxCTCN.ValueMember = "MAKS";
        }
        void loadDviByKS()
        {
            if(cbxCTCN.SelectedIndex != -1)
            {
                gv_DONVI.DataSource = _dvi.getAll(cbxCTCN.SelectedValue.ToString());
            }
            else
            {
                loadData();
            }
           
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            _them = true;
            _sua = false;
            showHideControl(false);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            _them = false;
            _sua = true;
            showHideControl(false);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa " + _madvi + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ks.delete(_madvi);
            }
            loadData();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_DonVi dvi = new tb_DonVi();
                dvi.MAKS = cbxCTCN.SelectedValue.ToString();
                dvi.MADVI = txt_MaDVI.Text;
                dvi.TENDVI = txt_Ten.Text;
                dvi.DIACHI = txt_Diachi.Text;
                dvi.DIENTHOAI = txt_Dienthoai.Text;
                dvi.EMAIL = txt_Email.Text;

                _dvi.add(dvi);
            }
            else
            {
                if (txt_MaDVI.Text != "")
                {
                    tb_DonVi dvi = _dvi.getItem(_madvi);
                    dvi.MAKS = cbxCTCN.SelectedValue.ToString();
                    dvi.TENDVI = txt_MaDVI.Text;
                    dvi.TENDVI = txt_Ten.Text;
                    dvi.DIACHI = txt_Diachi.Text;
                    dvi.DIENTHOAI = txt_Dienthoai.Text;
                    dvi.EMAIL = txt_Email.Text;

                    _dvi.update(dvi);
                }
            }
            reset();
            _sua = false;
            _them = false;
            loadData();
            showHideControl(true);
            cbxCTCN.SelectedIndexChanged += cbxCTCN_SelectedIndexChanged;
        }

        private void gvDonVi_Click(object sender, EventArgs e)
        {
            clickGV = true;
            if (gvDonVi.RowCount > 0)
            {
                _madvi = gvDonVi.GetFocusedRowCellValue("MADVI").ToString();
                txt_MaDVI.Text = gvDonVi.GetFocusedRowCellValue("MADVI").ToString();
                txt_Ten.Text = gvDonVi.GetFocusedRowCellValue("TENDVI").ToString();
                txt_Dienthoai.Text = gvDonVi.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txt_Email.Text = gvDonVi.GetFocusedRowCellValue("EMAIL").ToString();
                txt_Diachi.Text = gvDonVi.GetFocusedRowCellValue("DIACHI").ToString();
                cbxCTCN.SelectedValue = gvDonVi.GetFocusedRowCellValue("MAKS").ToString();
            }
        }

        private void cbxCTCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clickGV)
            {
                clickGV = false;
            }
            else
            {
                loadDviByKS();
            }

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            cbxCTCN.SelectedIndex = -1;
            loadData();
        }

        private void btn_Boqua_Click(object sender, EventArgs e)
        {
            _sua = false;
            _them = false;
            showHideControl(true);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}