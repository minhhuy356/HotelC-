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
    public partial class frmThietBi : DevExpress.XtraEditors.XtraForm
    {
        public frmThietBi()
        {
            InitializeComponent();
        }
        THIETBI _tb;

        bool _them, _sua, _isThongTin = false;
        int _idtb;
        bool _gt;

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            _tb = new THIETBI();
        }

        private void gv_Danhsach_Load(object sender, EventArgs e)
        {
            loadData();
            showHideControl(true);
        }
        void loadData()
        {
            gv_Danhsach.DataSource = _tb.getAll();
            gvDanhsach.OptionsBehavior.Editable = false;

        }
        void reset()
        {
            txtTenthietbi.Text = "";
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
                tb_ThietBi tb = new tb_ThietBi();
                tb.TENTB = txtTenthietbi.Text.ToString();
                tb.DONGIA = int.Parse(nudDongia.Value.ToString());
                _tb.add(tb);
            }
            else
            {
                if (_idtb != null)
                {
                    tb_ThietBi tb = new tb_ThietBi();
                    tb.IDTB = _idtb;
                    tb.TENTB = txtTenthietbi.Text.ToString();
                    tb.DONGIA = int.Parse(nudDongia.Value.ToString());
                    _tb.update(tb);
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
            if (MessageBox.Show("Bạn có chắc muốn xóa phòng " + _idtb + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _tb.delete(_idtb);
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
                _idtb = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDTB").ToString());
                txtTenthietbi.Text = gvDanhsach.GetFocusedRowCellValue("TENTB").ToString();
                nudDongia.Value = int.Parse(gvDanhsach.GetFocusedRowCellValue("DONGIA").ToString());
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