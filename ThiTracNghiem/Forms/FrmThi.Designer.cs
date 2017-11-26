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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTENMONHOC = new System.Windows.Forms.ComboBox();
            this.cmbNGAYTHI = new System.Windows.Forms.ComboBox();
            this.cmbLANTHI = new System.Windows.Forms.ComboBox();
            this.btnBATDAUTHI = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBATDAUTHI);
            this.panel1.Controls.Add(this.cmbLANTHI);
            this.panel1.Controls.Add(this.cmbNGAYTHI);
            this.panel1.Controls.Add(this.cmbTENMONHOC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 80);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1089, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 339);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 339);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÔN HỌC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NGÀY THI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(837, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "LẦN THI";
            // 
            // cmbTENMONHOC
            // 
            this.cmbTENMONHOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTENMONHOC.FormattingEnabled = true;
            this.cmbTENMONHOC.Location = new System.Drawing.Point(141, 27);
            this.cmbTENMONHOC.Name = "cmbTENMONHOC";
            this.cmbTENMONHOC.Size = new System.Drawing.Size(307, 25);
            this.cmbTENMONHOC.TabIndex = 3;
            // 
            // cmbNGAYTHI
            // 
            this.cmbNGAYTHI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNGAYTHI.FormattingEnabled = true;
            this.cmbNGAYTHI.Location = new System.Drawing.Point(629, 27);
            this.cmbNGAYTHI.Name = "cmbNGAYTHI";
            this.cmbNGAYTHI.Size = new System.Drawing.Size(157, 25);
            this.cmbNGAYTHI.TabIndex = 4;
            // 
            // cmbLANTHI
            // 
            this.cmbLANTHI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLANTHI.FormattingEnabled = true;
            this.cmbLANTHI.Location = new System.Drawing.Point(956, 27);
            this.cmbLANTHI.Name = "cmbLANTHI";
            this.cmbLANTHI.Size = new System.Drawing.Size(145, 25);
            this.cmbLANTHI.TabIndex = 5;
            // 
            // btnBATDAUTHI
            // 
            this.btnBATDAUTHI.Location = new System.Drawing.Point(1152, 16);
            this.btnBATDAUTHI.Name = "btnBATDAUTHI";
            this.btnBATDAUTHI.Size = new System.Drawing.Size(182, 46);
            this.btnBATDAUTHI.TabIndex = 6;
            this.btnBATDAUTHI.Text = "BẮT ĐẦU THI";
            this.btnBATDAUTHI.UseVisualStyleBackColor = true;
            this.btnBATDAUTHI.Click += new System.EventHandler(this.btnBATDAUTHI_Click);
            // 
            // FrmThi
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 419);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmThi";
            this.Text = "FrmThi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBATDAUTHI;
        private System.Windows.Forms.ComboBox cmbLANTHI;
        private System.Windows.Forms.ComboBox cmbNGAYTHI;
        private System.Windows.Forms.ComboBox cmbTENMONHOC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}