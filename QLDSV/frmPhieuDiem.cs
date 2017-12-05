using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmPhieuDiem : Form
    {
        public frmPhieuDiem()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmPhieuDiem_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.dS.KHOA);
          
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            else
                cmbKhoa.Enabled = false;

        }


        private void btnPreview_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String strLenh = "EXEC SP_InPhieuDiem N'" + cmbMaSV.Text + "'";
            //MessageBox.Show(strLenh);
            dt = Program.ExecSqlDataTable(strLenh);
            rptPhieuDiem rp = new rptPhieuDiem();

            rp.SetDataSource(dt);
            rp.SetParameterValue("MaSV", cmbMaSV.Text);
            crptView.ReportSource = rp;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            }
        }
    }
}
