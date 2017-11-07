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
    public partial class DlgConfirm : DevExpress.XtraEditors.XtraForm
    {
        public DlgConfirm()
        {
            InitializeComponent();
        }
        public DlgConfirm(String msg, String txtOk, String txtCancel)
        {
            InitializeComponent();
            lbMsg.Text = msg;
            btnOk.Text = txtOk;
            btnCancel.Text = txtCancel;
        }
    }
}