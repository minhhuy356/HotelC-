namespace HotelManagement
{
    partial class frmPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.btn_Sua = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_Luu = new System.Windows.Forms.ToolStripButton();
            this.btn_Boqua = new System.Windows.Forms.ToolStripButton();
            this.btn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.btnShowAll = new System.Windows.Forms.ToolStripButton();
            this.groupThongtin = new DevExpress.XtraEditors.GroupControl();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gv_Danhsach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTang = new System.Windows.Forms.ComboBox();
            this.cbxLoaiphong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkTrangthai = new DevExpress.XtraEditors.CheckEdit();
            this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENTANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongtin)).BeginInit();
            this.groupThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Danhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTrangthai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Them,
            this.btn_Sua,
            this.btn_Xoa,
            this.btn_Luu,
            this.btn_Boqua,
            this.btn_Thoat,
            this.btnShowAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(802, 47);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Them
            // 
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(50, 44);
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(38, 44);
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(39, 44);
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(37, 44);
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Boqua
            // 
            this.btn_Boqua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Boqua.Image")));
            this.btn_Boqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Boqua.Name = "btn_Boqua";
            this.btn_Boqua.Size = new System.Drawing.Size(60, 44);
            this.btn_Boqua.Text = "Bỏ qua";
            this.btn_Boqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Boqua.Click += new System.EventHandler(this.btn_Boqua_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(51, 44);
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowAll.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAll.Image")));
            this.btnShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(29, 44);
            this.btnShowAll.Text = "All";
            this.btnShowAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // groupThongtin
            // 
            this.groupThongtin.Controls.Add(this.checkTrangthai);
            this.groupThongtin.Controls.Add(this.cbxLoaiphong);
            this.groupThongtin.Controls.Add(this.label3);
            this.groupThongtin.Controls.Add(this.cbxTang);
            this.groupThongtin.Controls.Add(this.label1);
            this.groupThongtin.Controls.Add(this.txtTenphong);
            this.groupThongtin.Controls.Add(this.label2);
            this.groupThongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupThongtin.Location = new System.Drawing.Point(0, 292);
            this.groupThongtin.Name = "groupThongtin";
            this.groupThongtin.Size = new System.Drawing.Size(802, 177);
            this.groupThongtin.TabIndex = 8;
            this.groupThongtin.Text = "Thông tin";
            this.groupThongtin.Visible = false;
            // 
            // txtTenphong
            // 
            this.txtTenphong.Location = new System.Drawing.Point(139, 43);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(472, 22);
            this.txtTenphong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phòng";
            // 
            // gv_Danhsach
            // 
            this.gv_Danhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Danhsach.Location = new System.Drawing.Point(0, 47);
            this.gv_Danhsach.MainView = this.gvDanhsach;
            this.gv_Danhsach.Name = "gv_Danhsach";
            this.gv_Danhsach.Size = new System.Drawing.Size(802, 245);
            this.gv_Danhsach.TabIndex = 9;
            this.gv_Danhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhsach});
            this.gv_Danhsach.Load += new System.EventHandler(this.gv_Danhsach_Load);
            this.gv_Danhsach.Click += new System.EventHandler(this.gv_Danhsach_Click);
            // 
            // gvDanhsach
            // 
            this.gvDanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENPHONG,
            this.TRANGTHAI,
            this.TENTANG,
            this.TENLOAIPHONG});
            this.gvDanhsach.GridControl = this.gv_Danhsach;
            this.gvDanhsach.Name = "gvDanhsach";
            this.gvDanhsach.OptionsEditForm.PopupEditFormWidth = 914;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tầng";
            // 
            // cbxTang
            // 
            this.cbxTang.FormattingEnabled = true;
            this.cbxTang.Location = new System.Drawing.Point(139, 87);
            this.cbxTang.Name = "cbxTang";
            this.cbxTang.Size = new System.Drawing.Size(472, 24);
            this.cbxTang.TabIndex = 5;
            // 
            // cbxLoaiphong
            // 
            this.cbxLoaiphong.FormattingEnabled = true;
            this.cbxLoaiphong.Location = new System.Drawing.Point(139, 128);
            this.cbxLoaiphong.Name = "cbxLoaiphong";
            this.cbxLoaiphong.Size = new System.Drawing.Size(472, 24);
            this.cbxLoaiphong.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại phòng";
            // 
            // checkTrangthai
            // 
            this.checkTrangthai.Location = new System.Drawing.Point(649, 44);
            this.checkTrangthai.Name = "checkTrangthai";
            this.checkTrangthai.Properties.Caption = "Đã cho thuê";
            this.checkTrangthai.Size = new System.Drawing.Size(94, 21);
            this.checkTrangthai.TabIndex = 8;
            // 
            // TENPHONG
            // 
            this.TENPHONG.Caption = "Tên phòng";
            this.TENPHONG.FieldName = "TENPHONG";
            this.TENPHONG.MinWidth = 25;
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.Visible = true;
            this.TENPHONG.VisibleIndex = 0;
            this.TENPHONG.Width = 94;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.Caption = "Trạng thái";
            this.TRANGTHAI.FieldName = "TRANGTHAI";
            this.TRANGTHAI.MinWidth = 25;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = true;
            this.TRANGTHAI.VisibleIndex = 1;
            this.TRANGTHAI.Width = 94;
            // 
            // TENTANG
            // 
            this.TENTANG.Caption = "Tầng";
            this.TENTANG.FieldName = "TENTANG";
            this.TENTANG.MinWidth = 25;
            this.TENTANG.Name = "TENTANG";
            this.TENTANG.Visible = true;
            this.TENTANG.VisibleIndex = 2;
            this.TENTANG.Width = 94;
            // 
            // TENLOAIPHONG
            // 
            this.TENLOAIPHONG.Caption = "Loại phòng";
            this.TENLOAIPHONG.FieldName = "TENLOAIPHONG";
            this.TENLOAIPHONG.MinWidth = 25;
            this.TENLOAIPHONG.Name = "TENLOAIPHONG";
            this.TENLOAIPHONG.Visible = true;
            this.TENLOAIPHONG.VisibleIndex = 3;
            this.TENLOAIPHONG.Width = 94;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 469);
            this.Controls.Add(this.gv_Danhsach);
            this.Controls.Add(this.groupThongtin);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPhong";
            this.Text = "Danh mục phòng";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongtin)).EndInit();
            this.groupThongtin.ResumeLayout(false);
            this.groupThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Danhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTrangthai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Them;
        private System.Windows.Forms.ToolStripButton btn_Sua;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripButton btn_Luu;
        private System.Windows.Forms.ToolStripButton btn_Boqua;
        private System.Windows.Forms.ToolStripButton btn_Thoat;
        private System.Windows.Forms.ToolStripButton btnShowAll;
        private DevExpress.XtraEditors.GroupControl groupThongtin;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gv_Danhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhsach;
        private System.Windows.Forms.ComboBox cbxLoaiphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTang;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit checkTrangthai;
        private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TRANGTHAI;
        private DevExpress.XtraGrid.Columns.GridColumn TENTANG;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAIPHONG;
    }
}