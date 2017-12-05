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
    public partial class frmNhapMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public Stack st = new Stack();
        int vitri = 0;
        string maMH = "";


        int choose = 0;
        const int THEM = 0;
        const int HIEU_CHINH = 1;
        const int XOA = 2;

        public frmNhapMonHoc()
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

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmNhapMonHoc_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.dS.MONHOC);
            groupBox1.Enabled = false;
            btnGhi.Enabled = false;
            updateUIButtonPhucHoi();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            groupBox1.Enabled = true;
            bdsMonHoc.AddNew();
            txtMaMH.Text = maMH;
            txtMaMH.Enabled = true;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            gcMH.Enabled = false;
            choose = THEM;
            btnPhucHoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (choose)
            {
                case THEM:
                    if (txtMaMH.Text.Trim() == "")
                    {
                        MessageBox.Show("Mã Môn Học không được thiếu!", "", MessageBoxButtons.OK);
                        txtMaMH.Focus();
                        return;
                    }

                    if (txtTenMH.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên Môn Học không được thiếu!", "", MessageBoxButtons.OK);
                        txtTenMH.Focus();
                        return;
                    }

                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenh = "dbo.SP_TIMMONHOC";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;
                    Program.sqlcmd.Parameters.Add("@maMH", SqlDbType.Text).Value = txtMaMH.Text;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (Ret == "1")
                    {
                        MessageBox.Show("Mã Môn học bị trùng!", "", MessageBoxButtons.OK);
                        txtMaMH.Focus();
                        Program.conn.Close();
                        return;
                    }

                    String strLenhKiemTra = "dbo.SP_KiemTraTenMonHoc";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenhKiemTra;
                    Program.sqlcmd.Parameters.Add("@tenMH", SqlDbType.Text).Value = txtTenMH.Text;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String RetKiemTra = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (RetKiemTra == "1")
                    {
                        MessageBox.Show("Tên Môn Học bị trùng!", "", MessageBoxButtons.OK);
                        txtTenMH.Focus();
                        return;
                    }

                    try
                    {
                        bdsMonHoc.EndEdit();
                        bdsMonHoc.ResetCurrentItem();
                        this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.MONHOCTableAdapter.Update(this.dS.MONHOC);
                        MessageBox.Show("Thêm Môn học thành công", "", MessageBoxButtons.OK);

                        String lenh = "exec SP_UndoThemMonHoc '" + txtMaMH.Text + "'";
                        ObjectUndo obj = new ObjectUndo(THEM, lenh);
                        st.Push(obj);
                        updateUIButtonPhucHoi();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi Môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    gcMH.Enabled = true;
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                    btnGhi.Enabled = false;

                    groupBox1.Enabled = false;
                    break;

                case HIEU_CHINH:
                    String tenMH = ((DataRowView)bdsMonHoc[vitri])["TENMH"].ToString().Trim();
                    if (txtTenMH.Text.Trim().Equals(tenMH))
                    {
                        if (MessageBox.Show("Bạn đã không thay đổi gì, bạn có muốn thoát chỉnh sửa ?", "Xác nhận",
                              MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            gcMH.Enabled = true;
                            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                            btnGhi.Enabled = false;

                            groupBox1.Enabled = false;
                        }

                        return;
                    }

                    if (txtTenMH.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên Môn học không được thiếu!", "", MessageBoxButtons.OK);
                        txtTenMH.Focus();
                        return;
                    }

                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenhKiemTraTenMH = "dbo.SP_KiemTraTenMonHoc ";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenhKiemTraTenMH;
                    Program.sqlcmd.Parameters.Add("@TenMH", SqlDbType.Text).Value = convertStringToUTF8(txtTenMH.Text.Trim());
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String RetKiemTraTenMH = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (RetKiemTraTenMH == "1")
                    {
                        MessageBox.Show("Tên Môn học bị trùng!", "", MessageBoxButtons.OK);
                        txtMaMH.Focus();
                        return;
                    }

                    try
                    {
                        bdsMonHoc.EndEdit();
                        bdsMonHoc.ResetCurrentItem();
                        this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.MONHOCTableAdapter.Update(this.dS.MONHOC);

                        MessageBox.Show("Update thành công", "", MessageBoxButtons.OK);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiệu chỉnh Môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    gcMH.Enabled = true;
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                    btnGhi.Enabled = false;

                    groupBox1.Enabled = false;

                    break;
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            txtMaMH.Enabled = txtMaMH.Enabled = false;
            txtTenMH.Focus();
            gcMH.Enabled = false;
            choose = HIEU_CHINH;

            // lưu stack cho undo
            MonHoc MH = new MonHoc(txtMaMH.Text, txtTenMH.Text);
            ObjectUndo obj = new ObjectUndo(HIEU_CHINH, MH);
            st.Push(obj);

            updateUIButtonPhucHoi();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();

            String maMH = "";

            if (MessageBox.Show("Bạn có thật sự muốn xóa Môn học này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    DataRowView dataRow = (DataRowView)bdsMonHoc[bdsMonHoc.Position];
                    maMH = dataRow["MAMH"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    String tenMH = dataRow["TENMH"].ToString();
                    MonHoc MonHocRemove = new MonHoc(maMH, tenMH);
                    ObjectUndo obj = new ObjectUndo(XOA, MonHocRemove);

                    bdsMonHoc.RemoveCurrent();
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MONHOCTableAdapter.Update(this.dS.MONHOC);

                    st.Push(obj);
                    updateUIButtonPhucHoi();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Môn học. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.MONHOCTableAdapter.Fill(this.dS.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMONHOC", maMH);
                    return;
                }
            }

            if (bdsMonHoc.Count == 0) btnXoa.Enabled = false;
        }
        private void reload()
        {
            if (btnHieuChinh.Enabled == false || btnThem.Enabled == false)
            {
                bdsMonHoc.CancelEdit();

                if (btnThem.Enabled == false) bdsMonHoc.Position = vitri;
                gcMH.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;

            }
            else
            {
                try
                {
                    this.MONHOCTableAdapter.Fill(this.dS.MONHOC);
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
                bdsMonHoc.CancelEdit();
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;

                if (btnThem.Enabled == false) bdsMonHoc.Position = vitri;
                gcMH.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
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
                        this.MONHOCTableAdapter.Fill(this.dS.MONHOC);
                        updateUIButtonPhucHoi();

                        break;

                    case HIEU_CHINH:
                        MessageBox.Show("Khôi phục sau khi hiệu chỉnh");
                        try
                        {
                            MonHoc MonHocHieuChinh = (MonHoc)objUndo.obj;
                            MessageBox.Show(MonHocHieuChinh.tenMH);

                            if (Program.conn.State == ConnectionState.Closed)
                                Program.conn.Open();
                            String strLenh = "dbo.SP_UndoHieuChinh";
                            Program.sqlcmd = Program.conn.CreateCommand();
                            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                            Program.sqlcmd.CommandText = strLenh;
                            Program.sqlcmd.Parameters.Add("@maMH", SqlDbType.Text).Value = MonHocHieuChinh.maMH;
                            Program.sqlcmd.Parameters.Add("@tenMH", SqlDbType.Text).Value =MonHocHieuChinh.tenMH;

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
                            MonHoc MonHocXoa = (MonHoc)objUndo.obj;

                            if (Program.conn.State == ConnectionState.Closed)
                                Program.conn.Open();
                            String strLenh = "dbo.SP_InsertMonHoc";
                            Program.sqlcmd = Program.conn.CreateCommand();
                            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                            Program.sqlcmd.CommandText = strLenh;
                            Program.sqlcmd.Parameters.Add("@maMH", SqlDbType.Text).Value = MonHocXoa.maMH;
                            Program.sqlcmd.Parameters.Add("@tenMH", SqlDbType.Text).Value = MonHocXoa.tenMH;
                           
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

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
    public class MonHoc
    {
        public String maMH;
        public String tenMH;
      

        public MonHoc(String maMH, String tenMH)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
        }
    }
}
