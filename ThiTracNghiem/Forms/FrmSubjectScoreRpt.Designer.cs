namespace ThiTracNghiem.Forms
{
    partial class FrmSubjectScoreRpt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.vDSLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_SERVER1 = new ThiTracNghiem.DS_SERVER1();
            this.v_DS_LOPTableAdapter = new ThiTracNghiem.DS_SERVER1TableAdapters.V_DS_LOPTableAdapter();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.vDSMONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_MONHOCTableAdapter = new ThiTracNghiem.DS_SERVER1TableAdapters.V_DS_MONHOCTableAdapter();
            this.cbbTimes = new System.Windows.Forms.ComboBox();
            this.viewSubjectScoreRpt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptBangDiemMH1 = new ThiTracNghiem.rptBangDiemMH();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.vDSLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSMONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lần thi";
            // 
            // cbbClass
            // 
            this.cbbClass.DataSource = this.vDSLOPBindingSource;
            this.cbbClass.DisplayMember = "TENLOP";
            this.cbbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(75, 38);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(121, 21);
            this.cbbClass.TabIndex = 3;
            this.cbbClass.ValueMember = "MALOP";
            // 
            // vDSLOPBindingSource
            // 
            this.vDSLOPBindingSource.DataMember = "V_DS_LOP";
            this.vDSLOPBindingSource.DataSource = this.dS_SERVER1;
            // 
            // dS_SERVER1
            // 
            this.dS_SERVER1.DataSetName = "DS_SERVER1";
            this.dS_SERVER1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_LOPTableAdapter
            // 
            this.v_DS_LOPTableAdapter.ClearBeforeFill = true;
            // 
            // cbbSubject
            // 
            this.cbbSubject.DataSource = this.vDSMONHOCBindingSource;
            this.cbbSubject.DisplayMember = "TENMH";
            this.cbbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(291, 38);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(121, 21);
            this.cbbSubject.TabIndex = 4;
            this.cbbSubject.ValueMember = "MAMH";
            // 
            // vDSMONHOCBindingSource
            // 
            this.vDSMONHOCBindingSource.DataMember = "V_DS_MONHOC";
            this.vDSMONHOCBindingSource.DataSource = this.dS_SERVER1;
            // 
            // v_DS_MONHOCTableAdapter
            // 
            this.v_DS_MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // cbbTimes
            // 
            this.cbbTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimes.FormattingEnabled = true;
            this.cbbTimes.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbTimes.Location = new System.Drawing.Point(518, 38);
            this.cbbTimes.Name = "cbbTimes";
            this.cbbTimes.Size = new System.Drawing.Size(121, 21);
            this.cbbTimes.TabIndex = 5;
            // 
            // viewSubjectScoreRpt
            // 
            this.viewSubjectScoreRpt.ActiveViewIndex = -1;
            this.viewSubjectScoreRpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewSubjectScoreRpt.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewSubjectScoreRpt.Location = new System.Drawing.Point(12, 95);
            this.viewSubjectScoreRpt.Name = "viewSubjectScoreRpt";
            this.viewSubjectScoreRpt.ReportSource = this.rptBangDiemMH1;
            this.viewSubjectScoreRpt.Size = new System.Drawing.Size(1062, 405);
            this.viewSubjectScoreRpt.TabIndex = 6;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(729, 37);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // FrmSubjectScoreRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 537);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.viewSubjectScoreRpt);
            this.Controls.Add(this.cbbTimes);
            this.Controls.Add(this.cbbSubject);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSubjectScoreRpt";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDSLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSMONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbClass;
        private DS_SERVER1 dS_SERVER1;
        private System.Windows.Forms.BindingSource vDSLOPBindingSource;
        private DS_SERVER1TableAdapters.V_DS_LOPTableAdapter v_DS_LOPTableAdapter;
        private System.Windows.Forms.ComboBox cbbSubject;
        private System.Windows.Forms.BindingSource vDSMONHOCBindingSource;
        private DS_SERVER1TableAdapters.V_DS_MONHOCTableAdapter v_DS_MONHOCTableAdapter;
        private System.Windows.Forms.ComboBox cbbTimes;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer viewSubjectScoreRpt;
        private rptBangDiemMH rptBangDiemMH1;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
    }
}