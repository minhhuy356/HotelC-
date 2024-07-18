using BusinessLogic;
using DataLayer;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class frmDatPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmDatPhong()
        {
            InitializeComponent();
            DataTable tb = myFuntions.getData("select p.IDPHONG, p.TENPHONG, p.IDTANG, t.TENTANG,lp.DONGIA from tb_Phong p, tb_Tang t, tb_LoaiPhong lp\r\nwhere p.IDTANG = t.IDTANG AND p.IDLOAIPHONG = lp.IDLOAIPHONG AND p.STATUS = 0");
  
            gcPhong.DataSource = tb;
            gcDatphong.DataSource = tb.Clone();
        }
        DATPHONG _dp;
        KHACHHANG _kh;
        SANPHAM _sp;
        List<OBJ_SP> lstSP;


        bool _them, _sua, _isThongTin = false;
        int  _iddp = 0;
        bool _gt, _clickGV = true;

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            _kh = new KHACHHANG();
            _sp = new SANPHAM();
            lstSP = new List<OBJ_SP>();

            dtpNgaydat.Value = myFuntions.GetFirstDayInMonth(DateTime.Now.Year, DateTime.Now.Month);
            dtpNgaytra.Value = DateTime.Now;

            loadKH();
            loadSP();
            cbxTrangthai.DataSource = TRANGTHAI.getList();
            cbxTrangthai.DisplayMember = "_display";
            cbxTrangthai.ValueMember = "_value";

            cbxKhachhang.SelectedIndex = -1;
            showHideControl(true);
            enable(false);
            gvPhong.ExpandAllGroups();
            tabAll.SelectedTabPage = tcDanhsach;
        }
        void loadKH()
        {
            cbxKhachhang.DataSource = _kh.getAll();
            cbxKhachhang.DisplayMember = "HOTEN";
            cbxKhachhang.ValueMember = "IDKH";
        }
        void loadSP()
        {
            gcSanpham.DataSource = _sp.getAll();
            gvSanpham.OptionsBehavior.Editable = false;
        }
        void enable(bool t)
        {
            cbxKhachhang.Enabled = t;
            btnThem.Enabled = t;
            dtpNgaydat.Enabled = t;
            dtpNgaytra.Enabled = t;
            cbxTrangthai.Enabled = t;
            nudSonguoi.Enabled = t;
            txtGhichu.Enabled = t;  
            checkTheodoan.Enabled = t;
            txtThanhtien.Enabled = t;
        }
        void reset()
        {
            cbxKhachhang.SelectedValue = false;
            nudSonguoi.Value = 1;
            dtpNgaydat.Value = DateTime.Now;
            dtpNgaytra .Value = DateTime.Now.AddDays(1);
            checkTheodoan.Checked = false;
            txtThanhtien.Text = "0";
            txtThanhtien.Text = "";
            cbxTrangthai.SelectedValue = false;
        }
        void showHideControl(bool t)
        {
            btn_Them.Visible = t;
            btn_Sua.Visible = t;
            btn_Xoa.Visible = t;
            btn_In.Visible = t;
            btn_Thoat.Visible = t;
            btn_Luu.Visible = !t;
            btn_Boqua.Visible = !t;
/*            if (_isThongTin)
            {
                groupThongtin.Visible = t;
            }
            else
            {
                groupThongtin.Visible = !t;
            }*/
        }



        private void gcDatphong_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            /*reset();*/
            enable(true);
            _them = true;
            showHideControl(false);
            tabAll.SelectedTabPage = tcChitiet;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            enable(true);
            _sua = true;
            _them = false;
            showHideControl(false);
            tabAll.SelectedTabPage = tcChitiet;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa phòng " + _iddp + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _dp.delete(_iddp);
            }
