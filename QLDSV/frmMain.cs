﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLDSV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
           if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
               f.MdiParent = this;
                f.Show();
             }
            
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

      
        private void btnDanhMucLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDanhMucLop));
            if (frm != null) frm.Activate();
            else
            {
                frmDanhMucLop f = new frmDanhMucLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapMonHoc f = new frmNhapMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDSSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmDSSinhVien f = new frmDSSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThiHetMon_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnBangDiemMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBangDiemMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmBangDiemMonHoc f = new frmBangDiemMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuDiem f = new frmPhieuDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBangDiemTongKet_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            Form frm = this.CheckExists(typeof(frmBangDiemTongKet));
            if (frm != null) frm.Activate();
            else
            {
                frmBangDiemTongKet f = new frmBangDiemTongKet();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnLop_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnTaoTaiKhoan_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}