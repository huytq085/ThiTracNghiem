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
    public partial class FrmSubject : DevExpress.XtraEditors.XtraForm
    {
        bool editMode = false;
        int position = 0; //This value will be changed by mONHOCGridControl_Click()
        public FrmSubject()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsSV1);

        }

        private void updateDataSource()
        {
            try
            {
                subjectBindingSource.EndEdit();
                subjectBindingSource.ResetCurrentItem();
                this.subjectTableAdapter.Connection.ConnectionString = Program.connstr;
                this.subjectTableAdapter.Update(this.dsSV1);
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                reload();
                return;
            }
        }

        private void FrmSubject_Load(object sender, EventArgs e)
        {
            this.branchesTableAdapter.Fill(this.ds.V_DS_PHANMANH);
            if (Program.nhom.Equals("TRUONG"))
            {
                barAction.Dispose();
                pnEditor.Dispose();
            }
            if (Program.connstr != null)
            {
                this.subjectTableAdapter.Connection.ConnectionString = Program.connstr;
            }
            this.subjectTableAdapter.Fill(this.dsSV1.MONHOC);
        }

        private void mONHOCGridControl_Click(object sender, EventArgs e)
        {
            this.position = subjectBindingSource.Position;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được thiếu!", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được thiếu!", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return;
            }
            Form dlgConfirm = new DlgConfirm();
            dlgConfirm.StartPosition = FormStartPosition.CenterParent;
            dlgConfirm.ShowDialog();
            if (dlgConfirm.DialogResult == DialogResult.OK)
            {
                updateDataSource();

            }
        }
        private void enableEditor()
        {
            pnEditor.Enabled = true;
            pnTable.Enabled = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnPrint.Enabled = false;
            btnUndo.Enabled = true;
        }
        private void reload()
        {
            this.subjectTableAdapter.Fill(this.dsSV1.MONHOC);
            pnEditor.Enabled = false;
            pnTable.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnPrint.Enabled = true;
            btnUndo.Enabled = false;
        }

        private void trimInput()
        {
            txtMaMH.Text = txtMaMH.Text.Trim();
            txtTenMH.Text = txtTenMH.Text.Trim();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            editMode = false;
            subjectBindingSource.AddNew();
            enableEditor();
        }
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            editMode = true;
            trimInput();
            enableEditor();
        }
        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dlgConfirm = new DlgConfirm("Bạn có chắc muốn xóa môn học có mã " + ((DataRowView)subjectBindingSource[position])["MAMH"].ToString().Trim() + " không?", "Đồng ý", "Không");
            dlgConfirm.StartPosition = FormStartPosition.CenterParent;
            dlgConfirm.ShowDialog();
            if (dlgConfirm.DialogResult == DialogResult.OK)
            {
                subjectBindingSource.RemoveAt(position);
                updateDataSource();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được thiếu!", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được thiếu!", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return;
            }
            if (!isExits())
            {
                Form dlgConfirm = new DlgConfirm();
                dlgConfirm.StartPosition = FormStartPosition.CenterParent;
                dlgConfirm.ShowDialog();
                if (dlgConfirm.DialogResult == DialogResult.OK)
                {
                    updateDataSource();
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.reload();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            subjectBindingSource.CancelEdit();
            trimInput();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.reload();
        }

        private bool isExits()
        {
            if (editMode && (txtMaMH.Text == ((DataRowView)subjectBindingSource[position])["MAMH"].ToString().Trim() || txtTenMH.Text == ((DataRowView)subjectBindingSource[position])["TENMH"].ToString().Trim()))
            {
                return false;
            }

            string cmd = "SELECT * FROM MONHOC WHERE MAMH = '" + txtMaMH.Text.Trim() + "' OR TENMH = '" + txtTenMH.Text.Trim() + "'";
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            if (reader != null && reader.HasRows)
            {
                DlgOk.Show("Mã hoặc tên môn học đã tồn tại", "Đóng");
                reader.Close();
                return true;
            }
            //else if (Program.checkExistsAllSite(cmd))
            //{
            //    reader.Close();
            //    DlgOk.Show("Mã hoặc tên môn học đã tồn tại trên chi nhánh khác", "Đóng");
            //    return true;
            //}
            return false;
        }

    }
}