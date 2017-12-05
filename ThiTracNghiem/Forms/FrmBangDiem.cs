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
    public partial class FrmBangDiem : DevExpress.XtraEditors.XtraForm
    {
        public FrmBangDiem()
        {
            InitializeComponent();
        }

        private void bANGDIEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBANGDIEM.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SERVER1);

        }

        private void FrmBangDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_SERVER1.V_DS_MONHOC' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dS_SERVER1.V_DS_LOP' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dS_SERVER1.V_DS_MONHOC' table. You can move, or remove it, as needed.
            //this.v_DS_MONHOCTableAdapter.Fill(this.dS_SERVER1.V_DS_MONHOC);
            // TODO: This line of code loads data into the 'dS_SERVER1.V_DS_MONHOC' table. You can move, or remove it, as needed.
            //this.v_DS_MONHOCTableAdapter.Fill(this.dS_SERVER1.V_DS_MONHOC);
            // TODO: This line of code loads data into the 'dS_SERVER1.V_DS_LOP' table. You can move, or remove it, as needed.
            //this.v_DS_LOPTableAdapter.Fill(this.dS_SERVER1.V_DS_LOP);
            // TODO: This line of code loads data into the 'dS_SERVER1.BANGDIEM' table. You can move, or remove it, as needed.
            this.dS_SERVER1.EnforceConstraints = false;
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS_SERVER1.BANGDIEM);
            this.v_DS_LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_LOPTableAdapter.Fill(this.dS_SERVER1.V_DS_LOP);
            this.v_DS_MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_MONHOCTableAdapter.Fill(this.dS_SERVER1.V_DS_MONHOC);
            List<String> cachXem = new List<String> { "1", "2" };
            cmbLANTHI.DataSource = cachXem;
            this.bdsBANGDIEM.Filter = "";
        }

        private void nGAYTHILabel_Click(object sender, EventArgs e)
        {

        }

        private void nGAYTHIDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            
            String Filter = "MAMH = '" + cmbMONHOC.SelectedValue.ToString().Trim() + "',LAN = " + cmbLANTHI.SelectedValue.ToString().Trim();
            try
            {
                //this.bANGDIEMTableAdapter.Fill(this.dS_SERVER1.BANGDIEM);
                bdsBANGDIEM.Filter = Filter;
            }catch(Exception exc)
            {
                MessageBox.Show("Không có dữ liệu", "", MessageBoxButtons.OK);
            }
        }
    }
}