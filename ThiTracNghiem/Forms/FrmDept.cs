﻿using System;
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
    public partial class FrmDept : DevExpress.XtraEditors.XtraForm
    {
        int position = 0; //This value will be changed by kHOAGridControl_MouseClick()
        public FrmDept()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deptBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsSV1);

        }

        private void FrmDept_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.ds.V_DS_PHANMANH);
            if (!Program.nhom.Equals("TRUONG"))
            {
                pnBranches.Dispose();
            } else
            {
                barAction.Dispose();
                pnEditor.Dispose();
            }
            if (Program.connstr != null)
            {
                this.deptTableAdapter.Connection.ConnectionString = Program.connstr;
            }
            if (Program.connstr != null)
            {
                this.deptTableAdapter.Connection.ConnectionString = Program.connstr;
            }
            dsSV1.EnforceConstraints = false;
            this.deptTableAdapter.Fill(this.dsSV1.KHOA);

        }

        private void reload()
        {
            this.deptTableAdapter.Fill(this.dsSV1.KHOA);
            pnEditor.Enabled = false;
            pnTable.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnPrint.Enabled = true;
            btnUndo.Enabled = false;
        }

        private void trimInput()
        {
            txtMaCS.Text = txtMaCS.Text.Trim();
            txtMaKH.Text = txtMaKH.Text.Trim();
            txtTenKH.Text = txtTenKH.Text.Trim();
        }

        private void updateDataSource()
        {
            try
            {
                deptBindingSource.EndEdit();
                deptBindingSource.ResetCurrentItem();
                this.deptTableAdapter.Connection.ConnectionString = Program.connstr;
                this.deptTableAdapter.Update(this.dsSV1);
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                reload();
                return;
            }
        }

        private void enableEditor()
        {
            pnEditor.Enabled = true;
            pnTable.Enabled = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnPrint.Enabled = false;
            btnUndo.Enabled = true;
        }

        private void cbbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbBranches.SelectedValue.ToString() != null)
                {
                    Program.servername = cbbBranches.SelectedValue.ToString();
                    if (Program.KetNoi() != 0)
                    {
                        this.deptTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.deptTableAdapter.Fill(this.dsSV1.KHOA);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void kHOAGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            this.position = deptBindingSource.Position;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deptBindingSource.AddNew();
            enableEditor();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trimInput();
            enableEditor();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaCS.Text.Trim() == "")
            {
                MessageBox.Show("Mã cơ sở không được thiếu!", "", MessageBoxButtons.OK);
                txtMaCS.Focus();
                return;
            }
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Tên khoa không được thiếu!", "", MessageBoxButtons.OK);
                txtTenKH.Focus();
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

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dlgConfirm = new DlgConfirm("Bạn có chắc muốn xóa khoa có mã " + ((DataRowView)deptBindingSource[position])["MAKH"].ToString().Trim() + " không?", "Đồng ý", "Không");
            dlgConfirm.StartPosition = FormStartPosition.CenterParent;
            dlgConfirm.ShowDialog();
            if (dlgConfirm.DialogResult == DialogResult.OK)
            {
                deptBindingSource.RemoveAt(position);
                updateDataSource();
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deptBindingSource.CancelEdit();
            trimInput();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.reload();
        }
    }
}