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
using System.Data.SqlClient;

namespace ThiTracNghiem.Form
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DS_PHANMANH);

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbCoSo.SelectedValue.ToString() != null)
                {
                    Program.servername = cbbCoSo.SelectedValue.ToString();
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private bool Login(string username)
        {
            Boolean sinhvien = false;
            if (Program.password == "")
            {
                sinhvien = true;
                Program.username = Program.mlogin;
                Program.mlogin = "001";
                Program.password = Program.pwdSV;
            }
            if (Program.KetNoi() == 0) return false;
            String strLenh = "EXEC SP_DangNhap '" + Program.mlogin + "'";
            SqlDataReader reader = Program.ExecSqlDataReader(strLenh);
            if (reader == null)
                return false;
            reader.Read();
            if (reader.HasRows)
            {
                Program.donVi = reader["donvi"].ToString();
                Program.tenDonVi = reader["tendonvi"].ToString();
                Program.hoTen = reader["hoten"].ToString();
                Program.nhom = reader["nhom"].ToString();
                Program.id = username;
                reader.Close();
                if (!Program.nhom.Equals("SINHVIEN") && sinhvien)
                {
                    return false;
                } else if (sinhvien)
                {
                    strLenh = "EXEC SP_TimSV '" + username + "'";
                    reader = Program.ExecSqlDataReader(strLenh);
                    if (reader != null)
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            Program.donVi = reader["donvi"].ToString();
                            Program.tenDonVi = reader["tendonvi"].ToString();
                            Program.hoTen = reader["hoten"].ToString();
                            Program.id = username;
                        } else
                        {
                            return false;
                        }
                    }
                }
                Program.conn.Close();
                reader.Close();
            }
            else
            {
                Program.conn.Close();
                reader.Close();
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool result = false;
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Khong duoc rong", "Loi");
                txtUsername.Focus();
                return;
            }
            Program.servername = cbbCoSo.SelectedValue.ToString();
            Program.mlogin = txtUsername.Text;
            Program.password = txtPassword.Text;
            Program.bds_dspm = bdsPM;
            
            if (!Login(Program.mlogin))
                MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu");
            else
            {
                result = true;
                Console.WriteLine("Login successful");
            }
            if (result)
            {
                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.Closed += (s, args) => this.Close();
                frmMain.Show();
            }
        }

        private void v_DS_PHANMANHBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);
            if (e.KeyCode == Keys.Enter)
            {
                this.btnLogin_Click(sender, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);
            if (e.KeyCode == Keys.Enter)
            {
                this.btnLogin_Click(sender, e);
            }
        }
    }
}