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

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}