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
    public partial class Test : DevExpress.XtraEditors.XtraForm
    {
        public Test()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSetSV1.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.tRACNGHIEMDataSetSV1.GIAOVIEN);

            // TODO: This line of code loads data into the 'tRACNGHIEMDataSetSV1.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = "Data Source=DESKTOP-CAR7DK5\\SRV_2;Initial Catalog=TRACNGHIEM;User ID=001;password=tqh";
            this.kHOATableAdapter.Fill(this.tRACNGHIEMDataSetSV1.KHOA);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSetSV1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.tRACNGHIEMDataSetSV1.MONHOC);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSetSV1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.tRACNGHIEMDataSetSV1.LOP);

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSetSV1);

        }
    }
}