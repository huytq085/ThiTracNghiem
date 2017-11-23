namespace ThiTracNghiem.Forms
{
    partial class FrmSetup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dpStartDate = new DevExpress.XtraEditors.DateEdit();
            this.btnReset = new System.Windows.Forms.Label();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.cbbSubjectName = new System.Windows.Forms.ComboBox();
            this.vDSMONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_SERVER1 = new ThiTracNghiem.DS_SERVER1();
            this.cbbClassName = new System.Windows.Forms.ComboBox();
            this.vDSLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_LOPTableAdapter = new ThiTracNghiem.DS_SERVER1TableAdapters.V_DS_LOPTableAdapter();
            this.v_DS_MONHOCTableAdapter = new ThiTracNghiem.DS_SERVER1TableAdapters.V_DS_MONHOCTableAdapter();
            this.nmrTimes = new System.Windows.Forms.NumericUpDown();
            this.nmrNumOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.nmrNumOfMinutes = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSMONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumOfQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumOfMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nmrNumOfMinutes);
            this.panel1.Controls.Add(this.nmrNumOfQuestions);
            this.panel1.Controls.Add(this.nmrTimes);
            this.panel1.Controls.Add(this.dpStartDate);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbLevel);
            this.panel1.Controls.Add(this.cbbSubjectName);
            this.panel1.Controls.Add(this.cbbClassName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 389);
            this.panel1.TabIndex = 0;
            // 
            // dpStartDate
            // 
            this.dpStartDate.EditValue = new System.DateTime(2017, 11, 24, 0, 9, 51, 234);
            this.dpStartDate.Location = new System.Drawing.Point(286, 234);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpStartDate.Size = new System.Drawing.Size(256, 20);
            this.dpStartDate.TabIndex = 16;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.btnReset.Location = new System.Drawing.Point(378, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(38, 13);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Đặt lại";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Appearance.Options.UseBackColor = true;
            this.btnSubmit.Appearance.Options.UseForeColor = true;
            this.btnSubmit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSubmit.Location = new System.Drawing.Point(422, 295);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Đăng ký";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Thời gian thi (phút)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số câu thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lần thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trình độ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên lớp";
            // 
            // cbbLevel
            // 
            this.cbbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbbLevel.Location = new System.Drawing.Point(286, 151);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(256, 21);
            this.cbbLevel.TabIndex = 2;
            // 
            // cbbSubjectName
            // 
            this.cbbSubjectName.DataSource = this.vDSMONHOCBindingSource;
            this.cbbSubjectName.DisplayMember = "TENMH";
            this.cbbSubjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubjectName.FormattingEnabled = true;
            this.cbbSubjectName.Location = new System.Drawing.Point(286, 124);
            this.cbbSubjectName.Name = "cbbSubjectName";
            this.cbbSubjectName.Size = new System.Drawing.Size(256, 21);
            this.cbbSubjectName.TabIndex = 1;
            this.cbbSubjectName.ValueMember = "MAMH";
            // 
            // vDSMONHOCBindingSource
            // 
            this.vDSMONHOCBindingSource.DataMember = "V_DS_MONHOC";
            this.vDSMONHOCBindingSource.DataSource = this.dS_SERVER1;
            // 
            // dS_SERVER1
            // 
            this.dS_SERVER1.DataSetName = "DS_SERVER1";
            this.dS_SERVER1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbClassName
            // 
            this.cbbClassName.DataSource = this.vDSLOPBindingSource;
            this.cbbClassName.DisplayMember = "TENLOP";
            this.cbbClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClassName.FormattingEnabled = true;
            this.cbbClassName.Location = new System.Drawing.Point(286, 97);
            this.cbbClassName.Name = "cbbClassName";
            this.cbbClassName.Size = new System.Drawing.Size(256, 21);
            this.cbbClassName.TabIndex = 0;
            this.cbbClassName.ValueMember = "MALOP";
            // 
            // vDSLOPBindingSource
            // 
            this.vDSLOPBindingSource.DataMember = "V_DS_LOP";
            this.vDSLOPBindingSource.DataSource = this.dS_SERVER1;
            // 
            // v_DS_LOPTableAdapter
            // 
            this.v_DS_LOPTableAdapter.ClearBeforeFill = true;
            // 
            // v_DS_MONHOCTableAdapter
            // 
            this.v_DS_MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // nmrTimes
            // 
            this.nmrTimes.Location = new System.Drawing.Point(286, 178);
            this.nmrTimes.Name = "nmrTimes";
            this.nmrTimes.Size = new System.Drawing.Size(256, 21);
            this.nmrTimes.TabIndex = 17;
            // 
            // nmrNumOfQuestions
            // 
            this.nmrNumOfQuestions.Location = new System.Drawing.Point(286, 205);
            this.nmrNumOfQuestions.Name = "nmrNumOfQuestions";
            this.nmrNumOfQuestions.Size = new System.Drawing.Size(256, 21);
            this.nmrNumOfQuestions.TabIndex = 18;
            // 
            // nmrNumOfMinutes
            // 
            this.nmrNumOfMinutes.Location = new System.Drawing.Point(286, 260);
            this.nmrNumOfMinutes.Name = "nmrNumOfMinutes";
            this.nmrNumOfMinutes.Size = new System.Drawing.Size(256, 21);
            this.nmrNumOfMinutes.TabIndex = 19;
            // 
            // FrmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 493);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSetup";
            this.Text = "FrmSetup";
            this.Load += new System.EventHandler(this.FrmSetup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSMONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumOfQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumOfMinutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLevel;
        private System.Windows.Forms.ComboBox cbbSubjectName;
        private System.Windows.Forms.ComboBox cbbClassName;
        private DS_SERVER1 dS_SERVER1;
        private System.Windows.Forms.BindingSource vDSLOPBindingSource;
        private DS_SERVER1TableAdapters.V_DS_LOPTableAdapter v_DS_LOPTableAdapter;
        private System.Windows.Forms.BindingSource vDSMONHOCBindingSource;
        private DS_SERVER1TableAdapters.V_DS_MONHOCTableAdapter v_DS_MONHOCTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private System.Windows.Forms.Label btnReset;
        private DevExpress.XtraEditors.DateEdit dpStartDate;
        private System.Windows.Forms.NumericUpDown nmrNumOfMinutes;
        private System.Windows.Forms.NumericUpDown nmrNumOfQuestions;
        private System.Windows.Forms.NumericUpDown nmrTimes;
    }
}