using System;
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

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
       
        private void btnLop_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
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

        
    }
}