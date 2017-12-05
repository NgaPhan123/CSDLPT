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
using System.Collections;

namespace QLDSV
{
    public partial class frmDanhMucLop : DevExpress.XtraEditors.XtraForm
    {
        public Stack st = new Stack();

        int choose = 0;
        const int THEM = 0;
        const int HIEU_CHINH = 1;
        const int XOA = 2;

        int vitri = 0;
        string maKhoa = "";

        public frmDanhMucLop()
        {
            InitializeComponent();
        }

        private String convertStringToUTF8(String s)
        {
            var dbEnc = Encoding.UTF8;
            var uniEnc = Encoding.Unicode;
            byte[] dbByte = dbEnc.GetBytes(s);
            byte[] uniBytes = Encoding.Convert(dbEnc, uniEnc, dbByte);

            return uniEnc.GetString(uniBytes);
        }


        private void updateUIButtonPhucHoi()
        {
            if (st.Count == 0)
                btnPhucHoi.Enabled = false;
            else
                btnPhucHoi.Enabled = true;
        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmDanhMucLopcs_Load(object sender, EventArgs e)
        {
           
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.dS.LOP);


            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
           

            maKhoa = ((DataRowView)bdsDsLop[0])["MAKH"].ToString();
            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;  
            else
                cmbKhoa.Enabled = false;

            groupBox1.Enabled = false;
            btnGhi.Enabled = false;
            updateUIButtonPhucHoi();

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue == null) return;

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
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.dS.LOP);
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                maKhoa = ((DataRowView)bdsDsLop[0])["MAKH"].ToString();
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDsLop.Position;
            groupBox1.Enabled = true;
            bdsDsLop.AddNew();
            txtMaKhoa.Text = maKhoa;
            txtMaKhoa.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            gcLop.Enabled = false;
            choose = THEM;
            btnPhucHoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (choose)
            {
                case THEM:
                    if (txtMaLop.Text.Trim() == "")
                    {
                        MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                        txtMaLop.Focus();
                        return;
                    }

                    if (txtTenLop.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                        txtTenLop.Focus();
                        return;
                    }

                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenh = "dbo.SP_TIMLOP";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;
                    Program.sqlcmd.Parameters.Add("@maLop", SqlDbType.Text).Value = txtMaLop.Text;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (Ret == "1")
                    {
                        MessageBox.Show("Mã lớp bị trùng!", "", MessageBoxButtons.OK);
                        txtMaLop.Focus();
                        Program.conn.Close();
                        return;
                    }

                    String strLenhKiemTra = "dbo.SP_KiemTraTenLop";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenhKiemTra;
                    Program.sqlcmd.Parameters.Add("@tenLop", SqlDbType.Text).Value =  txtTenLop.Text;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String RetKiemTra = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (RetKiemTra == "1")
                    {
                        MessageBox.Show("Tên lớp bị trùng!", "", MessageBoxButtons.OK);
                        txtTenLop.Focus();
                        return;
                    }

                    try
                    {
                        bdsDsLop.EndEdit();
                        bdsDsLop.ResetCurrentItem();
                        this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.LOPTableAdapter.Update(this.dS.LOP);
                        MessageBox.Show("Thêm lớp thành công", "", MessageBoxButtons.OK);

                        String lenh = "exec SP_UndoThemLop '" + txtMaLop.Text + "'";
                        ObjectUndo obj = new ObjectUndo(THEM, lenh);
                        st.Push(obj);
                        updateUIButtonPhucHoi();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi Lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    gcLop.Enabled = true;
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                    btnGhi.Enabled = false;

                    groupBox1.Enabled = false;
                    break;

                case HIEU_CHINH:
                    String tenLop = ((DataRowView)bdsDsLop[vitri])["TENLOP"].ToString().Trim();
                    if (txtTenLop.Text.Trim().Equals(tenLop))
                    {
                        if (MessageBox.Show("Bạn đã không thay đổi gì, bạn có muốn thoát chỉnh sửa ?", "Xác nhận",
                              MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            gcLop.Enabled = true;
                            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                            btnGhi.Enabled = false;

                            groupBox1.Enabled = false;
                        }

                        return;
                    }

                    if (txtTenLop.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                        txtTenLop.Focus();
                        return;
                    }

                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenhKiemTraTenLop = "dbo.SP_KiemTraTenLop ";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenhKiemTraTenLop;
                    Program.sqlcmd.Parameters.Add("@tenLop", SqlDbType.Text).Value = txtTenLop.Text;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String RetKiemTraTenLop = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (RetKiemTraTenLop == "1")
                    {
                        MessageBox.Show("Tên lớp bị trùng!", "", MessageBoxButtons.OK);
                        txtMaLop.Focus();
                        return;
                    }

                    try
                    {
                        bdsDsLop.EndEdit();
                        bdsDsLop.ResetCurrentItem();
                        this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.LOPTableAdapter.Update(this.dS.LOP);

                        MessageBox.Show("Hiệu chỉnh thành công", "", MessageBoxButtons.OK);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiệu chỉnh Lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    gcLop.Enabled = true;
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                    btnGhi.Enabled = false;

                    groupBox1.Enabled = false;

                    break;
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDsLop.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            txtMaLop.Enabled = txtMaKhoa.Enabled = false;
            txtTenLop.Focus();
            gcLop.Enabled = false;
            choose = HIEU_CHINH;

            // lưu stack cho undo
            Lop lop = new Lop(txtMaLop.Text, txtTenLop.Text, txtMaKhoa.Text);
            ObjectUndo obj = new ObjectUndo(HIEU_CHINH, lop);
            st.Push(obj);

            updateUIButtonPhucHoi();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenhKiemTraSVLop = "dbo.SP_KiemTraLopTonTaiSinhVien ";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenhKiemTraSVLop;
            Program.sqlcmd.Parameters.Add("@maLop", SqlDbType.Text).Value = convertStringToUTF8(txtMaLop.Text.Trim());
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String RetKiemTraSVLop = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (RetKiemTraSVLop == "1")
            {
                MessageBox.Show("Không thể xóa lớp này vì có sinh viên trong lớp", "",
                       MessageBoxButtons.OK);
                return;
            }

            String maLop = "";

            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    DataRowView dataRow = (DataRowView)bdsDsLop[bdsDsLop.Position];
                    maLop = dataRow["MALOP"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    String tenLop = dataRow["TENLOP"].ToString();
                    String maKhoa = dataRow["MAKH"].ToString();
                    Lop lopRemove = new Lop(maLop, tenLop, maKhoa);
                    ObjectUndo obj = new ObjectUndo(XOA, lopRemove);
                    MessageBox.Show("Xóa lớp thành công");
                    bdsDsLop.RemoveCurrent();
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Update(this.dS.LOP);

                    st.Push(obj);
                    updateUIButtonPhucHoi();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.LOPTableAdapter.Fill(this.dS.LOP);
                    bdsDsLop.Position = bdsDsLop.Find("MALOP", maLop);
                    return;
                }
            }

            if (bdsDsLop.Count == 0) btnXoa.Enabled = false;
        }
        private void reload()
        {
            if (btnHieuChinh.Enabled == false || btnThem.Enabled == false)
            {
                bdsDsLop.CancelEdit();

                if (btnThem.Enabled == false) bdsDsLop.Position = vitri;
                gcLop.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;

            }
            else
            {
                try
                {
                    this.LOPTableAdapter.Fill(this.dS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnHieuChinh.Enabled == false || btnThem.Enabled == false)
            {
                bdsDsLop.CancelEdit();
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;

                if (btnThem.Enabled == false) bdsDsLop.Position = vitri;
                gcLop.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;

                reload();
            }
            else
            {

                if (st.Count == 0)
                    return;

                ObjectUndo objUndo = (ObjectUndo)st.Pop();
                Object obj = objUndo.obj;
                switch (objUndo.type)
                {
                    case THEM:
                        MessageBox.Show("Khôi phục sau khi thêm");

                        String lenh = "";

                        try
                        {
                            lenh = obj.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        Program.ExecSqlDataReader(lenh);
                        this.LOPTableAdapter.Fill(this.dS.LOP);
                        updateUIButtonPhucHoi();

                        break;

                    case HIEU_CHINH:
                        MessageBox.Show("Khôi phục sau khi hiệu chỉnh");
                        try
                        {
                            Lop lopHieuChinh = (Lop)objUndo.obj;
                            MessageBox.Show(lopHieuChinh.tenLop);

                            if (Program.conn.State == ConnectionState.Closed)
                                Program.conn.Open();
                            String strLenh = "dbo.SP_UndoHieuChinhLop";
                            Program.sqlcmd = Program.conn.CreateCommand();
                            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                            Program.sqlcmd.CommandText = strLenh;
                            Program.sqlcmd.Parameters.Add("@maLop", SqlDbType.Text).Value = lopHieuChinh.maLop;
                            Program.sqlcmd.Parameters.Add("@tenLop", SqlDbType.Text).Value = lopHieuChinh.tenLop;

                            Program.sqlcmd.ExecuteNonQuery();
                            Program.conn.Close();

                            reload();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        break;

                    case XOA:
                        MessageBox.Show("Khôi phục sau khi xóa");
                        try
                        {
                            Lop lopXoa = (Lop)objUndo.obj;

                            if (Program.conn.State == ConnectionState.Closed)
                                Program.conn.Open();
                            String strLenh = "dbo.SP_InsertLop";
                            Program.sqlcmd = Program.conn.CreateCommand();
                            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                            Program.sqlcmd.CommandText = strLenh;
                            Program.sqlcmd.Parameters.Add("@maLop", SqlDbType.Text).Value = lopXoa.maLop;
                            Program.sqlcmd.Parameters.Add("@tenLop", SqlDbType.Text).Value = lopXoa.tenLop;
                            Program.sqlcmd.Parameters.Add("@maKH", SqlDbType.Text).Value = lopXoa.maKhoa;

                            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                            Program.sqlcmd.ExecuteNonQuery();
                            Program.conn.Close();
                            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                            if (Ret == "1")
                                MessageBox.Show("Undo success");
                            else
                                MessageBox.Show("Undo failed");

                            reload();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                }
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvLop_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lOPBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }

    public class Lop
    {
        public String maLop;
        public String tenLop;
        public String maKhoa;

        public Lop(String maLop, String tenLop, String maKhoa)
        {
            this.maLop = maLop;
            this.maKhoa = maKhoa;
            this.tenLop = tenLop;
        }
    }

    public class ObjectUndo
    {
        public int type;
        public Object obj;

        public ObjectUndo(int type, Object obj)
        {
            this.type = type;
            this.obj = obj;
        }
    }
}