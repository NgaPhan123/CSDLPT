using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class FormDiem : Form
    {
        const bool SHOW_DIEM = false;
        public FormDiem()
        {
            InitializeComponent();
        }

        private void FormDiem_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false; // loai bo dk khoa ngoai
            
           
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
        
            this.kHOATableAdapter.Fill(this.dS.KHOA);
          
            this.lOPTableAdapter.Fill(this.dS.LOP);
        
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            setDataSourceForCmbLan();

            gcDiem.Hide();

        }

        //private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.mONHOCBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dS);

        //}
        private void  setDataSourceForCmbLan()
        {
            var solan = new[] { "1", "2" };
            cmbLan.DataSource = solan;
        }

        private void initGcMaSvHoTenSinhVien()
        {
            try
            {
                this.sp_LayDiemSinhVienTableAdapter.Fill(this.dS.sp_LayDiemSinhVien,
                                                        cmbMaLop.SelectedValue.ToString(),
                                                        cmbTenMonHoc.SelectedValue.ToString(),
                                                        short.Parse(cmbLan.SelectedValue.ToString()));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            this.sp_LayDiemSinhVienTableAdapter.Connection.ConnectionString = Program.connstr;


            DataTable data = this.sp_LayDiemSinhVienTableAdapter.GetData(cmbMaLop.SelectedValue.ToString(),
                                                                    cmbTenMonHoc.SelectedValue.ToString(),
                                                                    short.Parse(cmbLan.SelectedValue.ToString()));
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Data null");
                updateUI(!SHOW_DIEM);
            }

        }

        private void updateUI(bool state)
        {
            cmbTenLop.Enabled = cmbTenMonHoc.Enabled = cmbMaLop.Enabled = cmbLan.Enabled
                = btnBatDau.Enabled = state;
            btnLuu.Enabled = !state;

            if (state == !SHOW_DIEM)
                gcDiem.Hide();
            else
                gcDiem.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable("DiemEdit");
            table.Columns.Add("MASV", typeof(string));
            table.Columns.Add("MAMH", typeof(string));
            table.Columns.Add("LAN", typeof(int));
            table.Columns.Add("DIEM", typeof(float));

            String maSv = "";
            String maMH = cmbTenMonHoc.SelectedValue.ToString();
            int lan = Int32.Parse(cmbLan.SelectedValue.ToString());
            float diem = 0;
            foreach (DataRowView row in bdsLayDiemSinhVien)
            {
                maSv = row["MASV"].ToString().Trim();

                if (row["Column1"].ToString().Trim() != "")
                {
                    diem = float.Parse(row["Column1"].ToString());
                    table.Rows.Add(maSv, maMH, lan, diem);
                }
                
            }


            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenhKiemTraTenLop = "dbo.sp_InsertAndUpdateDiem ";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenhKiemTraTenLop;
            Program.sqlcmd.Parameters.AddWithValue("@table_temp", table);
            Program.sqlcmd.Parameters.AddWithValue("@maKhoa", "CNTT");

            SqlDataAdapter dpt = new SqlDataAdapter(Program.sqlcmd);
            DataTable ds = new DataTable();
            dpt.Fill(ds);
            if (ds.Rows.Count > 0)
                MessageBox.Show("CẬP NHẬT ĐIỂM THÀNH CÔNG");
            else
                MessageBox.Show("CẬP NHẬT ĐIỂM THẤT BẠI");

            updateUI(!SHOW_DIEM);
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            gcDiem.Show();
            updateUI(SHOW_DIEM);
            initGcMaSvHoTenSinhVien();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
      

    }
}
