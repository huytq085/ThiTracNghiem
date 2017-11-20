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

namespace ThiTracNghiem.Forms
{
    public partial class FrmSubject : DevExpress.XtraEditors.XtraForm
    {
        string maMH = "";
        int position = 0; //This value will be changed by mONHOCGridControl_Click()
        public FrmSubject()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSetSV1);

        }

        private void FrmSubject_Load(object sender, EventArgs e)
        {
            if (!Program.nhom.Equals("TRUONG"))
            {
                pnBranches.Dispose();
            }
            if (Program.connstr != null)
            {
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            }
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSetSV1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.tRACNGHIEMDataSetSV1.MONHOC);

        }

        private void mONHOCGridControl_Click(object sender, EventArgs e)
        {
            this.position = mONHOCBindingSource.Position;
        }

        private void mAMHTextEdit_EditValueChanged(object sender, EventArgs e)
        {

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
                try
                {
                    mONHOCBindingSource.EndEdit();
                    mONHOCBindingSource.ResetCurrentItem();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.tRACNGHIEMDataSetSV1);
                    btnCancel_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                    btnCancel_Click(sender, e);
                    return;
                }

            }
        }
        private void enableEditor()
        {
            pnEditor.Enabled = true;
            pnTable.Enabled = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnPrint.Enabled = false;
            btnUndo.Enabled = true;
        }
        private void disableEditor()
        {
            this.mONHOCTableAdapter.Fill(this.tRACNGHIEMDataSetSV1.MONHOC);
            pnEditor.Enabled = false;
            pnTable.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnPrint.Enabled = true;
            btnUndo.Enabled = false;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mONHOCBindingSource.AddNew();
            enableEditor();


        }
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaMH.Text = txtMaMH.Text.Trim();
            txtTenMH.Text = txtTenMH.Text.Trim();
            enableEditor();
        }
        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dlgConfirm = new DlgConfirm("Bạn có chắc muốn xóa môn học có mã " + ((DataRowView)mONHOCBindingSource[position])["MAMH"].ToString().Trim() + " không?", "Đồng ý", "Không");
            dlgConfirm.StartPosition = FormStartPosition.CenterParent;
            dlgConfirm.ShowDialog();
            if (dlgConfirm.DialogResult == DialogResult.OK)
            {
                try
                {
                    mONHOCBindingSource.RemoveAt(position);
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.tRACNGHIEMDataSetSV1);
                    btnCancel_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                    btnCancel_Click(sender, e);
                    return;
                }

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
            Form dlgConfirm = new DlgConfirm();
            dlgConfirm.StartPosition = FormStartPosition.CenterParent;
            dlgConfirm.ShowDialog();
            if (dlgConfirm.DialogResult == DialogResult.OK)
            {
                try
                {
                    mONHOCBindingSource.EndEdit();
                    mONHOCBindingSource.ResetCurrentItem();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.tRACNGHIEMDataSetSV1);
                    btnCancel_Click(sender, e);
                } catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                    btnCancel_Click(sender, e);
                    return;
                }
                
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.disableEditor();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mONHOCBindingSource.CancelEdit();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.disableEditor();
        }
    }
}