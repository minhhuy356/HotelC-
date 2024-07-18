namespace HotelManagement
{
    partial class frmTang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTang));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.btn_Sua = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_Luu = new System.Windows.Forms.ToolStripButton();
            this.btn_Boqua = new System.Windows.Forms.ToolStripButton();
            this.btn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.groupThongtin = new DevExpress.XtraEditors.GroupControl();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gv_Tang = new DevExpress.XtraGrid.GridControl();
            this.gvTang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TENTANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDTANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongtin)).BeginInit();
            this.groupThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Tang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTang)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(635, 47);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            this.groupThongtin.Controls.Add(this.txt_Ten);
            this.groupThongtin.Controls.Add(this.label6);
            this.groupThongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupThongtin.Location = new System.Drawing.Point(0, 315);
            this.groupThongtin.Name = "groupThongtin";
            this.groupThongtin.Size = new System.Drawing.Size(635, 101);
            this.groupThongtin.TabIndex = 6;
            this.groupThongtin.Text = "Thông tin";
            this.groupThongtin.Visible = false;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(97, 46);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(452, 23);
            this.txt_Ten.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên";
            // 
            // gv_Tang
            // 
            this.gv_Tang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Tang.Location = new System.Drawing.Point(0, 47);
            this.gv_Tang.MainView = this.gvTang;
            this.gv_Tang.Name = "gv_Tang";
            this.gv_Tang.Size = new System.Drawing.Size(635, 268);
            this.gv_Tang.TabIndex = 7;
            this.gv_Tang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTang});
            this.gv_Tang.Load += new System.EventHandler(this.gv_Tang_Load);
            // 
            // gvTang
            // 
            this.gvTang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDTANG,
            this.TENTANG});
            this.gvTang.GridControl = this.gv_Tang;
            this.gvTang.Name = "gvTang";
            this.gvTang.Click += new System.EventHandler(this.gvTang_Click);
            // 
            // TENTANG
            // 
            this.TENTANG.Caption = "Tên tầng";
            this.TENTANG.FieldName = "TENTANG";
            this.TENTANG.MinWidth = 25;
            this.TENTANG.Name = "TENTANG";
            this.TENTANG.Visible = true;
            this.TENTANG.VisibleIndex = 1;
            this.TENTANG.Width = 765;
            // 
            // IDTANG
            // 
            this.IDTANG.Caption = "ID";
            this.IDTANG.FieldName = "IDTANG";
            this.IDTANG.MinWidth = 25;
            this.IDTANG.Name = "IDTANG";
            this.IDTANG.Visible = true;
            this.IDTANG.VisibleIndex = 0;
            this.IDTANG.Width = 56;
            // 
            // frmTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 416);
            this.Controls.Add(this.gv_Tang);
            this.Controls.Add(this.groupThongtin);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmTang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTang";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongtin)).EndInit();
            this.groupThongtin.ResumeLayout(false);
            this.groupThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Tang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTang)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.GridControl gv_Tang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTang;
        private System.Windows.Forms.TextBox txt_Ten;
        private DevExpress.XtraGrid.Columns.GridColumn TENTANG;
        private DevExpress.XtraGrid.Columns.GridColumn IDTANG;
    }
}