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
    public partial class frmTang : DevExpress.XtraEditors.XtraForm
    {
        public frmTang()
        {
            InitializeComponent();
        }
        TANG _t;

        bool _them, _sua, _isThongTin = false;
        int _idt;

        private void gv_Tang_Load(object sender, EventArgs e)
        {
            _t = new TANG();
                loadData();
        }
        public void loadData()
        {
            gv_Tang.DataSource = _t.getAll();
            gvTang.OptionsBehavior.Editable = false;
        }
        void reset()
        {
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
            if (_isThongTin)
            {
                groupThongtin.Visible = t;
            }
            else
            {
                groupThongtin.Visible = !t;
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
            if (MessageBox.Show("Bạn có chắc muốn xóa " + txt_Ten.Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _t.delete(_idt);
            }
            loadData();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_Tang t = new tb_Tang();
                t.TENTANG = txt_Ten.Text;

                _t.add(t);
            }
            else
            {
                if (_idt != null)
                {
                    tb_Tang t = _t.getItem(_idt);
                    t.IDTANG = _idt;
                    t.TENTANG = txt_Ten.Text;

                    _t.update(t);
                }
            }
            reset();
            _sua = false;
            _them = false;
            loadData();
            showHideControl(true);
        }

        private void gvTang_Click(object sender, EventArgs e)
        {

            if (gvTang.RowCount > 0)
            {
                _idt = int.Parse(gvTang.GetFocusedRowCellValue("IDTANG").ToString());
                txt_Ten.Text = gvTang.GetFocusedRowCellValue("TENTANG").ToString();
            }
        }


        private void btnShowAll_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_Boqua_Click(object sender, EventArgs e)
        {
            _sua = false;
            _them = false;
            showHideControl(true);
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
           
        }
    }
}