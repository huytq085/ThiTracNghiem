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
                txtFooterId.Caption = "Mã sinh viên: " + Program.id;
                txtFooterFullName.Caption = "Họ tên: " + Program.hoTen;
                txtFooterClass.Caption = "Lớp: " + Program.donVi;
            }

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            FrmKhoa frmKhoa = new FrmKhoa();
            frmKhoa.Closed += (s, args) => this.Show();
            frmKhoa.Show();
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