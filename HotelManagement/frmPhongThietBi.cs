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
    public partial class frmPhongThietBi : DevExpress.XtraEditors.XtraForm
    {
        public frmPhongThietBi()
        {
            InitializeComponent();
        }
        THIETBI_PHONG _tbp;
        THIETBI _tb;
        PHONG _p;

        bool _them, _sua, _isThongTin = false;
        int _idtb, _idp;
        bool _gt;
        bool clickGV = true;
        string valueP, valueTB;
        private void frmPhongThietBi_Load(object sender, EventArgs e)
        {
            _tbp = new THIETBI_PHONG();
            _tb = new THIETBI();
            _p = new PHONG();

        }

        private void gv_Danhsach_Load(object sender, EventArgs e)
        {

            loadData();
            loadCbxTB();
            loadCbxP();
            showHideControl(true);
            cbxThietbi.SelectedIndex = -1;
            cbxPhong.SelectedIndex = -1;
        }
        void loadData()
        {
            gv_Danhsach.DataSource = _tbp.getAll();
            gvDanhsach.OptionsBehavior.Editable = false;

        }
        void loadCbxTB()
        {
            cbxThietbi.DataSource = _tb.getAll();
            cbxThietbi.DisplayMember = "TENTB";
            cbxThietbi.ValueMember = "IDTB";
        }
        void loadCbxP()
        {
            cbxPhong.DataSource = _p.getAll();
            cbxPhong.DisplayMember = "TENPHONG";
            cbxPhong.ValueMember = "IDPHONG";
            
        }
        private void cbxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (clickGV)
            {
                clickGV = false;
            }
            else
            {
                if (cbxPhong.SelectedIndex != -1)
                {
                    valueP = cbxPhong.SelectedValue.ToString();
                    if (cbxThietbi.SelectedIndex != -1)
                    {
                        gv_Danhsach.DataSource = _tbp.getPorTB(valueP , cbxPhong.SelectedValue.ToString());
                    }
                    else
                    {
                        gv_Danhsach.DataSource = _tbp.getByP(cbxPhong.SelectedValue.ToString());
                    }
  
                    
                }
                else
                {
                    loadData();
                }

            }
            clickGV = true;
        }
        private void cbxThietbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clickGV)
            {
                clickGV = false;
            }
            else
            {
                if (cbxThietbi.SelectedIndex != -1)
                {
                    valueTB = cbxThietbi.SelectedValue.ToString();
                    if (cbxPhong.SelectedIndex != -1)
                    {
                        gv_Danhsach.DataSource = _tbp.getPorTB( cbxPhong.SelectedValue.ToString(), valueTB);
                    }
                    else
                    {
                        gv_Danhsach.DataSource = _tbp.getByTB(cbxThietbi.SelectedValue.ToString());
                    }
                    
                }
                else
                {
                    loadData();
                }
            }
            clickGV = true;
        }
        void reset()
        {
            cbxPhong.SelectedIndex= -1;
            cbxThietbi.SelectedIndex = -1;
            nudSoluong.Value = 0;
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
            if (nudSoluong.Value == 0)
            {
                MessageBox.Show("Số lượng không được là 0!");
            }
            else
            {
                if (_them)
                {
                    tb_Phong_ThietBi tbp = new tb_Phong_ThietBi();
                    tbp.IDPHONG = int.Parse(cbxPhong.SelectedValue.ToString());
                    tbp.IDTB = int.Parse(cbxThietbi.SelectedValue.ToString());
                    tbp.SOLUONG = int.Parse(nudSoluong.Value.ToString());
                    _tbp.add(tbp);
                }
                else
                {
                    if (_idp != null && _idtb != null)
                    {
                        tb_Phong_ThietBi tbp = new tb_Phong_ThietBi();
                        tbp.IDPHONG = int.Parse(cbxPhong.SelectedValue.ToString());
                        tbp.IDTB = int.Parse(cbxThietbi.SelectedValue.ToString());
                        tbp.SOLUONG = int.Parse(nudSoluong.Value.ToString());
                        _tbp.update(tbp);
                    }
                }
                reset();
                _sua = false;
                _them = false;
                loadData();
                showHideControl(true);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa phòng " + _idtb + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _tbp.delete(_idtb,_idp);
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
            clickGV = true;
            if (gvDanhsach.RowCount > 0 )
            {
                _idtb = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDTB").ToString());
                _idp = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDPHONG").ToString());
                cbxThietbi.SelectedValue = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDTB").ToString());
                cbxPhong.SelectedValue = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDPHONG").ToString());
                nudSoluong.Value = int.Parse(gvDanhsach.GetFocusedRowCellValue("SOLUONG").ToString());
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