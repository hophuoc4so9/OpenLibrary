
namespace openLibrary.Presatation
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongtinCaNhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnQLSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanBoSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLChuyenNganh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongkeYeuCauMuaSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnQlLDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLloaiNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQLTaiNguyen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQLMuonTraSach = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPhanQuyen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(45, 46, 45, 46);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnDoiMatKhau,
            this.btnThongtinCaNhan,
            this.btnQLChiNhanh,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem8,
            this.BtnQLSach,
            this.btnPhanBoSach,
            this.btnQLChuyenNganh,
            this.btnThongkeYeuCauMuaSach,
            this.btnQlLDocGia,
            this.barButtonItem2,
            this.barButtonItem1,
            this.btnQLloaiNhanVien,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonControl1.MaxItemId = 34;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 495;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1862, 219);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ActAsDropDown = true;
            this.btnDangNhap.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.DropDownControl = this.galleryDropDown1;
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbonControl1;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 3;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.LargeImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnThongtinCaNhan
            // 
            this.btnThongtinCaNhan.Caption = "Thông tin cá nhân";
            this.btnThongtinCaNhan.Id = 4;
            this.btnThongtinCaNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongtinCaNhan.ImageOptions.Image")));
            this.btnThongtinCaNhan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongtinCaNhan.ImageOptions.LargeImage")));
            this.btnThongtinCaNhan.Name = "btnThongtinCaNhan";
            // 
            // btnQLChiNhanh
            // 
            this.btnQLChiNhanh.Caption = "Quản lý chi nhánh";
            this.btnQLChiNhanh.Id = 5;
            this.btnQLChiNhanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLChiNhanh.ImageOptions.Image")));
            this.btnQLChiNhanh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLChiNhanh.ImageOptions.LargeImage")));
            this.btnQLChiNhanh.Name = "btnQLChiNhanh";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Quản lý chuyên ngành";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Quản lý chuyên ngành";
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Quản lý chuyên ngành";
            this.barButtonItem8.Id = 9;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // BtnQLSach
            // 
            this.BtnQLSach.Caption = "Quản lý sách";
            this.BtnQLSach.Id = 11;
            this.BtnQLSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnQLSach.ImageOptions.Image")));
            this.BtnQLSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnQLSach.ImageOptions.LargeImage")));
            this.BtnQLSach.Name = "BtnQLSach";
            this.BtnQLSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // btnPhanBoSach
            // 
            this.btnPhanBoSach.Caption = "Phân bổ sách";
            this.btnPhanBoSach.Id = 23;
            this.btnPhanBoSach.ImageOptions.Image = global::openLibrary.Presatation.Properties.Resources.switchrowcolumn_16x16;
            this.btnPhanBoSach.ImageOptions.LargeImage = global::openLibrary.Presatation.Properties.Resources.switchrowcolumn_32x32;
            this.btnPhanBoSach.Name = "btnPhanBoSach";
            this.btnPhanBoSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhanBoSach_ItemClick);
            // 
            // btnQLChuyenNganh
            // 
            this.btnQLChuyenNganh.Caption = "Quản lý chuyên ngành";
            this.btnQLChuyenNganh.Id = 24;
            this.btnQLChuyenNganh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLChuyenNganh.ImageOptions.Image")));
            this.btnQLChuyenNganh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLChuyenNganh.ImageOptions.LargeImage")));
            this.btnQLChuyenNganh.Name = "btnQLChuyenNganh";
            this.btnQLChuyenNganh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // btnThongkeYeuCauMuaSach
            // 
            this.btnThongkeYeuCauMuaSach.Caption = "Thống kê yêu cầu mua sách";
            this.btnThongkeYeuCauMuaSach.Id = 25;
            this.btnThongkeYeuCauMuaSach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongkeYeuCauMuaSach.ImageOptions.SvgImage")));
            this.btnThongkeYeuCauMuaSach.Name = "btnThongkeYeuCauMuaSach";
            // 
            // btnQlLDocGia
            // 
            this.btnQlLDocGia.Caption = "Quản lý đọc giả";
            this.btnQlLDocGia.Id = 26;
            this.btnQlLDocGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQlLDocGia.ImageOptions.Image")));
            this.btnQlLDocGia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQlLDocGia.ImageOptions.LargeImage")));
            this.btnQlLDocGia.Name = "btnQlLDocGia";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Quản lý mượn trả sách";
            this.barButtonItem2.Id = 27;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_1);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Quản lý mượn trả sách";
            this.barButtonItem1.Id = 28;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnQLloaiNhanVien
            // 
            this.btnQLloaiNhanVien.Caption = "Quản lý loại nhân viên";
            this.btnQLloaiNhanVien.Id = 30;
            this.btnQLloaiNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQLloaiNhanVien.ImageOptions.SvgImage")));
            this.btnQLloaiNhanVien.Name = "btnQLloaiNhanVien";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Quản lý nhân viên";
            this.barButtonItem3.Id = 31;
            this.barButtonItem3.ImageOptions.Image = global::openLibrary.Presatation.Properties.Resources.boemployee_16x16;
            this.barButtonItem3.ImageOptions.LargeImage = global::openLibrary.Presatation.Properties.Resources.boemployee_32x32;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbHeThong,
            this.rbQLTaiNguyen,
            this.rbQLMuonTraSach,
            this.rbPhanQuyen});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // rbHeThong
            // 
            this.rbHeThong.ItemLinks.Add(this.btnDangNhap);
            this.rbHeThong.ItemLinks.Add(this.btnThongtinCaNhan);
            this.rbHeThong.ItemLinks.Add(this.btnDoiMatKhau);
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Hệ thống";
            // 
            // rbQLTaiNguyen
            // 
            this.rbQLTaiNguyen.ItemLinks.Add(this.btnQLChiNhanh);
            this.rbQLTaiNguyen.ItemLinks.Add(this.btnQLChuyenNganh);
            this.rbQLTaiNguyen.ItemLinks.Add(this.BtnQLSach);
            this.rbQLTaiNguyen.ItemLinks.Add(this.btnPhanBoSach);
            this.rbQLTaiNguyen.ItemLinks.Add(this.btnThongkeYeuCauMuaSach);
            this.rbQLTaiNguyen.Name = "rbQLTaiNguyen";
            this.rbQLTaiNguyen.Text = "Quản lý tài nguyên";
            // 
            // rbQLMuonTraSach
            // 
            this.rbQLMuonTraSach.ItemLinks.Add(this.btnQlLDocGia);
            this.rbQLMuonTraSach.ItemLinks.Add(this.barButtonItem1);
            this.rbQLMuonTraSach.Name = "rbQLMuonTraSach";
            this.rbQLMuonTraSach.Text = "Quản lý mượn trả sách";
            // 
            // rbPhanQuyen
            // 
            this.rbPhanQuyen.ItemLinks.Add(this.btnQLloaiNhanVien);
            this.rbPhanQuyen.ItemLinks.Add(this.barButtonItem3);
            this.rbPhanQuyen.Name = "rbPhanQuyen";
            this.rbPhanQuyen.Text = "Phân Quyền Hệ thống";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Phân bổ sách";
            this.barButtonItem9.Id = 12;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Quản lý chuyên ngành";
            this.barButtonItem11.Id = 14;
            this.barButtonItem11.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem11.ImageOptions.SvgImage")));
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup6.ImageOptions.Image")));
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Phân bổ sách";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1862, 692);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "OpenLibrary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnThongtinCaNhan;
        private DevExpress.XtraBars.BarButtonItem btnQLChiNhanh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbQLTaiNguyen;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem BtnQLSach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem btnPhanBoSach;
        private DevExpress.XtraBars.BarButtonItem btnQLChuyenNganh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnThongkeYeuCauMuaSach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbQLMuonTraSach;
        private DevExpress.XtraBars.BarButtonItem btnQlLDocGia;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnQLloaiNhanVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPhanQuyen;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
    }
}

