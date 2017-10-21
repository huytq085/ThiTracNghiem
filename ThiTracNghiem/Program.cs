using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;
using ThiTracNghiem.Form;

namespace ThiTracNghiem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static string username = ConnectionSettings.Default.login;
        public static string password = ConnectionSettings.Default.pwd;
        public static String servername = ConnectionSettings.Default.DefaultDatasource;
        public static String servername1 = "";
        public static String servername2 = "";
        public static String mlogin = "";

        public static String database = ConnectionSettings.Default.DefaultCatalog;
        public static String remotelogin = "";

        public static string hoTen = "";
        public static string nhom = "";
        public static string id = "";
        public static string donVi = "";
        public static string tenDonVi = "";
        public static string chiNhanh = "";
        public static string maChiNhanh = "";

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập

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
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn hãy xem lại tên đăng nhập và và mật khẩu.\n " + e.Message, "", MessageBoxButtons.OK);
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
        public static SqlDataReader ExecSqlDataReader(string _cmd, string[] name = null, object[] value = null, int NoParam = 0,
                    CommandType cmdType = CommandType.StoredProcedure)
        {
            try
            {
                SqlDataReader reader;
                if (Program.conn == null || Program.conn.State == ConnectionState.Closed)
                    KetNoi();
                using (SqlCommand sqlCmd = new SqlCommand(_cmd, Program.conn) { CommandType = CommandType.Text })
                {
                    for (int i = 0; i < NoParam; i++)
                    {
                        sqlCmd.Parameters.AddWithValue(name[i], value[i]);
                    }
                    sqlCmd.CommandType = cmdType;
                    reader = sqlCmd.ExecuteReader();
                }
                return reader;
            }
            catch (SqlException)
            {
                //MessageBox.Show(e.Message);
                Program.conn.Close();
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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new Form.FrmLogin());
            Console.WriteLine("Test2");
        }
    }
}
