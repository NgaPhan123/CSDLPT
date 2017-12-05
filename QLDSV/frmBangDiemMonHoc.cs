using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLDSV
{
    public partial class frmBangDiemMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmBangDiemMonHoc()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmBangDiemMonHoc_Load(object sender, EventArgs e)
        {
           
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.dS.LOP);

            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.dS.MONHOC);


            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.DIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DIEMTableAdapter.Fill(this.dS.DIEM);

        }
      
        private void btnPreview_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String strLenh = "EXEC SP_InBangDiemMonHoc N'" + cmbTenMH.SelectedValue + "', N'" + cmbTenLop.SelectedValue + "', N'" + cmbLan.Text.Trim()+ "'";
            //MessageBox.Show(strLenh);
            dt = Program.ExecSqlDataTable(strLenh);
            rptBangDiemTheoMonHoc rp = new rptBangDiemTheoMonHoc();

            rp.SetDataSource(dt);
            rp.SetParameterValue("LOP", cmbTenLop.Text);
            rp.SetParameterValue("MONHOC", cmbTenMH.Text);
            rp.SetParameterValue("LAN", cmbLan.Text);
            crptView.ReportSource = rp;
        }
      
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}