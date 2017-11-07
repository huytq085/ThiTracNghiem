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
        int vitri = 0;
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

        private void mAMHTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //mONHOCTableAdapter.Update(this.tRACNGHIEMDataSetSV1);
            
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnEditor.Enabled = true;
            pnTable.Enabled = false;
            vitri = mONHOCBindingSource.Position;
            mONHOCBindingSource.AddNew();
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
                } catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.tRACNGHIEMDataSetSV1.MONHOC);
                    return;
                }
                
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnEditor.Enabled = false;
            pnTable.Enabled = true;
        }
    }
}