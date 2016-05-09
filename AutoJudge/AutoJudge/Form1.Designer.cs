namespace AutoJudge
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.rBtnPlusMinus = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.rBtnTimes = new System.Windows.Forms.RadioButton();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rBtnPlusMinus
            // 
            this.rBtnPlusMinus.AutoEllipsis = true;
            this.rBtnPlusMinus.AutoSize = true;
            this.rBtnPlusMinus.Location = new System.Drawing.Point(12, 39);
            this.rBtnPlusMinus.Name = "rBtnPlusMinus";
            this.rBtnPlusMinus.Size = new System.Drawing.Size(59, 16);
            this.rBtnPlusMinus.TabIndex = 0;
            this.rBtnPlusMinus.TabStop = true;
            this.rBtnPlusMinus.Text = "加减法";
            this.rBtnPlusMinus.UseVisualStyleBackColor = true;
            this.rBtnPlusMinus.CheckedChanged += new System.EventHandler(this.rBtnPlusMinus_CheckedChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 24);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 12);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "题目类型";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShow.Location = new System.Drawing.Point(12, 119);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(210, 41);
            this.lblShow.TabIndex = 2;
            this.lblShow.Text = "此处显示题目";
            // 
            // rBtnTimes
            // 
            this.rBtnTimes.AutoSize = true;
            this.rBtnTimes.Location = new System.Drawing.Point(77, 39);
            this.rBtnTimes.Name = "rBtnTimes";
            this.rBtnTimes.Size = new System.Drawing.Size(47, 16);
            this.rBtnTimes.TabIndex = 3;
            this.rBtnTimes.TabStop = true;
            this.rBtnTimes.Text = "乘法";
            this.rBtnTimes.UseVisualStyleBackColor = true;
            this.rBtnTimes.CheckedChanged += new System.EventHandler(this.rBtnTimes_CheckedChanged);
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(224, 39);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(72, 16);
            this.chkAuto.TabIndex = 4;
            this.chkAuto.Text = "自动出题";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResult.Location = new System.Drawing.Point(224, 116);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 50);
            this.txtResult.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(224, 61);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 32);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(340, 32);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(67, 31);
            this.btnFast.TabIndex = 7;
            this.btnFast.Text = "加快";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.Location = new System.Drawing.Point(413, 32);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(67, 31);
            this.btnSlow.TabIndex = 8;
            this.btnSlow.Text = "减慢";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 5000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 187);
            this.Controls.Add(this.btnSlow);
            this.Controls.Add(this.btnFast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.rBtnTimes);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.rBtnPlusMinus);
            this.Name = "frmMain";
            this.Text = "自动出题";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtnPlusMinus;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.RadioButton rBtnTimes;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Timer tmr;
    }
}

