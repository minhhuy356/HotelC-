using BusinessLogic;
using DataLayer;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();

        }
        TANG _tang = new TANG();
        FUNC _func = new FUNC();
        PHONG _phong = new PHONG();
        GalleryItem item = null;
        private void frmMain_Load(object sender, EventArgs e)
        {

            leftMenu();
            ShowRoom();
        }

        void ShowRoom()
        {
            var IsTang = _tang.getAllForMain();
            gControl.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gControl.Gallery.ImageSize = new Size(64, 64);
            gControl.Gallery.ShowItemText = true;
            gControl.Gallery.ShowGroupCaption = true;
            foreach (var t in IsTang)
            {
                var galleryItem = new GalleryItemGroup();
                galleryItem.Caption = t.TENTANG;
                galleryItem.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
                List<tb_Phong> IsPhong = _phong.getByTang(t.IDTANG);
                foreach (var p in IsPhong)
                {
                    var gc_item = new GalleryItem();
                    gc_item.Caption = p.TENPHONG;
                    gc_item.Value = p.IDPHONG;
                    if (p.TRANGTHAI == true)
                    {
                        gc_item.ImageOptions.Image = imageHome.Images[1];
                    }
                    else
                    {
                        gc_item.ImageOptions.Image = imageHome.Images[0];
                    }

                    galleryItem.Items.Add(gc_item);
                }
                gControl.Gallery.Groups.Add(galleryItem);
            }

        }

        void leftMenu()
        {
            int i = 0;
            var _IsParent = _func.getParrent();
            foreach (var _pr in _IsParent)
            {
                NavBarGroup navGroup = new NavBarGroup(_pr.DESCRIPTION);
                navGroup.Tag = _pr.FUNC_CODE;
                navGroup.Name = _pr.FUNC_CODE;
                navGroup.ImageOptions.LargeImageIndex = i;
                i++;
                navMain.Groups.Add(navGroup);

                var _IsChild = _func.getChild(_pr.FUNC_CODE);
                foreach (var _ch in _IsChild)
                {
                    NavBarItem navItem = new NavBarItem(_ch.DESCRIPTION);
                    navItem.Tag = _ch.FUNC_CODE;
                    navItem.Name = _ch.FUNC_CODE;
                    navItem.ImageOptions.SmallImageIndex = 0;
                    navGroup.ItemLinks.Add(navItem);
                }
                navMain.Groups[navGroup.Name].Expanded = true;
            }

        }

        private void navMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string func_code = e.Link.Item.Tag.ToString();
            switch (func_code)
            {
                case "KHACHSAN":
                    {
                        frmKhachSan frm = new frmKhachSan();
                        frm.ShowDialog();
                        break;
                    }
                case "DONVI":
                    {
                        frmDonVi frm = new frmDonVi();
                        frm.ShowDialog();
                        break;
                    }
                case "KHACHHANG":
                    {
                        frmKhachHang frm = new frmKhachHang();
                        frm.ShowDialog();
                        break;
                    }
                case "TANG":
                    {
                        frmTang frm = new frmTang();
                        frm.ShowDialog();
                        break;
                    }
                case "LOAIPHONG":
                    {
                        frmLoaiPhong frm = new frmLoaiPhong();
                        frm.ShowDialog();
                        break;
                    }
                case "PHONG":
                    {
                        frmPhong frm = new frmPhong();
                        frm.ShowDialog();
                        break;
                    }
                case "SANPHAM":
                    {
                        frmSanPham frm = new frmSanPham();
                        frm.ShowDialog();
                        break;
                    }
                case "PHONG_THIETBI":
                    {
                        frmPhongThietBi frm = new frmPhongThietBi();
                        frm.ShowDialog();
                        break;
                    }
                case "THIETBI":
                    {
                        frmThietBi frm = new frmThietBi();
                        frm.ShowDialog();
                        break;
                    }
                case "DATPHONG":
                    {
                        frmDatPhong frm = new frmDatPhong();
                        frm.ShowDialog();
                        break;
                    }
            }
        }

        private void btn_Baocao_Click(object sender, EventArgs e)
        {

        }

        private void btn_Hethong_Click(object sender, EventArgs e)
        {

        }

        private void popupMenu1_Popup(object sender, EventArgs e)
        {
            Point point = gControl.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = gControl.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
            {
                item = hitInfo.GalleryItem;
            }
        }

        private void btn_Datphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gc_item = new GalleryItem();
            string id = item.Value.ToString();
            MessageBox.Show(id);
        }
    }
}