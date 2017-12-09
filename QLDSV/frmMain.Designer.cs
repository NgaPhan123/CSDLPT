namespace QLDSV
{
    partial class frmMain
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnPreview = new DevExpress.XtraBars.BarButtonItem();
            this.btnThiHetMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangDiemMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhMucLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangDiemTongKet = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.KHOA = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnThoat,
            this.btnLop,
            this.barButtonItem1,
            this.btnNhapLop,
            this.btnNhapMH,
            this.btnPreview,
            this.btnThiHetMon,
            this.btnBangDiemMonHoc,
            this.btnDanhMucLop,
            this.btnPhieuDiem,
            this.btnBangDiemTongKet,
            this.btnTaoTaiKhoan});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.Size = new System.Drawing.Size(768, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.Image = global::QLDSV.Properties.Resources.Login_32_icon;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 2;
            this.btnThoat.ImageOptions.Image = global::QLDSV.Properties.Resources.Apps_session_Exit_icon_48;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Nhập DM Lớp";
            this.btnLop.Id = 3;
            this.btnLop.ImageOptions.Image = global::QLDSV.Properties.Resources.Science_Classroom_24_icon;
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nhập Môn Học";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.Image = global::QLDSV.Properties.Resources.Button_Add_24_icon;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnNhapLop
            // 
            this.btnNhapLop.Caption = "Nhập DM Lớp";
            this.btnNhapLop.Id = 5;
            this.btnNhapLop.ImageOptions.Image = global::QLDSV.Properties.Resources.Button_Add_24_icon;
            this.btnNhapLop.Name = "btnNhapLop";
            this.btnNhapLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnNhapMH
            // 
            this.btnNhapMH.Caption = "Môn Học";
            this.btnNhapMH.Id = 6;
            this.btnNhapMH.ImageOptions.Image = global::QLDSV.Properties.Resources.Button_Add_24_icon;
            this.btnNhapMH.Name = "btnNhapMH";
            this.btnNhapMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapMH_ItemClick);
            // 
            // btnPreview
            // 
            this.btnPreview.Caption = "DSSV";
            this.btnPreview.Id = 10;
            this.btnPreview.ImageOptions.Image = global::QLDSV.Properties.Resources.Excel_24_icon1;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPreview_ItemClick);
            // 
            // btnThiHetMon
            // 
            this.btnThiHetMon.Caption = "DS Thi Hết Môn";
            this.btnThiHetMon.Id = 11;
            this.btnThiHetMon.ImageOptions.Image = global::QLDSV.Properties.Resources.Excel_24_icon;
            this.btnThiHetMon.Name = "btnThiHetMon";
            this.btnThiHetMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThiHetMon_ItemClick);
            // 
            // btnBangDiemMonHoc
            // 
            this.btnBangDiemMonHoc.Caption = "Bảng Điểm Môn Học";
            this.btnBangDiemMonHoc.Id = 12;
            this.btnBangDiemMonHoc.ImageOptions.Image = global::QLDSV.Properties.Resources.Excel_24_icon;
            this.btnBangDiemMonHoc.Name = "btnBangDiemMonHoc";
            this.btnBangDiemMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangDiemMonHoc_ItemClick);
            // 
            // btnDanhMucLop
            // 
            this.btnDanhMucLop.Caption = "Danh Mục Lớp";
            this.btnDanhMucLop.Id = 13;
            this.btnDanhMucLop.ImageOptions.Image = global::QLDSV.Properties.Resources.Button_Add_24_icon;
            this.btnDanhMucLop.Name = "btnDanhMucLop";
            this.btnDanhMucLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhMucLop_ItemClick);
            // 
            // btnPhieuDiem
            // 
            this.btnPhieuDiem.Caption = "Phiếu Điểm";
            this.btnPhieuDiem.Id = 14;
            this.btnPhieuDiem.ImageOptions.Image = global::QLDSV.Properties.Resources.Excel_24_icon1;
            this.btnPhieuDiem.Name = "btnPhieuDiem";
            this.btnPhieuDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuDiem_ItemClick);
            // 
            // btnBangDiemTongKet
            // 
            this.btnBangDiemTongKet.Caption = "Bảng Điểm Tổng Kết";
            this.btnBangDiemTongKet.Id = 15;
            this.btnBangDiemTongKet.ImageOptions.Image = global::QLDSV.Properties.Resources.Excel_24_icon;
            this.btnBangDiemTongKet.Name = "btnBangDiemTongKet";
            this.btnBangDiemTongKet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangDiemTongKet_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Image = global::QLDSV.Properties.Resources.Teacher_male_icon_48;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Trị";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.ribbonPage2.Image = global::QLDSV.Properties.Resources.Keyboard_48_icon;
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Nhập Liệu";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhapMH);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDanhMucLop);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.ribbonPage3.Image = global::QLDSV.Properties.Resources.Excel_48_icon;
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Báo cáo";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnPreview);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThiHetMon);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBangDiemMonHoc);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnPhieuDiem);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnBangDiemTongKet);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "ribbonPageGroup8";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11,
            this.ribbonPageGroup12});
            this.ribbonPage4.Image = global::QLDSV.Properties.Resources.Actions_list_add_user_icon_24;
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Tạo Tài Khoản";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "ribbonPageGroup9";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(768, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAGV,
            this.toolStripStatusLabel2,
            this.HOTEN,
            this.KHOA});
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(768, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MAGV
            // 
            this.MAGV.Name = "MAGV";
            this.MAGV.Size = new System.Drawing.Size(77, 17);
            this.MAGV.Text = "Mã Giáo Viên";
            this.MAGV.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(45, 17);
            this.HOTEN.Text = "Họ Tên";
            this.HOTEN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // KHOA
            // 
            this.KHOA.Name = "KHOA";
            this.KHOA.Size = new System.Drawing.Size(34, 17);
            this.KHOA.Text = "Khoa";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "ribbonPageGroup10";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "ribbonPageGroup11";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.Text = "ribbonPageGroup12";
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo Tài Khoản";
            this.btnTaoTaiKhoan.Id = 17;
            this.btnTaoTaiKhoan.ImageOptions.Image = global::QLDSV.Properties.Resources.Actions_list_add_user_icon_24;
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "QUẢN LÍ ĐIỂM SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel MAGV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel KHOA;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnNhapLop;
        private DevExpress.XtraBars.BarButtonItem btnNhapMH;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnThiHetMon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnBangDiemMonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnDanhMucLop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnPhieuDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnBangDiemTongKet;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
    }
}