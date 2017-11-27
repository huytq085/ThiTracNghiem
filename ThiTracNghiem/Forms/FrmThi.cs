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

            int xPanel1 = 10;
            int yPanel1 = (panel1.Height - lbDESMONHOC.Height) / 2;
            lbDESMONHOC.Location = new Point(xPanel1,yPanel1 );

            xPanel1 += lbDESMONHOC.Width + 20;
            yPanel1 = (panel1.Height - cmbTENMONHOC.Height) / 2;
            cmbTENMONHOC.Location = new Point(xPanel1,yPanel1);

            xPanel1 += cmbTENMONHOC.Width + 20;
            yPanel1 = (panel1.Height - lbDESNGAYTHI.Height) / 2;
            lbDESNGAYTHI.Location = new Point(xPanel1, yPanel1);

            xPanel1 += lbDESNGAYTHI.Width + 20;
            yPanel1 = (panel1.Height -cmbNGAYTHI.Height) / 2;
            cmbNGAYTHI.Location = new Point(xPanel1, yPanel1);

            xPanel1 += cmbNGAYTHI.Width + 20;
            yPanel1 = (panel1.Height - lbDESLANTHI.Height) / 2;
            lbDESLANTHI.Location = new Point(xPanel1, yPanel1);

            xPanel1 += lbDESLANTHI.Width + 20;
            yPanel1 = (panel1.Height - cmbLANTHI.Height) / 2;
            cmbLANTHI.Location = new Point(xPanel1, yPanel1);

            xPanel1 =panel1.Width-btnBATDAUTHI.Width- 20;
            yPanel1 = (panel1.Height - btnBATDAUTHI.Height) / 2;
            btnBATDAUTHI.Location = new Point(xPanel1, yPanel1);

            xPanel1 -= btnBATDAUTHI.Width+20;
            yPanel1 = (panel1.Height - btnCHONLAI.Height) / 2;
            btnCHONLAI.Location = new Point(xPanel1, yPanel1);

            lbDESTHOIGIAN.Location=new Point((panel2.Width-lbDESTHOIGIAN.Width)/2,(panel2.Height/2-50));

            int xPanel2 = panel2.Width-btnNOPBAI.Width;
            int yPanel2 = panel2.Height;
            btnNOPBAI.Location = new Point(xPanel2/2,yPanel2);
        }

        private void btnBATDAUTHI_Click(object sender, EventArgs e)
        {
            btnCHONLAI.Enabled = false;
            btnBATDAUTHI.Enabled = false;
            btnNOPBAI.Enabled = true;
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
            cmbLANTHI.SelectedIndex = -1;
            cmbNGAYTHI.SelectedIndex = -1;
            cmbTENMONHOC.SelectedIndex = -1;
            cmbTENMONHOC.Enabled = true;
            cmbLANTHI.Enabled = false;
            cmbNGAYTHI.Enabled = false;
            btnBATDAUTHI.Enabled = false;
            btnNOPBAI.Enabled = false;
            lbSOCAUTHI.Text = "";
            lbTRINHDO.Text = "";
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGVDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SERVER1);

        }
        public static String timMAMH(String tenMH)
        {
            String MAMH = "";
            String strLenh = "EXEC SP_TIMMALOP N'" + tenMH + "'";
            SqlDataReader reader = Program.ExecSqlDataReader(strLenh);
            Boolean rd = reader.Read();
            if (rd)
            {
                MAMH = reader[0].ToString();
            }

            Program.conn.Close();
            reader.Close();
            return MAMH;
        }
        public static void kiemTraThuTu(int thuTu,ref String bdsFilter)
        {
            
            if (thuTu > 1 && thuTu <= 3)
                bdsFilter += " AND ";
            if (thuTu > 3)
            {
                thuTu = 0;
                bdsFilter = "";
            }
        }

        private void cmbTENMONHOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTENMONHOC.SelectedValue != null)
            {
                cmbTENMONHOC.Enabled = false;
                cmbNGAYTHI.Enabled = true;
                thuTu += 1;
                if (thuTu == 3)
                {
                    lbSOCAUTHI.Text = ((DataRowView)bdsGVDK[0])["SOCAUTHI"].ToString();
                    lbTRINHDO.Text = ((DataRowView)bdsGVDK[0])["TRINHDO"].ToString();
                }
                kiemTraThuTu(thuTu, ref bdsFilter);

                String MAMH = "";
                MAMH = timMAMH(cmbTENMONHOC.SelectedValue.ToString());

                bdsFilter += "MAMH = '" + MAMH + "'";
                bdsGVDK.Filter = bdsFilter;
                cmbLANTHI.SelectedIndex = -1;
                cmbNGAYTHI.SelectedIndex = -1;

            }
        }

        private void cmbNGAYTHI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNGAYTHI.SelectedValue != null)
            {
                cmbNGAYTHI.Enabled = false;
                cmbLANTHI.Enabled = true;
                thuTu += 1;
                if (thuTu == 3)
                {
                    lbSOCAUTHI.Text = ((DataRowView)bdsGVDK[0])["SOCAUTHI"].ToString();
                    lbTRINHDO.Text = ((DataRowView)bdsGVDK[0])["TRINHDO"].ToString();
                }
                kiemTraThuTu(thuTu, ref bdsFilter);
                bdsFilter += "NGAYTHI = '" + cmbNGAYTHI.SelectedValue.ToString() + "'";
                bdsGVDK.Filter = bdsFilter;
                cmbLANTHI.SelectedIndex = -1;
            }
        }

        private void cmbLANTHI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLANTHI.SelectedValue != null)
            {
                cmbLANTHI.Enabled = false;
                thuTu += 1;
                if (thuTu == 3)
                {
                    lbSOCAUTHI.Text = ((DataRowView)bdsGVDK[0])["SOCAUTHI"].ToString();
                    lbTRINHDO.Text = ((DataRowView)bdsGVDK[0])["TRINHDO"].ToString();
                }
                kiemTraThuTu(thuTu, ref bdsFilter);
                bdsFilter += "LAN =" + cmbLANTHI.SelectedValue.ToString();
                bdsGVDK.Filter = bdsFilter;
                btnBATDAUTHI.Enabled = true;
            }
        }

        private void btnCHONLAI_Click(object sender, EventArgs e)
        {
            cmbLANTHI.SelectedIndex = -1;
            cmbNGAYTHI.SelectedIndex = -1;
            cmbTENMONHOC.SelectedIndex = -1;
            cmbTENMONHOC.Enabled = true;
            cmbLANTHI.Enabled = false;
            cmbNGAYTHI.Enabled = false;
            lbSOCAUTHI.Text = "";
            lbTRINHDO.Text = "";
            thuTu = 0;
            bdsFilter = "";
        }
    }
}