namespace ThiTracNghiem.Forms
{
    partial class FrmResult
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTimes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Môn Thi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày thi:";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(101, 12);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(40, 13);
            this.lbClass.TabIndex = 5;
            this.lbClass.Text = "lbClass";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(101, 48);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(42, 13);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "lbName";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(101, 81);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(51, 13);
            this.lbSubject.TabIndex = 7;
            this.lbSubject.Text = "lbSubject";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(101, 112);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(38, 13);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "lbDate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Lần thi:";
            // 
            // lbTimes
            // 
            this.lbTimes.AutoSize = true;
            this.lbTimes.Location = new System.Drawing.Point(403, 112);
            this.lbTimes.Name = "lbTimes";
            this.lbTimes.Size = new System.Drawing.Size(42, 13);
            this.lbTimes.TabIndex = 10;
            this.lbTimes.Text = "lbTimes";
            // 
            // FrmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 468);
            this.Controls.Add(this.lbTimes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmResult";
            this.Text = "FrmResult";
            this.Load += new System.EventHandler(this.FrmResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTimes;
    }
}