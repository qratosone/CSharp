namespace AutoScore
{
    partial class Form1
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
            this.label_a = new System.Windows.Forms.Label();
            this.label_op = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.ListBox();
            this.InputResult = new System.Windows.Forms.TextBox();
            this.BTN_New = new System.Windows.Forms.Button();
            this.BTN_Judge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(114, 41);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(11, 12);
            this.label_a.TabIndex = 0;
            this.label_a.Text = "a";
            // 
            // label_op
            // 
            this.label_op.AutoSize = true;
            this.label_op.Location = new System.Drawing.Point(131, 41);
            this.label_op.Name = "label_op";
            this.label_op.Size = new System.Drawing.Size(17, 12);
            this.label_op.TabIndex = 1;
            this.label_op.Text = "op";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(154, 41);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(11, 12);
            this.label_b.TabIndex = 2;
            this.label_b.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.ItemHeight = 12;
            this.Result.Location = new System.Drawing.Point(83, 124);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(260, 184);
            this.Result.TabIndex = 4;
            // 
            // InputResult
            // 
            this.InputResult.Location = new System.Drawing.Point(188, 38);
            this.InputResult.Name = "InputResult";
            this.InputResult.Size = new System.Drawing.Size(100, 21);
            this.InputResult.TabIndex = 5;
            // 
            // BTN_New
            // 
            this.BTN_New.Location = new System.Drawing.Point(107, 95);
            this.BTN_New.Name = "BTN_New";
            this.BTN_New.Size = new System.Drawing.Size(75, 23);
            this.BTN_New.TabIndex = 6;
            this.BTN_New.Text = "出题";
            this.BTN_New.UseVisualStyleBackColor = true;
            this.BTN_New.Click += new System.EventHandler(this.BTN_New_Click);
            // 
            // BTN_Judge
            // 
            this.BTN_Judge.Location = new System.Drawing.Point(231, 95);
            this.BTN_Judge.Name = "BTN_Judge";
            this.BTN_Judge.Size = new System.Drawing.Size(75, 23);
            this.BTN_Judge.TabIndex = 7;
            this.BTN_Judge.Text = "判断";
            this.BTN_Judge.UseVisualStyleBackColor = true;
            this.BTN_Judge.Click += new System.EventHandler(this.BTN_Judge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 417);
            this.Controls.Add(this.BTN_Judge);
            this.Controls.Add(this.BTN_New);
            this.Controls.Add(this.InputResult);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_op);
            this.Controls.Add(this.label_a);
            this.Name = "Form1";
            this.Text = "自动做题";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_op;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.TextBox InputResult;
        private System.Windows.Forms.Button BTN_New;
        private System.Windows.Forms.Button BTN_Judge;
    }
}

