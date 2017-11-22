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
    public partial class FrmClass : DevExpress.XtraEditors.XtraForm
    {
        int position = 0; //This value will be changed by lOPGridControl_MouseClick()
        public FrmClass()
        {
            InitializeComponent();
        }

        private void FrmClass_Load(object sender, EventArgs e)
        {
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
                this.classTableAdapter.Connection.ConnectionString = Program.connstr;
            }
            dsSV1.EnforceConstraints = false;
            this.classTableAdapter.Fill(this.dsSV1.LOP);
            this.branchesTableAdapter.Fill(this.ds.V_DS_PHANMANH);
        }

        private void reload()
        {
            this.classTableAdapter.Fill(this.dsSV1.LOP);
            pnEditor.Enabled = false;
            pnTable.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnPrint.Enabled = true;
            btnUndo.Enabled = false;
        }

        private void trimInput()
        {
            txtMaLop.Text = txtMaLop.Text.Trim();
            txtMaKH.Text = txtMaKH.Text.Trim();
            txtTenLop.Text = txtTenLop.Text.Trim();
        }

        private void updateDataSource()
        {
            try
            {
                classBindingSource.EndEdit();
                classBindingSource.ResetCurrentItem();
                this.classTableAdapter.Connection.ConnectionString = Program.connstr;
                this.classTableAdapter.Update(this.dsSV1);
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

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            classBindingSource.AddNew();
            enableEditor();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsSV1);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbBranches.SelectedValue.ToString() != null)
                {
                    Program.servername = cbbBranches.SelectedValue.ToString();
                    if (Program.KetNoi() != 0)
                    {
                        this.classTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.classTableAdapter.Fill(this.dsSV1.LOP);
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

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trimInput();
            enableEditor();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                txtMaKH.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
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
            Form dlgConfirm = new DlgConfirm("Bạn có chắc muốn xóa môn học có mã " + ((DataRowView)classBindingSource[position])["MALOP"].ToString().Trim() + " không?", "Đồng ý", "Không");
            dlgConfirm.StartPosition = FormStartPosition.CenterParent;
            dlgConfirm.ShowDialog();
            if (dlgConfirm.DialogResult == DialogResult.OK)
            {
                classBindingSource.RemoveAt(position);
                updateDataSource();
            }
        }

        private void lOPGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            this.position = classBindingSource.Position;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.reload();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            classBindingSource.CancelEdit();
            trimInput();
        }
    }
}