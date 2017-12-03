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

namespace ThiTracNghiem.Forms
{
   
    public partial class FrmTeacher : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
               
        public FrmTeacher()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SERVER1);

        }

        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            dS_SERVER1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS_SERVER1.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS_SERVER1.GIAOVIEN);
            if (Program.nhom == "COSO")
            {
                String dkien = "";
                String strLenh = "Select * from V_MAKH ";
                SqlDataReader reader = Program.ExecSqlDataReader(strLenh);
                if (reader != null && reader.HasRows)
                {
                    Boolean rd = reader.Read();
                    while (rd)
                    {
                        dkien += "MAKH = '" + reader["MAKH"] + "'";
                        rd = reader.Read();
                        if (rd != false)
                            dkien += " OR ";
                    }
                    Program.conn.Close();
                    reader.Close();
                    bdsGV.Filter = dkien;
                }
            }
            // TODO: This line of code loads data into the 'dS_SERVER1.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS_SERVER1.BODE);
            // TODO: This line of code loads data into the 'dS_SERVER1.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS_SERVER1.GIAOVIEN_DANGKY);
           
            gridView1.OptionsBehavior.Editable = false;
            if (Program.nhom == "TRUONG")
            {
                
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
            }
            groupBox1.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsGV.Position;
            groupBox1.Enabled = true;
            bdsGV.AddNew();

            txtMAKH.Text = "";
            txtMAGV.Text = "";
            txtHO.Text = "";
            txtTEN.Text = "";
            txtDIACHI.Text = "";
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcGV.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsGV.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcGV.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giáo viên không được phép rỗng", "", MessageBoxButtons.OK);
                txtMAGV.Focus();
                return;
            }
            if (txtMAKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được phép rỗng", "", MessageBoxButtons.OK);
                txtMAKH.Focus();
                return;
            }
            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được phép rỗng", "", MessageBoxButtons.OK);
                txtHO.Focus();
                return;
            }
            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được phép rỗng", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }
            if (txtDIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được phép rỗng", "", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return;
            }
            
            //((DataRowView)bdsSV[0])["MALOP"] = cmbMALOP.SelectedText.ToString().Trim();
            try
            {
                bdsGV.EndEdit();
                bdsGV.ResetCurrentItem();
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Update(this.dS_SERVER1.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giáo viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcGV.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String magv = "";
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa giáo viên này vì có đăng kí lớp thi", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (bdsBODE.Count > 0)
            {
                MessageBox.Show("Không thể xóa giáo viên này vì có bộ đề", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    magv = ((DataRowView)bdsGV[bdsGV.Position])["MAGV"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsGV.RemoveCurrent();
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Update(this.dS_SERVER1.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giáo viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.gIAOVIENTableAdapter.Fill(this.dS_SERVER1.GIAOVIEN);
                    bdsGV.Position = bdsGV.Find("MAGV", magv);
                    return;
                }
            }

            if (bdsGV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.CancelEdit();
            if (btnThem.Enabled == false) bdsGV.Position = viTri;
            gcGV.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gIAOVIENTableAdapter.Fill(this.dS_SERVER1.GIAOVIEN);
                if (Program.nhom == "COSO")
                {
                    String dkien = "";
                    String strLenh = "Select * from V_MAKH ";
                    SqlDataReader reader = Program.ExecSqlDataReader(strLenh);
                    Boolean rd = reader.Read();
                    while (rd)
                    {
                        dkien += "MAKH = '" + reader["MAKH"] + "'";
                        rd = reader.Read();
                        if (rd != false)
                            dkien += " OR ";
                    }

                    Program.conn.Close();
                    reader.Close();
                    bdsGV.Filter = dkien;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}