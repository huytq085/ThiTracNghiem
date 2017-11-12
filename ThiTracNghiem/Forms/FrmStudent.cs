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
    public partial class FrmStudent : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SERVER1);

        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_SERVER1.V_DS_LOP' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dS_SERVER1.BANGDIEM' table. You can move, or remove it, as needed.


            // TODO: This line of code loads data into the 'dS_SERVER1.SINHVIEN' table. You can move, or remove it, as needed.
            dS_SERVER1.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS_SERVER1.SINHVIEN);
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS_SERVER1.BANGDIEM);
            this.v_DS_LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_LOPTableAdapter.Fill(this.dS_SERVER1.V_DS_LOP);
            gridView1.OptionsBehavior.Editable = false;

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;
            if (Program.nhom == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled =  btnGhi.Enabled = btnUndo.Enabled = false;
                btnReload.Enabled = btnPrint.Enabled = true;
            }
            else
                cmbCoSo.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                    return;
                Program.servername = cmbCoSo.SelectedValue.ToString();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            
            if (cmbCoSo.SelectedIndex != Program.mCoSo)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDB;
                Program.password = Program.mpasswordDB;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS_SERVER1.SINHVIEN);
                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.dS_SERVER1.BANGDIEM);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // gridView1.OptionsBehavior.Editable = true;
            viTri = bdsSV.Position;
            groupBox1.Enabled = true;
            bdsSV.AddNew();
            cmbMALOP.DataSource = v_bdsMALOP;
            //cmbMALOP.DisplayMember = "MALOP";
            //cmbMALOP.ValueMember = "MALOP";
            cmbMALOP.SelectedIndex = 0;
            dtpNGAYSINH.EditValue = "";
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcSV.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsSV.Position;
            groupBox1.Enabled = true;
            cmbMALOP.DataSource = v_bdsMALOP;
            //cmbMALOP.DisplayMember = "MALOP";
            //cmbMALOP.ValueMember = "MALOP";
            
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcSV.Enabled = true;
        }
      
        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();
            if (btnThem.Enabled == false) bdsSV.Position = viTri;
            gcSV.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMASV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được phép rỗng", "", MessageBoxButtons.OK);
                txtMASV.Focus();
                return;
            }
            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được phép rỗng", "", MessageBoxButtons.OK);
                txtHO.Focus();
                return;
            }
            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được phép rỗng", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }
            if (txtDIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được phép rỗng", "", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return;
            }
            if (dtpNGAYSINH.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh không được phép rỗng", "", MessageBoxButtons.OK);
                dtpNGAYSINH.Focus();
                return;
            }
            
            //((DataRowView)bdsSV[0])["MALOP"] = cmbMALOP.SelectedText.ToString().Trim();
            try
            {
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS_SERVER1.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcSV.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sINHVIENTableAdapter.Fill(this.dS_SERVER1.SINHVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        
    }
}