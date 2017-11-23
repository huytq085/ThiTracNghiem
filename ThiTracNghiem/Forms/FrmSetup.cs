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
            cbbLevel.SelectedIndex = 0;
            dpStartDate.EditValue = DateTime.Now;
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
            String className = cbbClassName.SelectedValue.ToString();
            String subjectName = cbbSubjectName.SelectedValue.ToString();
            String level = cbbLevel.Text;
            int times = (int) nmrTimes.Value;
            int numOfQuestions = (int) nmrNumOfQuestions.Value;
            int numOfMinutes = (int) nmrNumOfMinutes.Value;
            DateTime startDate = dpStartDate.DateTime;

        }

    }
}