namespace LoanFromHuang
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBorrow = new System.Windows.Forms.Button();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.btnLoan = new System.Windows.Forms.Button();
            this.lblLoan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(39, 100);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(213, 64);
            this.btnBorrow.TabIndex = 0;
            this.btnBorrow.Text = "续一秒";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // lblBorrow
            // 
            this.lblBorrow.AutoSize = true;
            this.lblBorrow.Location = new System.Drawing.Point(368, 122);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Size = new System.Drawing.Size(53, 12);
            this.lblBorrow.TabIndex = 1;
            this.lblBorrow.Text = "续命次数";
            // 
            // btnLoan
            // 
            this.btnLoan.Enabled = false;
            this.btnLoan.Location = new System.Drawing.Point(39, 232);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(213, 64);
            this.btnLoan.TabIndex = 2;
            this.btnLoan.Text = "总时间";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click_1);
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Location = new System.Drawing.Point(368, 258);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(53, 12);
            this.lblLoan.TabIndex = 3;
            this.lblLoan.Text = "时间总数";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "续十秒";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLoan);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.lblBorrow);
            this.Controls.Add(this.btnBorrow);
            this.Name = "FrmMain";
            this.Text = "长者续命";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Button button1;
    }
}

