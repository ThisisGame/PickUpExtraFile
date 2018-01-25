namespace PickUpExtraFile
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
            this.mButtonStandard = new System.Windows.Forms.Button();
            this.mButtonCurrent = new System.Windows.Forms.Button();
            this.mLabelStandard = new System.Windows.Forms.Label();
            this.mLabelCurrent = new System.Windows.Forms.Label();
            this.mButtonCompare = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mButtonStandard
            // 
            this.mButtonStandard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mButtonStandard.Location = new System.Drawing.Point(12, 44);
            this.mButtonStandard.Name = "mButtonStandard";
            this.mButtonStandard.Size = new System.Drawing.Size(119, 23);
            this.mButtonStandard.TabIndex = 0;
            this.mButtonStandard.Text = "选择标准文件夹";
            this.mButtonStandard.UseVisualStyleBackColor = true;
            this.mButtonStandard.Click += new System.EventHandler(this.mButtonStandard_Click);
            // 
            // mButtonCurrent
            // 
            this.mButtonCurrent.Location = new System.Drawing.Point(13, 125);
            this.mButtonCurrent.Name = "mButtonCurrent";
            this.mButtonCurrent.Size = new System.Drawing.Size(118, 23);
            this.mButtonCurrent.TabIndex = 1;
            this.mButtonCurrent.Text = "选择当前文件夹";
            this.mButtonCurrent.UseVisualStyleBackColor = true;
            this.mButtonCurrent.Click += new System.EventHandler(this.mButtonCurrent_Click);
            // 
            // mLabelStandard
            // 
            this.mLabelStandard.AutoSize = true;
            this.mLabelStandard.Location = new System.Drawing.Point(13, 74);
            this.mLabelStandard.Name = "mLabelStandard";
            this.mLabelStandard.Size = new System.Drawing.Size(89, 12);
            this.mLabelStandard.TabIndex = 2;
            this.mLabelStandard.Text = "标准文件夹路径";
            // 
            // mLabelCurrent
            // 
            this.mLabelCurrent.AutoSize = true;
            this.mLabelCurrent.Location = new System.Drawing.Point(15, 155);
            this.mLabelCurrent.Name = "mLabelCurrent";
            this.mLabelCurrent.Size = new System.Drawing.Size(89, 12);
            this.mLabelCurrent.TabIndex = 3;
            this.mLabelCurrent.Text = "当前文件夹路径";
            // 
            // mButtonCompare
            // 
            this.mButtonCompare.Location = new System.Drawing.Point(133, 259);
            this.mButtonCompare.Name = "mButtonCompare";
            this.mButtonCompare.Size = new System.Drawing.Size(75, 23);
            this.mButtonCompare.TabIndex = 4;
            this.mButtonCompare.Text = "对比";
            this.mButtonCompare.UseVisualStyleBackColor = true;
            this.mButtonCompare.Click += new System.EventHandler(this.mButtonCompare_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 229);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 333);
            this.Controls.Add(this.mButtonCompare);
            this.Controls.Add(this.mLabelCurrent);
            this.Controls.Add(this.mLabelStandard);
            this.Controls.Add(this.mButtonCurrent);
            this.Controls.Add(this.mButtonStandard);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "对比文件夹 挑出多余文件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mButtonStandard;
        private System.Windows.Forms.Button mButtonCurrent;
        private System.Windows.Forms.Label mLabelStandard;
        private System.Windows.Forms.Label mLabelCurrent;
        private System.Windows.Forms.Button mButtonCompare;
        private System.Windows.Forms.Panel panel1;
    }
}

