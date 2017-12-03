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
    public partial class FrmResult : DevExpress.XtraEditors.XtraForm
    {
        private DataGridView dgv;
        private IDictionary<string, string> param;
        public FrmResult()
        {
            InitializeComponent();
        }
        public FrmResult(DataGridView dgv, IDictionary<string, string> param)
        {
            InitializeComponent();
            this.dgv = dgv;
            lbClass.Text = param["class"];
            lbName.Text = param["name"];
            lbSubject.Text = param["subject"];
            lbDate.Text = param["date"];
            lbTimes.Text = param["times"];
        }

        private void FrmResult_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (dataGridView1.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv.Columns)
                    {
                        dataGridView1.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dataGridView1.Rows.Add(row);
                }
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                
            }

        }
    }
}