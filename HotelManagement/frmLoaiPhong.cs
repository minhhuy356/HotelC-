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
    public partial class frmLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        LOAIPHONG _lp;

        bool _them, _sua, _isThongTin = false;
        int _idlp;
        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            _lp = new LOAIPHONG();
            LoadData();
            showHideControl(true);
        }

        void reset()
        {
            txtTenloaiphong.Text = "";
            nudDongia.Value = 0;
            nudSogiuong.Value = 0;
            nudSonguoi.Value = 0;
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
        void LoadData()
        {
            gv_Danhsach.DataSource = _lp.getAll();
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
                tb_LoaiPhong lp = new tb_LoaiPhong();
                lp.TENLOAIPHONG = txtTenloaiphong.Text;
                lp.SOGIUONG = int.Parse(nudSogiuong.Value.ToString());
                lp.SONGUOI = int.Parse(nudSonguoi.Value.ToString());
                lp.DONGIA = int.Parse(nudDongia.Value.ToString());
                _lp.add(lp);
            }
            else
            {
                if (_idlp != null)
                {
                    tb_LoaiPhong lp = new tb_LoaiPhong();
                    lp.IDLOAIPHONG = _idlp;
                    lp.TENLOAIPHONG = txtTenloaiphong.Text;
                    lp.SOGIUONG = int.Parse(nudSogiuong.Value.ToString());
                    lp.SONGUOI = int.Parse(nudSonguoi.Value.ToString());
                    lp.DONGIA = int.Parse(nudDongia.Value.ToString());

                    _lp.update(lp);
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
            if (MessageBox.Show("Bạn có chắc muốn xóa " + _idlp + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _lp.delete(_idlp);
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
            reset();
            _them = true;
            showHideControl(false);
        }

        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _idlp = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDLOAIPHONG").ToString());
                txtTenloaiphong.Text = gvDanhsach.GetFocusedRowCellValue("TENLOAIPHONG").ToString();
                nudDongia.Value = int.Parse(gvDanhsach.GetFocusedRowCellValue("DONGIA").ToString());
                nudSogiuong.Value = int.Parse(gvDanhsach.GetFocusedRowCellValue("SOGIUONG").ToString());
                nudSonguoi.Value = int.Parse(gvDanhsach.GetFocusedRowCellValue("SONGUOI").ToString());
            }
        }
    }
}