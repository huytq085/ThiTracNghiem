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
    public partial class DlgOk : DevExpress.XtraEditors.XtraForm
    {
        private static DlgOk ok;
        public DlgOk()
        {
            InitializeComponent();
        }
        public DlgOk(string text)
        {
            InitializeComponent();
            this.lbText.Text = text;
        }
        public DlgOk(string text, string buttonText)
        {
            InitializeComponent();
            this.lbText.Text = text;
            this.btnOk.Text = buttonText;
        }
        public static void Show()
        {
            ok = new DlgOk();
            ok.StartPosition = FormStartPosition.CenterParent;
            ok.ShowDialog();
        }
        public static void Show(string text)
        {
            ok = new DlgOk(text);
            ok.StartPosition = FormStartPosition.CenterParent;
            ok.ShowDialog();
        }
        public static void Show(string text, string buttonText)
        {
            ok = new DlgOk(text, buttonText);
            ok.StartPosition = FormStartPosition.CenterParent;
            ok.ShowDialog();
        }
    }
}