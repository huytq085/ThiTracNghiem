using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;
using ThiTracNghiem.Forms;

namespace ThiTracNghiem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static string username = "";
        public static string password = "";
        public static String servername = "";
        public static String servername1 = "";
        public static String servername2 = "";
        public static String mlogin = "";

        public static String database = "TRACNGHIEM";
        public static String remotelogin = "SUPPORT_CONNECT";
        public static string remotepassword = "123";
        public static string pwdSV = "123";
        public static string hoTen = "";
        public static string nhom = "";
        public static string mauser = "";   //Mã giáo viên hoặc mã sinh viên
        public static string id = "";
        public static string donVi = "";
        public static string tenDonVi = "";
        public static string chiNhanh = "";
        public static string maChiNhanh = "";
        public static int mCoSo = 0;
        public static string mloginDB = "";
        public static string mpasswordDB = "";
        public static BindingSource bds_dspm = new BindingSource();  // giữ TRACNGHIEMDataSet khi đăng nhập
        public static BindingSource bds_lop = new BindingSource();  // giữ BDSLOP khi load form lớp
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd, string connstr)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new Forms.FrmLogin());
            //Application.Run(new Form.FrmStudent());
        }
    }
}
