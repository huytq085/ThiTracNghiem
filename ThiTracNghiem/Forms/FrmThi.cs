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
        int minute = 0;
        int sec = 0;
        String MAMH = "";
        String trinhDo = "";
        int soCau = 0;
        public FrmThi()
        {
            
            InitializeComponent();
            int khoangCach = 20;
            int xPanel1 = 10;
            int yPanel1 = (panel1.Height - lbDESMONHOC.Height) / 2;
            lbDESMONHOC.Location = new Point(xPanel1,yPanel1 );

            xPanel1 += lbDESMONHOC.Width + khoangCach;
            yPanel1 = (panel1.Height - cmbTENMONHOC.Height) / 2;
            cmbTENMONHOC.Location = new Point(xPanel1,yPanel1);

            xPanel1 += cmbTENMONHOC.Width + khoangCach;
            yPanel1 = (panel1.Height - lbDESNGAYTHI.Height) / 2;
            lbDESNGAYTHI.Location = new Point(xPanel1, yPanel1);

            xPanel1 += lbDESNGAYTHI.Width + khoangCach;
            yPanel1 = (panel1.Height -cmbNGAYTHI.Height) / 2;
            cmbNGAYTHI.Location = new Point(xPanel1, yPanel1);

            xPanel1 += cmbNGAYTHI.Width + khoangCach;
            yPanel1 = (panel1.Height - lbDESLANTHI.Height) / 2;
            lbDESLANTHI.Location = new Point(xPanel1, yPanel1);

            xPanel1 += lbDESLANTHI.Width + khoangCach;
            yPanel1 = (panel1.Height - cmbLANTHI.Height) / 2;
            cmbLANTHI.Location = new Point(xPanel1, yPanel1);

            xPanel1 =panel1.Width-btnBATDAUTHI.Width- khoangCach;
            yPanel1 = (panel1.Height - btnBATDAUTHI.Height) / 2;
            btnBATDAUTHI.Location = new Point(xPanel1, yPanel1);

            xPanel1 -= btnBATDAUTHI.Width+khoangCach;
            yPanel1 = (panel1.Height - btnCHONLAI.Height) / 2;
            btnCHONLAI.Location = new Point(xPanel1, yPanel1);

            lbDESTRINHDO.Location = new Point(khoangCach*2, khoangCach*2);
            lbTRINHDO.Location = new Point(panel2.Width - khoangCach * 2 - lbTRINHDO.Width, khoangCach * 2);
            lbDESSOCAUTHI.Location = new Point(khoangCach*2, khoangCach * 4);
            lbSOCAUTHI.Location = new Point(panel2.Width - khoangCach * 2 - lbTRINHDO.Width, khoangCach * 4);

            lbDESTHOIGIAN.Location=new Point((panel2.Width-lbDESTHOIGIAN.Width)/2,(panel2.Height/2-50));
            lbTHOIGIAN.Text = "00 : 00";
            lbTHOIGIAN.Location = new Point((panel2.Width - lbTHOIGIAN.Width) / 2, (panel2.Height / 2));

            int xPanel2 = panel2.Width-btnNOPBAI.Width;
            int yPanel2 = panel2.Height;
            btnNOPBAI.Location = new Point(xPanel2/2,yPanel2);
        }

        private void btnBATDAUTHI_Click(object sender, EventArgs e)
        {
            
            trinhDo = lbTRINHDO.Text;
            soCau = int.Parse(lbSOCAUTHI.Text);

            String[] cauhoi = new String[soCau];
            String[] A = new String[soCau];
            String[] B = new String[soCau];
            String[] C = new String[soCau];
            String[] D = new String[soCau];
            String[] DA = new String[soCau];
            int j = 0;
            String strLenh = "EXEC SP_LOCDE '" + MAMH.Trim() + "','" + trinhDo.Trim() + "'," + soCau;
            SqlDataReader reader = Program.ExecSqlDataReader(strLenh);
            Boolean rd = reader.Read();
            while (rd)
            {
                
                cauhoi[j] =reader["NOIDUNG"].ToString();
                
                A[j] = reader["A"].ToString();
                B[j] = reader["B"].ToString();
                C[j] = reader["C"].ToString();
                D[j] = reader["D"].ToString();
                A[j] = reader["A"].ToString();
                DA[j] =reader["DAP_AN"].ToString();
                j++;
                rd=reader.Read();
            }

            Program.conn.Close();
            reader.Close();
            btnCHONLAI.Enabled = false;
            btnBATDAUTHI.Enabled = false;
            btnNOPBAI.Enabled = true;
            minute = int.Parse(((DataRowView)bdsGVDK[cmbLANTHI.SelectedIndex])["THOIGIAN"].ToString());
            sec = 0;
            timer1.Start();
            timer1.Interval = 1000;
            int socau = int.Parse(((DataRowView)bdsGVDK[0])["SOCAUTHI"].ToString().Trim());
            Label[] lbCAUHOI = new Label[socau];
            RadioButton[] rdA = new RadioButton[socau];
            RadioButton[] rdB = new RadioButton[socau];
            RadioButton[] rdC = new RadioButton[socau];
            RadioButton[] rdD = new RadioButton[socau];
            Label[] lbDAPAN = new Label[socau];
            Panel[] pn = new Panel[socau];
            
            for (int i = 0; i < socau; i++)
            {
                pn[i] = new Panel();
                lbCAUHOI[i] = new Label();
                rdA[i] = new RadioButton();
                rdB[i] = new RadioButton();
                rdC[i] = new RadioButton();
                rdD[i] = new RadioButton();

                
                lbCAUHOI[i].Name = "lb" + i.ToString();
                rdA[i].Name = "lb" + i;
                rdB[i].Name = "lb" + i;
                rdC[i].Name = "lb" + i;
                rdD[i].Name = "lb" + i;

                lbCAUHOI[i].Text = "Câu "+(i+1).ToString()+" : " + cauhoi[i].ToString();
                rdA[i].Text = "A. " + A[i].ToString();
                rdB[i].Text = "B. " + B[i].ToString();
                rdC[i].Text = "C. " + C[i].ToString();
                rdD[i].Text = "D. " + D[i].ToString();

                lbCAUHOI[i].AutoSize = true;
                rdA[i].AutoSize = true;
                rdB[i].AutoSize = true;
                rdC[i].AutoSize = true;
                rdD[i].AutoSize = true;
                pn[i].AutoSize = true;

                lbCAUHOI[i].Location = new Point(20,30);
                rdA[i].Location = new Point(70, 60);
                rdB[i].Location = new Point(70, 90);
                rdC[i].Location = new Point(70, 120);
                rdD[i].Location = new Point(70, 150);

                pn[i].Location = new Point(0, i * 180);
                
                pn[i].Controls.Add(lbCAUHOI[i]);
                pn[i].Controls.Add(rdA[i]);
                pn[i].Controls.Add(rdB[i]);
                pn[i].Controls.Add(rdC[i]);
                pn[i].Controls.Add(rdD[i]);

                panel3.Controls.Add(pn[i]);
            }
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
            
            cmbTENMONHOC.Enabled = true;
            cmbLANTHI.Enabled = false;
            cmbNGAYTHI.Enabled = false;
            btnBATDAUTHI.Enabled = false;
            btnNOPBAI.Enabled = false;
            lbSOCAUTHI.Text = "";
            lbTRINHDO.Text = "";
            lbTHOIGIAN.Text = "";
            if (Program.nhom == "SINHVIEN")
                bdsFilter = "MALOP = '" + Program.donVi.ToString().Trim() + "'";
            if (Program.nhom == "GIAOVIEN")
                bdsFilter = "MAGV = '" + Program.id.ToString().Trim() + "'";
            //bdsV_TENMHTHI.Filter = "MAGV = N'" + Program.id.ToString().Trim() + "'";
            bdsGVDK.Filter = bdsFilter;
            cmbLANTHI.SelectedIndex = -1;
            cmbNGAYTHI.SelectedIndex = -1;
            cmbTENMONHOC.SelectedIndex = -1;
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
            
            if (thuTu > 0 && thuTu <= 3)
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
                    lbTHOIGIAN.Text = ((DataRowView)bdsGVDK[cmbLANTHI.SelectedIndex])["THOIGIAN"].ToString()+" : 00" ;
                }
                kiemTraThuTu(thuTu, ref bdsFilter);

                
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
                    lbTHOIGIAN.Text = ((DataRowView)bdsGVDK[cmbLANTHI.SelectedIndex])["THOIGIAN"].ToString() + " : 00";
                    
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
                    lbTHOIGIAN.Text = ((DataRowView)bdsGVDK[cmbLANTHI.SelectedIndex])["THOIGIAN"].ToString() + " : 00";
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
            lbTHOIGIAN.Text = "";
            thuTu = 0;
            //bdsFilter = "MALOP = N'" + Program.donVi + "' AND ";
            if (Program.nhom == "SINHVIEN")
                bdsFilter = "MALOP = '" + Program.donVi.ToString().Trim() + "'";
            if (Program.nhom == "GIAOVIEN")
                bdsFilter = "MAGV = '" + Program.id.ToString().Trim() + "'";
        }
        public static String fixTime(int minute,int sec)
        {
            String time = "";
            String phut = "";
            String giay = "";
            if (minute < 9)
                phut = "0" + minute;
            else
                phut = "" + minute;
            if (sec < 9)
                giay = "0" + sec;
            else
                giay = "" + sec;

            time = phut + " : " + giay;
            return time;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (minute < 5)
            {
                
            }
            lbTHOIGIAN.Text = fixTime(minute, sec);
            if (sec != 0)
            {
                sec--;
            }
            else
            {
                sec = 59;
                minute--;
            }
            if (minute == 0&&sec==0)
            {
                timer1.Stop();
                lbTHOIGIAN.Text = fixTime(minute, sec);
            }
            
        }
    }
}