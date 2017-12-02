namespace ThiTracNghiem.Forms
{
    partial class FrmThi
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
            this.btnCHONLAI = new System.Windows.Forms.Button();
            this.btnBATDAUTHI = new System.Windows.Forms.Button();
            this.cmbLANTHI = new System.Windows.Forms.ComboBox();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.dS_SERVER1 = new ThiTracNghiem.DS_SERVER1();
            this.cmbNGAYTHI = new System.Windows.Forms.ComboBox();
            this.cmbTENMONHOC = new System.Windows.Forms.ComboBox();
            this.bdsV_TENMHTHI = new System.Windows.Forms.BindingSource(this.components);
            this.lbDESLANTHI = new System.Windows.Forms.Label();
            this.lbDESNGAYTHI = new System.Windows.Forms.Label();
            this.lbDESMONHOC = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTHOIGIAN = new System.Windows.Forms.Label();
            this.btnNOPBAI = new System.Windows.Forms.Button();
            this.lbSOCAUTHI = new System.Windows.Forms.Label();
            this.lbTRINHDO = new System.Windows.Forms.Label();
            this.lbDESTHOIGIAN = new System.Windows.Forms.Label();
            this.lbDESSOCAUTHI = new System.Windows.Forms.Label();
            this.lbDESTRINHDO = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gIAOVIEN_DANGKYTableAdapter = new ThiTracNghiem.DS_SERVER1TableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new ThiTracNghiem.DS_SERVER1TableAdapters.TableAdapterManager();
            this.v_TENMHTHITableAdapter = new ThiTracNghiem.DS_SERVER1TableAdapters.V_TENMHTHITableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsV_TENMHTHI)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCHONLAI);
            this.panel1.Controls.Add(this.btnBATDAUTHI);
            this.panel1.Controls.Add(this.cmbLANTHI);
            this.panel1.Controls.Add(this.cmbNGAYTHI);
            this.panel1.Controls.Add(this.cmbTENMONHOC);
            this.panel1.Controls.Add(this.lbDESLANTHI);
            this.panel1.Controls.Add(this.lbDESNGAYTHI);
            this.panel1.Controls.Add(this.lbDESMONHOC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 80);
            this.panel1.TabIndex = 0;
            // 
            // btnCHONLAI
            // 
            this.btnCHONLAI.Location = new System.Drawing.Point(989, 16);
            this.btnCHONLAI.Name = "btnCHONLAI";
            this.btnCHONLAI.Size = new System.Drawing.Size(179, 46);
            this.btnCHONLAI.TabIndex = 7;
            this.btnCHONLAI.Text = "CHỌN LẠI";
            this.btnCHONLAI.UseVisualStyleBackColor = true;
            this.btnCHONLAI.Click += new System.EventHandler(this.btnCHONLAI_Click);
            // 
            // btnBATDAUTHI
            // 
            this.btnBATDAUTHI.Location = new System.Drawing.Point(1175, 16);
            this.btnBATDAUTHI.Name = "btnBATDAUTHI";
            this.btnBATDAUTHI.Size = new System.Drawing.Size(179, 46);
            this.btnBATDAUTHI.TabIndex = 6;
            this.btnBATDAUTHI.Text = "BẮT ĐẦU THI";
            this.btnBATDAUTHI.UseVisualStyleBackColor = true;
            this.btnBATDAUTHI.Click += new System.EventHandler(this.btnBATDAUTHI_Click);
            // 
            // cmbLANTHI
            // 
            this.cmbLANTHI.DataSource = this.bdsGVDK;
            this.cmbLANTHI.DisplayMember = "LAN";
            this.cmbLANTHI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLANTHI.FormattingEnabled = true;
            this.cmbLANTHI.Location = new System.Drawing.Point(811, 27);
            this.cmbLANTHI.Name = "cmbLANTHI";
            this.cmbLANTHI.Size = new System.Drawing.Size(145, 25);
            this.cmbLANTHI.TabIndex = 5;
            this.cmbLANTHI.ValueMember = "LAN";
            this.cmbLANTHI.SelectedIndexChanged += new System.EventHandler(this.cmbLANTHI_SelectedIndexChanged);
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "GIAOVIEN_DANGKY";
            this.bdsGVDK.DataSource = this.dS_SERVER1;
            // 
            // dS_SERVER1
            // 
            this.dS_SERVER1.DataSetName = "DS_SERVER1";
            this.dS_SERVER1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbNGAYTHI
            // 
            this.cmbNGAYTHI.DataSource = this.bdsGVDK;
            this.cmbNGAYTHI.DisplayMember = "NGAYTHI";
            this.cmbNGAYTHI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNGAYTHI.FormattingEnabled = true;
            this.cmbNGAYTHI.Location = new System.Drawing.Point(547, 27);
            this.cmbNGAYTHI.Name = "cmbNGAYTHI";
            this.cmbNGAYTHI.Size = new System.Drawing.Size(157, 25);
            this.cmbNGAYTHI.TabIndex = 4;
            this.cmbNGAYTHI.ValueMember = "NGAYTHI";
            this.cmbNGAYTHI.SelectedIndexChanged += new System.EventHandler(this.cmbNGAYTHI_SelectedIndexChanged);
            // 
            // cmbTENMONHOC
            // 
            this.cmbTENMONHOC.DataSource = this.bdsV_TENMHTHI;
            this.cmbTENMONHOC.DisplayMember = "TENMH";
            this.cmbTENMONHOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTENMONHOC.FormattingEnabled = true;
            this.cmbTENMONHOC.Location = new System.Drawing.Point(115, 27);
            this.cmbTENMONHOC.Name = "cmbTENMONHOC";
            this.cmbTENMONHOC.Size = new System.Drawing.Size(307, 25);
            this.cmbTENMONHOC.TabIndex = 3;
            this.cmbTENMONHOC.ValueMember = "TENMH";
            this.cmbTENMONHOC.SelectedIndexChanged += new System.EventHandler(this.cmbTENMONHOC_SelectedIndexChanged);
            // 
            // bdsV_TENMHTHI
            // 
            this.bdsV_TENMHTHI.DataMember = "V_TENMHTHI";
            this.bdsV_TENMHTHI.DataSource = this.dS_SERVER1;
            // 
            // lbDESLANTHI
            // 
            this.lbDESLANTHI.AutoSize = true;
            this.lbDESLANTHI.Location = new System.Drawing.Point(719, 31);
            this.lbDESLANTHI.Name = "lbDESLANTHI";
            this.lbDESLANTHI.Size = new System.Drawing.Size(68, 17);
            this.lbDESLANTHI.TabIndex = 2;
            this.lbDESLANTHI.Text = "LẦN THI";
            // 
            // lbDESNGAYTHI
            // 
            this.lbDESNGAYTHI.AutoSize = true;
            this.lbDESNGAYTHI.Location = new System.Drawing.Point(441, 31);
            this.lbDESNGAYTHI.Name = "lbDESNGAYTHI";
            this.lbDESNGAYTHI.Size = new System.Drawing.Size(79, 17);
            this.lbDESNGAYTHI.TabIndex = 1;
            this.lbDESNGAYTHI.Text = "NGÀY THI";
            // 
            // lbDESMONHOC
            // 
            this.lbDESMONHOC.AutoSize = true;
            this.lbDESMONHOC.Location = new System.Drawing.Point(10, 31);
            this.lbDESMONHOC.Name = "lbDESMONHOC";
            this.lbDESMONHOC.Size = new System.Drawing.Size(79, 17);
            this.lbDESMONHOC.TabIndex = 0;
            this.lbDESMONHOC.Text = "MÔN HỌC";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbTHOIGIAN);
            this.panel2.Controls.Add(this.btnNOPBAI);
            this.panel2.Controls.Add(this.lbSOCAUTHI);
            this.panel2.Controls.Add(this.lbTRINHDO);
            this.panel2.Controls.Add(this.lbDESTHOIGIAN);
            this.panel2.Controls.Add(this.lbDESSOCAUTHI);
            this.panel2.Controls.Add(this.lbDESTRINHDO);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1069, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 376);
            this.panel2.TabIndex = 1;
            // 
            // lbTHOIGIAN
            // 
            this.lbTHOIGIAN.AutoSize = true;
            this.lbTHOIGIAN.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTHOIGIAN.Location = new System.Drawing.Point(68, 189);
            this.lbTHOIGIAN.Name = "lbTHOIGIAN";
            this.lbTHOIGIAN.Size = new System.Drawing.Size(163, 31);
            this.lbTHOIGIAN.TabIndex = 6;
            this.lbTHOIGIAN.Text = "lbTHOIGIAN";
            // 
            // btnNOPBAI
            // 
            this.btnNOPBAI.Location = new System.Drawing.Point(60, 316);
            this.btnNOPBAI.Name = "btnNOPBAI";
            this.btnNOPBAI.Size = new System.Drawing.Size(179, 46);
            this.btnNOPBAI.TabIndex = 5;
            this.btnNOPBAI.Text = "NỘP BÀI";
            this.btnNOPBAI.UseVisualStyleBackColor = true;
            // 
            // lbSOCAUTHI
            // 
            this.lbSOCAUTHI.AutoSize = true;
            this.lbSOCAUTHI.Location = new System.Drawing.Point(199, 74);
            this.lbSOCAUTHI.Name = "lbSOCAUTHI";
            this.lbSOCAUTHI.Size = new System.Drawing.Size(94, 17);
            this.lbSOCAUTHI.TabIndex = 4;
            this.lbSOCAUTHI.Text = "lbSOCAUTHI";
            // 
            // lbTRINHDO
            // 
            this.lbTRINHDO.AutoSize = true;
            this.lbTRINHDO.Location = new System.Drawing.Point(199, 29);
            this.lbTRINHDO.Name = "lbTRINHDO";
            this.lbTRINHDO.Size = new System.Drawing.Size(86, 17);
            this.lbTRINHDO.TabIndex = 3;
            this.lbTRINHDO.Text = "lbTRINHDO";
            // 
            // lbDESTHOIGIAN
            // 
            this.lbDESTHOIGIAN.AutoSize = true;
            this.lbDESTHOIGIAN.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDESTHOIGIAN.Location = new System.Drawing.Point(77, 128);
            this.lbDESTHOIGIAN.Name = "lbDESTHOIGIAN";
            this.lbDESTHOIGIAN.Size = new System.Drawing.Size(148, 31);
            this.lbDESTHOIGIAN.TabIndex = 2;
            this.lbDESTHOIGIAN.Text = "THỜI GIAN";
            // 
            // lbDESSOCAUTHI
            // 
            this.lbDESSOCAUTHI.AutoSize = true;
            this.lbDESSOCAUTHI.Location = new System.Drawing.Point(33, 74);
            this.lbDESSOCAUTHI.Name = "lbDESSOCAUTHI";
            this.lbDESSOCAUTHI.Size = new System.Drawing.Size(92, 17);
            this.lbDESSOCAUTHI.TabIndex = 1;
            this.lbDESSOCAUTHI.Text = "SỐ CÂU THI";
            // 
            // lbDESTRINHDO
            // 
            this.lbDESTRINHDO.AutoSize = true;
            this.lbDESTRINHDO.Location = new System.Drawing.Point(45, 29);
            this.lbDESTRINHDO.Name = "lbDESTRINHDO";
            this.lbDESTRINHDO.Size = new System.Drawing.Size(80, 17);
            this.lbDESTRINHDO.TabIndex = 0;
            this.lbDESTRINHDO.Text = "TRÌNH ĐỘ";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1069, 376);
            this.panel3.TabIndex = 2;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiem.DS_SERVER1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_TENMHTHITableAdapter
            // 
            this.v_TENMHTHITableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmThi
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 456);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmThi";
            this.Text = "FrmThi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmThi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsV_TENMHTHI)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBATDAUTHI;
        private System.Windows.Forms.ComboBox cmbLANTHI;
        private System.Windows.Forms.ComboBox cmbNGAYTHI;
        private System.Windows.Forms.ComboBox cmbTENMONHOC;
        private System.Windows.Forms.Label lbDESLANTHI;
        private System.Windows.Forms.Label lbDESNGAYTHI;
        private System.Windows.Forms.Label lbDESMONHOC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDESSOCAUTHI;
        private System.Windows.Forms.Label lbDESTRINHDO;
        private System.Windows.Forms.Label lbDESTHOIGIAN;
        private DS_SERVER1 dS_SERVER1;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DS_SERVER1TableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DS_SERVER1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsV_TENMHTHI;
        private DS_SERVER1TableAdapters.V_TENMHTHITableAdapter v_TENMHTHITableAdapter;
        public System.Windows.Forms.Label lbSOCAUTHI;
        public System.Windows.Forms.Label lbTRINHDO;
        private System.Windows.Forms.Button btnCHONLAI;
        private System.Windows.Forms.Button btnNOPBAI;
        private System.Windows.Forms.Label lbTHOIGIAN;
        private System.Windows.Forms.Timer timer1;
    }
}