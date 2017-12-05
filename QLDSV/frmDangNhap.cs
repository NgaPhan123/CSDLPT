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
using System.Data.SqlClient;

namespace QLDSV
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_DSPM.V_DS_KHOA' table. You can move, or remove it, as needed.
            this.v_DS_KHOATableAdapter.Fill(this.qLDSV_DSPM.V_DS_KHOA);
            cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = 0;

        }
        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
                Program.servername = cmbKhoa.SelectedValue.ToString();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;
            Program.mChinhanh = cmbKhoa.SelectedIndex; //
            Program.bds_dspm = bdsDSKHOA; //
            Program.mloginDN = Program.mlogin; //
            Program.passwordDN = Program.password; //
            //MessageBox.Show("Đăng nhập thành công.", " ", MessageBoxButtons.OK);
            SqlDataReader myReader;

            String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();


            Program.username = myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            myReader.Close();
            Program.conn.Close();
            Program.fr_Main.MAGV.Text = "Mã nhân viên : " + Program.username;
            Program.fr_Main.HOTEN.Text = "Họ tên : " + Program.mHoten;
            Program.fr_Main.KHOA.Text = "Nhóm : " + Program.mGroup;

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}