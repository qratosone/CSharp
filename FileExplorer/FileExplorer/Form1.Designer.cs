namespace FileExplorer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.TreeV = new System.Windows.Forms.TreeView();
            this.listV = new System.Windows.Forms.ListView();
            this.String = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TreeV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listV);
            this.splitContainer1.Size = new System.Drawing.Size(690, 466);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 0;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "van.jpg");
            this.imgList.Images.SetKeyName(1, "郭德纲2.gif");
            // 
            // TreeV
            // 
            this.TreeV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeV.Location = new System.Drawing.Point(0, 0);
            this.TreeV.Name = "TreeV";
            this.TreeV.Size = new System.Drawing.Size(230, 466);
            this.TreeV.TabIndex = 0;
            // 
            // listV
            // 
            this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.String,
            this.Type,
            this.LastChange});
            this.listV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listV.Location = new System.Drawing.Point(0, 0);
            this.listV.Name = "listV";
            this.listV.Size = new System.Drawing.Size(456, 466);
            this.listV.TabIndex = 0;
            this.listV.UseCompatibleStateImageBehavior = false;
            this.listV.View = System.Windows.Forms.View.Details;
            this.listV.SelectedIndexChanged += new System.EventHandler(this.listV_SelectedIndexChanged);
            // 
            // String
            // 
            this.String.Text = "Name";
            this.String.Width = 119;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 164;
            // 
            // LastChange
            // 
            this.LastChange.Text = "LastChange";
            this.LastChange.Width = 267;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 466);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TreeV;
        private System.Windows.Forms.ListView listV;
        private System.Windows.Forms.ColumnHeader String;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader LastChange;
        private System.Windows.Forms.ImageList imgList;
    }
}