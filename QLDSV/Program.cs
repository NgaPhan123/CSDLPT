using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace QLDSV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static SqlCommand sqlcmd = new SqlCommand();
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;

        public static String servername = string.Empty;
        public static String username = string.Empty;
        public static String mlogin = string.Empty;
        public static String password = string.Empty;

        public static String database = "QLDSV";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";
        public static String mloginDN = string.Empty;
        public static String passwordDN = string.Empty;
        public static String mGroup = string.Empty;
        public static String mHoten = string.Empty;
        public static int mChinhanh = 0;
        public static BindingSource bds_dspm = new BindingSource(); //giu DSPM khi dang nhap
        public static frmMain fr_Main;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, string.Empty, MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd, string connstr)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            fr_Main = new frmMain();
            Application.Run(fr_Main);

        }
    }
}
