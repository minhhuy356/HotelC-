namespace HotelManagement
{
    partial class frmLoaiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiPhong));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.btn_Sua = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_Luu = new System.Windows.Forms.ToolStripButton();
            this.btn_Boqua = new System.Windows.Forms.ToolStripButton();
            this.btn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.groupThongtin = new DevExpress.XtraEditors.GroupControl();
            this.nudDongia = new System.Windows.Forms.NumericUpDown();
            this.nudSogiuong = new System.Windows.Forms.NumericUpDown();
            this.nudSonguoi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenloaiphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gv_Danhsach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TENLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SONGUOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOGIUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongtin)).BeginInit();
            this.groupThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDongia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSogiuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSonguoi)).BeginInit();
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
            this.btn_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(958, 47);
            this.toolStrip1.TabIndex = 5;
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
            this.btn_Thoat.Image = global::HotelManagement.Properties.Resources._out;
            this.btn_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(51, 44);
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // groupThongtin
            // 
            this.groupThongtin.Controls.Add(this.nudDongia);
            this.groupThongtin.Controls.Add(this.nudSogiuong);
            this.groupThongtin.Controls.Add(this.nudSonguoi);
            this.groupThongtin.Controls.Add(this.label1);
            this.groupThongtin.Controls.Add(this.label3);
            this.groupThongtin.Controls.Add(this.label4);
            this.groupThongtin.Controls.Add(this.txtTenloaiphong);
            this.groupThongtin.Controls.Add(this.label2);
            this.groupThongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupThongtin.Location = new System.Drawing.Point(0, 335);
            this.groupThongtin.Name = "groupThongtin";
            this.groupThongtin.Size = new System.Drawing.Size(958, 195);
            this.groupThongtin.TabIndex = 6;
            this.groupThongtin.Text = "Thông tin";
            this.groupThongtin.Visible = false;
            // 
            // nudDongia
            // 
            this.nudDongia.Location = new System.Drawing.Point(565, 60);
            this.nudDongia.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudDongia.Name = "nudDongia";
            this.nudDongia.Size = new System.Drawing.Size(355, 23);
            this.nudDongia.TabIndex = 17;
            // 
            // nudSogiuong
            // 
            this.nudSogiuong.Location = new System.Drawing.Point(565, 97);
            this.nudSogiuong.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudSogiuong.Name = "nudSogiuong";
            this.nudSogiuong.Size = new System.Drawing.Size(355, 23);
            this.nudSogiuong.TabIndex = 16;
            // 
            // nudSonguoi
            // 
            this.nudSonguoi.Location = new System.Drawing.Point(124, 97);
            this.nudSonguoi.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudSonguoi.Name = "nudSonguoi";
            this.nudSonguoi.Size = new System.Drawing.Size(355, 23);
            this.nudSonguoi.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số giường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số người";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn giá";
            // 
            // txtTenloaiphong
            // 
            this.txtTenloaiphong.Location = new System.Drawing.Point(124, 57);
            this.txtTenloaiphong.Name = "txtTenloaiphong";
            this.txtTenloaiphong.Size = new System.Drawing.Size(355, 23);
            this.txtTenloaiphong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại phòng";
            // 
            // gv_Danhsach
            // 
            this.gv_Danhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Danhsach.Location = new System.Drawing.Point(0, 47);
            this.gv_Danhsach.MainView = this.gvDanhsach;
            this.gv_Danhsach.Name = "gv_Danhsach";
            this.gv_Danhsach.Size = new System.Drawing.Size(958, 288);
            this.gv_Danhsach.TabIndex = 7;
            this.gv_Danhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhsach});
            this.gv_Danhsach.Load += new System.EventHandler(this.frmLoaiPhong_Load);
            // 
            // gvDanhsach
            // 
            this.gvDanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENLOAIPHONG,
            this.DONGIA,
            this.SONGUOI,
            this.SOGIUONG});
            this.gvDanhsach.GridControl = this.gv_Danhsach;
            this.gvDanhsach.Name = "gvDanhsach";
            this.gvDanhsach.Click += new System.EventHandler(this.gvDanhsach_Click);
            // 
            // TENLOAIPHONG
            // 
            this.TENLOAIPHONG.Caption = "Tên loại phòng";
            this.TENLOAIPHONG.FieldName = "TENLOAIPHONG";
            this.TENLOAIPHONG.MinWidth = 25;
            this.TENLOAIPHONG.Name = "TENLOAIPHONG";
            this.TENLOAIPHONG.Visible = true;
            this.TENLOAIPHONG.VisibleIndex = 0;
            this.TENLOAIPHONG.Width = 224;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "Đơn giá";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MinWidth = 25;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 3;
            this.DONGIA.Width = 217;
            // 
            // SONGUOI
            // 
            this.SONGUOI.Caption = "Số người";
            this.SONGUOI.FieldName = "SONGUOI";
            this.SONGUOI.MinWidth = 25;
            this.SONGUOI.Name = "SONGUOI";
            this.SONGUOI.Visible = true;
            this.SONGUOI.VisibleIndex = 1;
            this.SONGUOI.Width = 177;
            // 
            // SOGIUONG
            // 
            this.SOGIUONG.Caption = "Số giường";
            this.SOGIUONG.FieldName = "SOGIUONG";
            this.SOGIUONG.MinWidth = 25;
            this.SOGIUONG.Name = "SOGIUONG";
            this.SOGIUONG.Visible = true;
            this.SOGIUONG.VisibleIndex = 2;
            this.SOGIUONG.Width = 203;
            // 
            // frmLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 530);
            this.Controls.Add(this.gv_Danhsach);
            this.Controls.Add(this.groupThongtin);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại phòng";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongtin)).EndInit();
            this.groupThongtin.ResumeLayout(false);
            this.groupThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDongia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSogiuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSonguoi)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupThongtin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenloaiphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gv_Danhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhsach;
        private System.Windows.Forms.NumericUpDown nudSonguoi;
        private System.Windows.Forms.NumericUpDown nudDongia;
        private System.Windows.Forms.NumericUpDown nudSogiuong;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAIPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn SONGUOI;
        private DevExpress.XtraGrid.Columns.GridColumn SOGIUONG;
    }
}