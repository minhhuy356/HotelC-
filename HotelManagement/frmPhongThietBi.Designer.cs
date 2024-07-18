namespace HotelManagement
{
    partial class frmPhongThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongThietBi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.btn_Sua = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_Luu = new System.Windows.Forms.ToolStripButton();
            this.btn_Boqua = new System.Windows.Forms.ToolStripButton();
            this.btn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.btnShowAll = new System.Windows.Forms.ToolStripButton();
            this.groupThongtin = new DevExpress.XtraEditors.GroupControl();
            this.cbxThietbi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPhong = new System.Windows.Forms.ComboBox();
            this.nudSoluong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.gv_Danhsach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TENTB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongtin)).BeginInit();
            this.groupThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Danhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhsach)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(905, 47);
            this.toolStrip1.TabIndex = 9;
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
            this.groupThongtin.Controls.Add(this.cbxThietbi);
            this.groupThongtin.Controls.Add(this.label2);
            this.groupThongtin.Controls.Add(this.cbxPhong);
            this.groupThongtin.Controls.Add(this.nudSoluong);
            this.groupThongtin.Controls.Add(this.label1);
            this.groupThongtin.Controls.Add(this.T);
            this.groupThongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupThongtin.Location = new System.Drawing.Point(0, 361);
            this.groupThongtin.Name = "groupThongtin";
            this.groupThongtin.Size = new System.Drawing.Size(905, 91);
            this.groupThongtin.TabIndex = 10;
            this.groupThongtin.Text = "Thông tin";
            this.groupThongtin.Visible = false;
            // 
            // cbxThietbi
            // 
            this.cbxThietbi.FormattingEnabled = true;
            this.cbxThietbi.Location = new System.Drawing.Point(410, 44);
            this.cbxThietbi.Name = "cbxThietbi";
            this.cbxThietbi.Size = new System.Drawing.Size(221, 24);
            this.cbxThietbi.TabIndex = 8;
            this.cbxThietbi.SelectedIndexChanged += new System.EventHandler(this.cbxThietbi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thiết bị";
            // 
            // cbxPhong
            // 
            this.cbxPhong.FormattingEnabled = true;
            this.cbxPhong.Location = new System.Drawing.Point(94, 44);
            this.cbxPhong.Name = "cbxPhong";
            this.cbxPhong.Size = new System.Drawing.Size(214, 24);
            this.cbxPhong.TabIndex = 6;
            this.cbxPhong.SelectedIndexChanged += new System.EventHandler(this.cbxPhong_SelectedIndexChanged);
            // 
            // nudSoluong
            // 
            this.nudSoluong.Location = new System.Drawing.Point(760, 44);
            this.nudSoluong.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudSoluong.Name = "nudSoluong";
            this.nudSoluong.Size = new System.Drawing.Size(86, 22);
            this.nudSoluong.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số lượng";
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Location = new System.Drawing.Point(34, 47);
            this.T.Margin = new System.Windows.Forms.Padding(3, 0, 11, 0);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(46, 16);
            this.T.TabIndex = 2;
            this.T.Text = "Phòng";
            // 
            // gv_Danhsach
            // 
            this.gv_Danhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Danhsach.Location = new System.Drawing.Point(0, 47);
            this.gv_Danhsach.MainView = this.gvDanhsach;
            this.gv_Danhsach.Name = "gv_Danhsach";
            this.gv_Danhsach.Size = new System.Drawing.Size(905, 314);
            this.gv_Danhsach.TabIndex = 11;
            this.gv_Danhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhsach});
            this.gv_Danhsach.Load += new System.EventHandler(this.gv_Danhsach_Load);
            this.gv_Danhsach.Click += new System.EventHandler(this.gv_Danhsach_Click);
            // 
            // gvDanhsach
            // 
            this.gvDanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENTB,
            this.TENPHONG,
            this.SOLUONG});
            this.gvDanhsach.GridControl = this.gv_Danhsach;
            this.gvDanhsach.Name = "gvDanhsach";
            this.gvDanhsach.OptionsEditForm.PopupEditFormWidth = 914;
            // 
            // TENTB
            // 
            this.TENTB.Caption = "Tên thiết bị";
            this.TENTB.FieldName = "TENTB";
            this.TENTB.MinWidth = 25;
            this.TENTB.Name = "TENTB";
            this.TENTB.Visible = true;
            this.TENTB.VisibleIndex = 1;
            this.TENTB.Width = 94;
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
            // SOLUONG
            // 
            this.SOLUONG.Caption = "Số lượng";
            this.SOLUONG.FieldName = "SOLUONG";
            this.SOLUONG.MinWidth = 25;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Visible = true;
            this.SOLUONG.VisibleIndex = 2;
            this.SOLUONG.Width = 94;
            // 
            // frmPhongThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 452);
            this.Controls.Add(this.gv_Danhsach);
            this.Controls.Add(this.groupThongtin);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPhongThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhongThietBi";
            this.Load += new System.EventHandler(this.frmPhongThietBi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongtin)).EndInit();
            this.groupThongtin.ResumeLayout(false);
            this.groupThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Danhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhsach)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudSoluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.ComboBox cbxThietbi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPhong;
        private DevExpress.XtraGrid.GridControl gv_Danhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn TENTB;
        private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONG;
    }
}