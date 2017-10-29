using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ThiTracNghiem.Form
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Program.username != null && Program.nhom != null && Program.id != null)
            {
                if (Program.nhom.Equals("SINHVIEN"))
                {
                    txtFooterId.Caption = "Mã sinh viên: " + Program.id;
                    txtFooterFullName.Caption = "Họ tên: " + Program.hoTen;
                    txtFooterClass.Caption = "Lớp: " + Program.donVi;
                } else if (Program.nhom.Equals("GIAOVIEN"))
                {
                    txtFooterId.Caption = "Mã giáo viên: " + Program.id;
                    txtFooterFullName.Caption = "Họ tên: " + Program.hoTen;
                    txtFooterClass.Caption = "Khoa: " + Program.donVi;
                } else if (Program.nhom.Equals("COSO"))
                {
                    txtFooterId.Caption = "Mã cơ sở: " + Program.donVi;
                    txtFooterFullName.Dispose();
                    txtFooterClass.Caption = "Tên cơ sở: " + Program.tenDonVi;
                }
            }

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmKhoa frmKhoa = new FrmKhoa();
            frmKhoa.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.bds_dspm = null;
            Program.servername = "";
            Program.conn.Close();
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Closed += (s, args) => this.Close();
            frmLogin.Show();
        }
    }
}