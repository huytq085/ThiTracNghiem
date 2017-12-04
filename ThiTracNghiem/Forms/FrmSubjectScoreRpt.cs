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
    public partial class FrmSubjectScoreRpt : DevExpress.XtraEditors.XtraForm
    {
        public FrmSubjectScoreRpt()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            v_DS_MONHOCTableAdapter.Connection.ConnectionString = v_DS_LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_SERVER1.V_DS_MONHOC' table. You can move, or remove it, as needed.
            cbbTimes.SelectedIndex = 0;
            this.v_DS_MONHOCTableAdapter.Fill(this.dS_SERVER1.V_DS_MONHOC);
            // TODO: This line of code loads data into the 'dS_SERVER1.V_DS_LOP' table. You can move, or remove it, as needed.
            this.v_DS_LOPTableAdapter.Fill(this.dS_SERVER1.V_DS_LOP);

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            rptBangDiemMH rp = new rptBangDiemMH();
            Console.WriteLine(cbbClass.SelectedValue.ToString());
            Console.WriteLine(cbbSubject.SelectedValue.ToString());
            Console.WriteLine(cbbTimes.Text.ToString().Trim());
            string cmd = "EXEC sp_BangDiemMH '" + cbbClass.SelectedValue.ToString().Trim() + "', '" +
             cbbSubject.SelectedValue.ToString().Trim() + "' ," + Int16.Parse(cbbTimes.Text.ToString().Trim());
            Console.WriteLine(cmd);
            DataTable MyTable = Program.ExecSqlDataTable(cmd, Program.connstr); 
            if (MyTable != null && !MyTable.HasErrors && MyTable.Rows.Count > 0)
            {
                try
                {
                    rp.SetDataSource(MyTable);
                    rp.SetParameterValue("TENMH", cbbClass.Text);
                    rp.SetParameterValue("TENLOP", cbbSubject.Text);
                    rp.SetParameterValue("LANTHI", cbbTimes.Text);
                    viewSubjectScoreRpt.ReportSource = rp;
                } catch (Exception ex)
                {
                    DlgOk.Show(ex.ToString());
                }
                
            } else
            {
                DlgOk.Show("Không có dữ liệu");
            }
        }
    }
}