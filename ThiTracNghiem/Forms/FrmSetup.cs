using System;

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
                GIAOVIEN_DANGKY gvDangKy = new GIAOVIEN_DANGKY();
                gvDangKy.MAGV = Program.id.ToUpper();
                gvDangKy.MALOP = MALOP;
                gvDangKy.MAMH = MAMH;
                gvDangKy.TRINHDO = TRINHDO;
                gvDangKy.NGAYTHI = NGAYTHI;
                gvDangKy.THOIGIAN = THOIGIAN;
                gvDangKy.SOCAUTHI = SOCAUTHI;
                gvDangKy.LAN = LAN;
                db.GIAOVIEN_DANGKies.InsertOnSubmit(gvDangKy);
                db.SubmitChanges();
                
                DlgOk.getInstance("Đăng ký thành công", "Xác nhận").ShowDialog();

            } catch (Exception ex)
            {
                DlgOk.getInstance(ex.ToString()).ShowDialog();
            }

        }

    }
}