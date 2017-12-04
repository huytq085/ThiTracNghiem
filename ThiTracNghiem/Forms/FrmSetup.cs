using System;
using System.Data.SqlClient;

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
                if (!isExist(MAMH, MALOP, LAN))
                {
                    if (hasQuestions(MAMH, TRINHDO, SOCAUTHI))
                    {
                        DBAppDataContext db = new DBAppDataContext();
                        db.Connection.ConnectionString = Program.connstr;
                        GIAOVIEN_DANGKY gvDangKy = new GIAOVIEN_DANGKY();
                        gvDangKy.MAGV = Program.id.ToUpper();
                        gvDangKy.MALOP = MALOP;
                        gvDangKy.MAMH = MAMH;
                        gvDangKy.TRINHDO = TRINHDO;
                        gvDangKy.NGAYTHI = NGAYTHI.AddTicks(-(NGAYTHI.Ticks % TimeSpan.TicksPerSecond)); ;
                        gvDangKy.THOIGIAN = THOIGIAN;
                        gvDangKy.SOCAUTHI = SOCAUTHI;
                        gvDangKy.LAN = LAN;
                        db.GIAOVIEN_DANGKies.InsertOnSubmit(gvDangKy);
                        db.SubmitChanges();
                        DlgOk.Show("Đăng ký thành công", "Xác nhận");
                    }
                    else
                    {
                        DlgOk.Show("Giáo viên chưa có bộ đề hoặc bộ đề không đủ", "Xác nhận");
                    }
                }
                else
                {
                    DlgOk.Show("Lịch thi trùng");
                }
            }
            catch (Exception ex)
            {
                DlgOk.Show(ex.ToString());
            }


        }
        private bool hasQuestions(String maMH, Char trinhDo, short soCau)
        {
            String strLenh = "EXEC SP_LOCDE '" + maMH.Trim() + "','" + trinhDo + "'," + soCau;
            SqlDataReader reader = Program.ExecSqlDataReader(strLenh);
            if (reader == null || !reader.HasRows)
            {
                reader.Close();
                return false;
            }
            Program.conn.Close();
            reader.Close();
            return true;
        }

        private bool isExist(string maMH, string lop, short lan)
        {
            String strLenh = "SELECT MAGV FROM GIAOVIEN_DANGKY WHERE MAMH = '" + maMH + "' AND MALOP='" + lop + "' AND LAN=" + lan;
            SqlDataReader reader = Program.ExecSqlDataReader(strLenh);
            if (reader == null || !reader.HasRows)
            {
                reader.Close();
                return false;
            }
            Program.conn.Close();
            reader.Close();
            return true;
        }
    }
}