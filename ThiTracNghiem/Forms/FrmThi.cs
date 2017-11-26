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
    public partial class FrmThi : DevExpress.XtraEditors.XtraForm
    {
        String bdsFilter = "";
        int thuTu = 0;
        public FrmThi()
        {
            InitializeComponent();
        }

        private void btnBATDAUTHI_Click(object sender, EventArgs e)
        {

        }

        private void FrmThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_SERVER1.V_TENMHTHI' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'dS_SERVER1.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.dS_SERVER1.EnforceConstraints = false;
            this.v_TENMHTHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_TENMHTHITableAdapter.Fill(this.dS_SERVER1.V_TENMHTHI);
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS_SERVER1.GIAOVIEN_DANGKY);
            lbSOCAUTHI.Text = "";
            lbTRINHDO.Text = "";
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGVDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SERVER1);

        }

        private void cmbTENMONHOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            String MAMH = "";
            String strLenh = "EXEC SP_TIMMALOP N"+cmbTENMONHOC.SelectedValue.ToString()+"'";
            SqlDataReader reader = Program.ExecSqlDataReader(strLenh);
            Boolean rd = reader.Read();
            if (rd)
            {
                MAMH= reader["MAMH"].ToString();
            }

            Program.conn.Close();
            reader.Close();
            thuTu += 1;
            bdsFilter += "MAMH = '" + MAMH+ "'";
            bdsGVDK.Filter = bdsFilter;
            if (thuTu < 3)
                bdsFilter += "AND";
        }

        private void cmbNGAYTHI_SelectedIndexChanged(object sender, EventArgs e)
        {
            thuTu += 1;
            bdsFilter += "NGAYTHI = '" + cmbNGAYTHI.SelectedValue.ToString() + "'";
            bdsGVDK.Filter = bdsFilter;
            if (thuTu < 3)
                bdsFilter += "AND";
        }

        private void cmbLANTHI_SelectedIndexChanged(object sender, EventArgs e)
        {
            thuTu += 1;
            bdsFilter += "LAN = '" + cmbLANTHI.SelectedValue.ToString() + "'";
            bdsGVDK.Filter = bdsFilter;
            if (thuTu < 3)
                bdsFilter += "AND";
        }
    }
}