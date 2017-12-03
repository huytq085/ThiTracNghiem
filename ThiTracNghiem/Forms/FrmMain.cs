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

namespace ThiTracNghiem.Forms
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return ;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            ShowMdiChildren(typeof(Test));
            if (Program.username != null && Program.nhom != null && Program.id != null)
            {
                switch (Program.nhom)
                {
                    case "SINHVIEN":
                        btnSetup.Dispose();
                        btnAddPacket.Dispose();
                        rbControl.Dispose();
                        txtFooterId.Caption = "MÃ SINH VIÊN: " + Program.id.ToUpper();
                        txtFooterFullName.Caption = "HỌ TÊN: " + Program.hoTen.ToUpper();
                        txtFooterClass.Caption = "MÃ LỚP: " + Program.donVi.ToUpper();
                        txtFooterTenLop.Caption = "TÊN LỚP: " + Program.tenDonVi.ToUpper();
                        break;
                    case "GIAOVIEN":
                        btnDept.Dispose();
                        btnClass.Dispose();
                        btnSubject.Dispose();
                        btnStudent.Dispose();
                        btnTeacher.Dispose();
                        txtFooterTenLop.Dispose();
                        txtFooterId.Caption = "MÃ GIÁO VIÊN: " + Program.id.ToUpper();
                        txtFooterFullName.Caption = "HỌ TÊN: " + Program.hoTen.ToUpper();
                        txtFooterClass.Caption = "KHOA: " + Program.donVi.ToUpper();
                        break;
                    case "COSO":
                    case "TRUONG":
                        txtFooterId.Caption = "MÃ GIÁO VIÊN: " + Program.id.ToUpper();
                        txtFooterFullName.Caption = "HỌ TÊN: " + Program.hoTen.ToUpper();
                        txtFooterClass.Caption = "NHÓM: " + Program.nhom.ToUpper();
                        txtFooterTenLop.Dispose();
                        break;
                    default:
                        break;
                }

                
            }

        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.bds_dspm = null;
            Program.servername = "";
            Program.conn.Close();
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Closed += (s, args) => this.Close();
            frmLogin.Show();
        }

        private void btnSetup_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmSetup));
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmStudent));
        }

        private void btnSubject_ItemClick(object sender, ItemClickEventArgs e)
        {

            ShowMdiChildren(typeof(FrmSubject));
        }

        private void btnClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmClass));
        }

        private void btnTeacher_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmTeacher));
        }

        private void btnQuestions_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmQuestion));
        }

        private void btnDept_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmDept));
        }

        private void btnAddPacket_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnStart_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmThi));
        }

        private void btnReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmSubjectScoreRpt));
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void txtFooterId_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barStaticItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void txtFooterFullName_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void txtFooterClass_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void txtFooterTenLop_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbFooter_Click(object sender, EventArgs e)
        {

        }
    }
}