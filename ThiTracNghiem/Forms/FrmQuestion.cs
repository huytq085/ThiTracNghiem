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
    public partial class FrmQuestion : DevExpress.XtraEditors.XtraForm
    {
        public FrmQuestion()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SERVER1);

        }

        private void FrmQuestion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_SERVER1.BODE' table. You can move, or remove it, as needed.
            this.dS_SERVER1.EnforceConstraints = false;
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS_SERVER1.BODE);
            gridView1.OptionsBehavior.Editable = false;
            groupBox1.Enabled = false;
            List<String> cachXem = new List<String> { "TẤT CẢ ĐỀ THI","CÁ NHÂN" };
            cmbCachXem.DataSource = cachXem;
            if (cmbCachXem.SelectedValue.ToString() == "CÁ NHÂN") {
                bODEBindingSource.Filter = "MAGV = 'TH123'";
                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnXoa.Enabled = true;
                btnPrint.Enabled = btnReload.Enabled = true;                
            }
            else
            {
                bODEBindingSource.Filter="";
                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnXoa.Enabled = false;
                btnPrint.Enabled = btnReload.Enabled = true;
            }
            if (Program.nhom == "GIAOVIEN")
            {
                panel1.Enabled = true;
            }
            else
            {
                panel1.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCachXem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCachXem.SelectedValue.ToString() == "CÁ NHÂN")
            {
                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnXoa.Enabled = true;
                btnPrint.Enabled = btnReload.Enabled = true;
                bODEBindingSource.Filter = "MAGV = 'TH123'";                
            }
            else
            {
                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnXoa.Enabled = false;
                btnPrint.Enabled = btnReload.Enabled = true;
                bODEBindingSource.Filter = "";
            }
        }
    }
}