/*            loadData();*/
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            /*                if (_them)
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
                            showHideControl(true);*/
            _sua = false;
            _them = false;
            enable(false);
            showHideControl(true);
            tabAll.SelectedTabPage = tcDanhsach;
        }

        private void btn_Boqua_Click(object sender, EventArgs e)
        {
            _sua = false;
            _them = false;
            enable(false);
            showHideControl(true);
            tabAll.SelectedTabPage = tcDanhsach;
        }

        private void btn_In_Click(object sender, EventArgs e)
        {

        }
     
        int _idPhong;
        string _tenPhong;
        GridHitInfo downHitInfo = null;
        private void gvDatphong_MouseDown(object sender, MouseEventArgs e)
        {
            if(gvDatphong.GetFocusedRowCellValue("IDPHONG") != null)
            {
                _idPhong = int.Parse(gvDatphong.GetFocusedRowCellValue("IDPHONG").ToString());
                _tenPhong = gvDatphong.GetFocusedRowCellValue("TENPHONG").ToString();
            }
            GridView view = sender as GridView;
            downHitInfo = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if(e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
            {
                downHitInfo = hitInfo;
            }
        }
        private void gvDatphong_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if(e.Button == MouseButtons.Left && downHitInfo !=null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2, downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);
                if(!dragRect.Contains(new Point(e.X, e.Y)))
                { 
                    DataRow row = view.GetDataRow(downHitInfo.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }
        private void gvPhong_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys == Keys.None) return;
                if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
            {
                downHitInfo = hitInfo;
            }
        }
        private void gvPhong_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2, downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfo.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void gcPhong_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            DataTable table = grid.DataSource as DataTable;
            DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;
            if(row!= null && table != null && row.Table != table)
            {
                table.ImportRow(row); 
                row.Delete();
            }
        }

        private void gvPhong_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvSPDV.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if(e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 _With = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_With, gvPhong); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _With = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate{ cal(_With, gvPhong); }));
            }
        }
        bool cal(Int32 _With, GridView _view)
        {
            _view.IndicatorWidth = _view.IndicatorWidth < _With ? _With : _view.IndicatorWidth;
            return true;
        }

        private void gvPhong_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view =  sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            string caption = info.Column.Caption;
            if(info.Column.Caption == string.Empty)
            {
                caption= info.Column.ToString();
            }
            info.GroupText = string.Format("{0}: {1} ({2} Phòng trống)", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle));
        }

        private void gcSanpham_DoubleClick(object sender, EventArgs e)
        {
            if(_idPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                return;
            }
            if (gvSanpham.GetFocusedRowCellValue("IDSP")!= null)
            {   
                OBJ_SP sp = new OBJ_SP();
                sp.IDSP = int.Parse(gvSanpham.GetFocusedRowCellValue("IDSP").ToString());
                sp.TENSP = gvSanpham.GetFocusedRowCellValue("TENSP").ToString();
                sp.IDPHONG = _idPhong;
                sp.TENPHONG = _tenPhong;
                sp.DONGIA = float.Parse(gvSanpham.GetFocusedRowCellValue("DONGIA").ToString());
                sp.SOLUONG = 1;
                sp.THANHTIEN = sp.DONGIA * sp.SOLUONG;
                foreach(var item in lstSP)
                {
                    if(item.IDSP == sp.IDSP && item.IDPHONG == sp.IDPHONG)
                    {
                        item.SOLUONG = item.SOLUONG + 1;
                        item.THANHTIEN = item.SOLUONG * item.DONGIA;
                        loadSPDV();
                        return;
                    }
                }
                lstSP.Add(sp);

            }
            loadSPDV();
            txtThanhtien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + double.Parse(gvDatphong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString())).ToString("N0");
        }
        void loadSPDV()
        {
            List<OBJ_SP> lsSP = new List<OBJ_SP>();
            foreach(var item in lstSP)
            {
                lsSP.Add(item);
            }
            gcSPDV.DataSource = lsSP;
        }


        private void gcPhong_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            /*      loadData();*/
        }
        private void gvDatphong_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SOLUONG")
            {
                int sl = int.Parse(e.Value.ToString());
                if (sl != 0)
                {
                    double gia = double.Parse(gvSPDV.GetRowCellValue(gvSPDV.FocusedRowHandle, "DONGIA").ToString());
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "THANHTIEN", sl * gia);
                }
                else
                {
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "THANHTIEN", 0);
                }
            }
            gvSPDV.UpdateGroupSummary();
            txtThanhtien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + double.Parse(gvDatphong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString())).ToString();
        }
        private void gvDatphong_RowCountChanged(object sender, EventArgs e)
        {
            double t = 0;
            if (gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue == null)
            {
                t = 0;
            }
            else
            {
                t = double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString());
            }
            txtThanhtien.Text = (double.Parse(gvDatphong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString()) +t).ToString("N0");
        }
    }
}