namespace HotelManagement
{
    partial class frmThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThietBi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.btn_Sua = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_Luu = new System.Windows.Forms.ToolStripButton();
            this.btn_Boqua = new System.Windows.Forms.ToolStripButton();
            this.btn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.groupThongtin = new DevExpress.XtraEditors.GroupControl();
            this.nudDongia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.gv_Danhsach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TENTB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTenthietbi = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongtin)).BeginInit();
            this.groupThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDongia)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(679, 47);
            this.toolStrip1.TabIndex = 10;
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
            // groupThongtin
            // 
            this.groupThongtin.Controls.Add(this.txtTenthietbi);
            this.groupThongtin.Controls.Add(this.nudDongia);
            this.groupThongtin.Controls.Add(this.label1);
            this.groupThongtin.Controls.Add(this.T);
            this.groupThongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupThongtin.Location = new System.Drawing.Point(0, 330);
            this.groupThongtin.Name = "groupThongtin";
            this.groupThongtin.Size = new System.Drawing.Size(679, 91);
            this.groupThongtin.TabIndex = 11;
            this.groupThongtin.Text = "Thông tin";
            this.groupThongtin.Visible = false;
            // 
            // nudDongia
            // 
            this.nudDongia.Location = new System.Drawing.Point(471, 46);
            this.nudDongia.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudDongia.Name = "nudDongia";
            this.nudDongia.Size = new System.Drawing.Size(141, 22);
            this.nudDongia.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đơn giá";
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Location = new System.Drawing.Point(34, 47);
            this.T.Margin = new System.Windows.Forms.Padding(3, 0, 11, 0);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(72, 16);
            this.T.TabIndex = 2;
            this.T.Text = "Tên thiết bị";
            // 
            // gv_Danhsach
            // 
            this.gv_Danhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Danhsach.Location = new System.Drawing.Point(0, 47);
            this.gv_Danhsach.MainView = this.gvDanhsach;
            this.gv_Danhsach.Name = "gv_Danhsach";
            this.gv_Danhsach.Size = new System.Drawing.Size(679, 283);
            this.gv_Danhsach.TabIndex = 12;
            this.gv_Danhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhsach});
            this.gv_Danhsach.Load += new System.EventHandler(this.gv_Danhsach_Load);
            this.gv_Danhsach.Click += new System.EventHandler(this.gv_Danhsach_Click);
            // 
            // gvDanhsach
            // 
            this.gvDanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENTB,
            this.DONGIA});
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
            this.TENTB.VisibleIndex = 0;
            this.TENTB.Width = 94;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "Đơn giá";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MinWidth = 25;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 1;
            this.DONGIA.Width = 94;
            // 
            // txtTenthietbi
            // 
            this.txtTenthietbi.Location = new System.Drawing.Point(120, 47);
            this.txtTenthietbi.Name = "txtTenthietbi";
            this.txtTenthietbi.Size = new System.Drawing.Size(227, 22);
            this.txtTenthietbi.TabIndex = 6;
            // 
            // frmThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 421);
            this.Controls.Add(this.gv_Danhsach);
            this.Controls.Add(this.groupThongtin);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục thiết bị";
            this.Load += new System.EventHandler(this.frmThietBi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongtin)).EndInit();
            this.groupThongtin.ResumeLayout(false);
            this.groupThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDongia)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudDongia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label T;
        private DevExpress.XtraGrid.GridControl gv_Danhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn TENTB;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private System.Windows.Forms.TextBox txtTenthietbi;
    }
}