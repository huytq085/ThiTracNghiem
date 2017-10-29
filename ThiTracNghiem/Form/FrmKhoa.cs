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

namespace ThiTracNghiem.Form
{
    public partial class FrmKhoa : DevExpress.XtraEditors.XtraForm
    {
        public FrmKhoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSetSV1);

        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSetSV1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.tRACNGHIEMDataSetSV1.LOP);
            if (Program.connstr != null)
            {
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            }
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSetSV1.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.tRACNGHIEMDataSetSV1.KHOA);

        }
    }
}