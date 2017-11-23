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
        int viTri = 0;
        public FrmQuestion()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBODE.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SERVER1);

        }

        private void FrmQuestion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_SERVER1.MONHOC' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'dS_SERVER1.BODE' table. You can move, or remove it, as needed.
            this.dS_SERVER1.EnforceConstraints = false;

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS_SERVER1.MONHOC);

            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS_SERVER1.BODE);

           // stt = bdsBODE.Count;
           // soCauHoi = int.Parse((((DataRowView)bdsBODE[0])["CAUHOI"].ToString()))+1;

            gridView1.OptionsBehavior.Editable = false;
            groupBox1.Enabled = false;
            txtMAGV.Enabled = false;
            numCauHoi.Enabled = false;
            List<String> cachXem = new List<String> { "TẤT CẢ ĐỀ THI","CÁ NHÂN" };
            cmbCachXem.DataSource = cachXem;
            if (cmbCachXem.SelectedValue.ToString() == "CÁ NHÂN") {
                bdsBODE.Filter = "MAGV = '"+Program.maUser+"'";
                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnXoa.Enabled = true;
                btnPrint.Enabled = btnReload.Enabled = true;                
            }
            else
            {
                bdsBODE.Filter="";
                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnXoa.Enabled = false;
                btnPrint.Enabled = btnReload.Enabled = true;
            }
            if (Program.nhom == "GIAOVIEN")
            {
                panel1.Enabled = true;
                
                
            }
            else
            {
                panel1.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCachXem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCachXem.SelectedValue.ToString() == "CÁ NHÂN")
            {
                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnXoa.Enabled = true;
                btnPrint.Enabled = btnReload.Enabled = true;
                bdsBODE.Filter = "MAGV = '" + Program.maUser + "'";
                if (bdsBODE.Position == -1)
                    btnSua.Enabled =btnXoa.Enabled =false;
            }
            else
            {
                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnXoa.Enabled = false;
                btnPrint.Enabled = btnReload.Enabled = true;
                bdsBODE.Filter = "";
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // gridView1.OptionsBehavior.Editable = true;
            viTri = bdsBODE.Position;
            groupBox1.Enabled = true;
            bdsBODE.AddNew();
            int countTable = dS_SERVER1.BODE.Count;
            int soCauHoi = Convert.ToInt32(dS_SERVER1.BODE.Rows[countTable-1]["CAUHOI"]);
             numCauHoi.Value =soCauHoi+1 ;
            //numCauHoi.Value = dS_SERVER1.BODE[countTable - 1].CAUHOI;
            txtMAGV.Text = Program.maUser;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcBODE.Enabled = false;
            cmbMAMH.DataSource = bdsMONHOC;
            cmbMAMH.SelectedIndex = 0;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.bODETableAdapter.Fill(this.dS_SERVER1.BODE);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsBODE.Position;
            groupBox1.Enabled = true;
            txtMAGV.EditValue = Program.maUser;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcBODE.Enabled = false;
            numCauHoi.Enabled = false;
            String maMH = cmbMAMH.SelectedValue.ToString();
            cmbMAMH.DataSource = bdsMONHOC;
            cmbMAMH.SelectedValue = maMH;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBODE.CancelEdit();
            if (btnThem.Enabled == false) bdsBODE.Position = viTri;
            gcBODE.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (txtNOIDUNG.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung không được phép rỗng", "", MessageBoxButtons.OK);
                txtNOIDUNG.Focus();
                return;
            }
            if ((txtA.Text.Trim() == "" && txtB.Text.Trim() == ""&& txtC.Text.Trim() == "")|| (txtA.Text.Trim() == "" && txtB.Text.Trim() == "" && txtD.Text.Trim() == "")|| (txtB.Text.Trim() == "" && txtC.Text.Trim() == "" && txtD.Text.Trim() == ""))
            {
                MessageBox.Show("ít nhất có 2 lựa chọn", "", MessageBoxButtons.OK);
                txtA.Focus();
                return;
            }
            if (txtTRINHDO.Text.Trim() == ""|| !(txtTRINHDO.Text.Trim()!="A"|| txtTRINHDO.Text.Trim() != "B"|| txtTRINHDO.Text.Trim() != "C"))
            {
                MessageBox.Show("Nội dung không được phép rỗng và phải là A, B hoặc C", "", MessageBoxButtons.OK);
                txtTRINHDO.Focus();
                return;
            }
            if (txtDAPAN.Text.Trim() == "" || !(txtDAPAN.Text.Trim() != "A" || txtDAPAN.Text.Trim() != "B" || txtDAPAN.Text.Trim() != "C" || txtDAPAN.Text.Trim() != "D"))
            {
                MessageBox.Show("Đáp án không được phép rỗng và phải là 1 trong 4 đáp án A,B,C,D", "", MessageBoxButtons.OK);
                txtDAPAN.Focus();
                return;
            }
            //((DataRowView)bdsSV[0])["MALOP"] = cmbMALOP.SelectedText.ToString().Trim();
            try
            {
                bdsBODE.EndEdit();
                bdsBODE.ResetCurrentItem();
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Update(this.dS_SERVER1.BODE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi câu hỏi vào bộ đề.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcBODE.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void gcBODE_Click(object sender, EventArgs e)
        {           
            
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 CauHoi = 0;
            if (MessageBox.Show("Bạn có thật sự muốn xóa câu hỏi này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    CauHoi = int.Parse(((DataRowView)bdsBODE[bdsBODE.Position])["CAUHOI"].ToString()); // giữ lại để khi xóa bị lỗi thì ta sẽ quay về lại
                    bdsBODE.RemoveCurrent();
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Update(this.dS_SERVER1.BODE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.bODETableAdapter.Fill(this.dS_SERVER1.BODE);
                    bdsBODE.Position = bdsBODE.Find("CAUHOI", CauHoi);
                    return;
                }
            }

            if (bdsBODE.Count == 0) btnXoa.Enabled = false;
        }
    }
}