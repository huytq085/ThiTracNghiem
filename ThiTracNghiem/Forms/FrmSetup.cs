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
    public partial class FrmSetup : DevExpress.XtraEditors.XtraForm
    {
        public FrmSetup()
        {
            InitializeComponent();
        }

        private void FrmSetup_Load(object sender, EventArgs e)
        {
            cbbTRINHDO.SelectedIndex = 0;
            dpNGAYTHI.EditValue = DateTime.Now;
            dpNGAYTHI.Properties.MinValue = DateTime.Now;
            if (Program.connstr != null)
            {
                this.v_DS_LOPTableAdapter.Connection.ConnectionString = this.v_DS_MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            }
            dS_SERVER1.EnforceConstraints = false;
            this.v_DS_MONHOCTableAdapter.Fill(this.dS_SERVER1.V_DS_MONHOC);
            this.v_DS_LOPTableAdapter.Fill(this.dS_SERVER1.V_DS_LOP);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String MALOP = cbbMALOP.SelectedValue.ToString();
            String MAMH = cbbMAMH.SelectedValue.ToString();
            Char TRINHDO = Char.Parse(cbbTRINHDO.Text);
            DateTime NGAYTHI = dpNGAYTHI.DateTime;
            short SOCAUTHI = (short) nmrSOCAUTHI.Value;
            short THOIGIAN = (short) nmrTHOIGIAN.Value;
            short LAN = (short)nmrLAN.Value;
            try
            {
                DBAppDataContext db = new DBAppDataContext();
                db.Connection.ConnectionString = Program.connstr;
                GIAOVIEN_DANGKY setup = new GIAOVIEN_DANGKY();
                setup.MAGV = Program.id.ToUpper();
                setup.MALOP = MALOP;
                setup.MAMH = MAMH;
                setup.TRINHDO = TRINHDO;
                setup.NGAYTHI = NGAYTHI;
                setup.THOIGIAN = THOIGIAN;
                setup.SOCAUTHI = SOCAUTHI;
                setup.LAN = LAN;
                db.GIAOVIEN_DANGKies.InsertOnSubmit(setup);
                db.SubmitChanges();
                
                DlgOk.getInstance("Đăng ký thành công", "Xác nhận").ShowDialog();

            } catch (Exception ex)
            {
                DlgOk.getInstance(ex.ToString()).ShowDialog();
            }

        }

    }
}