namespace DataCompare
{
    partial class ProgressBarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSrcPercentage = new System.Windows.Forms.Label();
            this.lblTrgPercentage = new System.Windows.Forms.Label();
            this.lblSrcCount = new System.Windows.Forms.Label();
            this.lblTrgCount = new System.Windows.Forms.Label();
            this.pbSrcProcessed = new System.Windows.Forms.ProgressBar();
            this.pbTrgProcessed = new System.Windows.Forms.ProgressBar();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Table:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target Table:";
            // 
            // lblSrcPercentage
            // 
            this.lblSrcPercentage.AutoSize = true;
            this.lblSrcPercentage.Location = new System.Drawing.Point(248, 9);
            this.lblSrcPercentage.Name = "lblSrcPercentage";
            this.lblSrcPercentage.Size = new System.Drawing.Size(21, 13);
            this.lblSrcPercentage.TabIndex = 2;
            this.lblSrcPercentage.Text = "0%";
            // 
            // lblTrgPercentage
            // 
            this.lblTrgPercentage.AutoSize = true;
            this.lblTrgPercentage.Location = new System.Drawing.Point(248, 51);
            this.lblTrgPercentage.Name = "lblTrgPercentage";
            this.lblTrgPercentage.Size = new System.Drawing.Size(21, 13);
            this.lblTrgPercentage.TabIndex = 3;
            this.lblTrgPercentage.Text = "0%";
            // 
            // lblSrcCount
            // 
            this.lblSrcCount.AutoSize = true;
            this.lblSrcCount.Location = new System.Drawing.Point(373, 9);
            this.lblSrcCount.Name = "lblSrcCount";
            this.lblSrcCount.Size = new System.Drawing.Size(54, 13);
            this.lblSrcCount.TabIndex = 4;
            this.lblSrcCount.Text = "0/100000";
            // 
            // lblTrgCount
            // 
            this.lblTrgCount.AutoSize = true;
            this.lblTrgCount.Location = new System.Drawing.Point(373, 51);
            this.lblTrgCount.Name = "lblTrgCount";
            this.lblTrgCount.Size = new System.Drawing.Size(54, 13);
            this.lblTrgCount.TabIndex = 5;
            this.lblTrgCount.Text = "0/100000";
            // 
            // pbSrcProcessed
            // 
            this.pbSrcProcessed.Location = new System.Drawing.Point(88, 25);
            this.pbSrcProcessed.Name = "pbSrcProcessed";
            this.pbSrcProcessed.Size = new System.Drawing.Size(366, 21);
            this.pbSrcProcessed.TabIndex = 6;
            // 
            // pbTrgProcessed
            // 
            this.pbTrgProcessed.Location = new System.Drawing.Point(88, 67);
            this.pbTrgProcessed.Name = "pbTrgProcessed";
            this.pbTrgProcessed.Size = new System.Drawing.Size(366, 21);
            this.pbTrgProcessed.TabIndex = 7;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(353, 106);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(101, 23);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Cancel";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // ProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 141);
            this.ControlBox = false;
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.pbTrgProcessed);
            this.Controls.Add(this.pbSrcProcessed);
            this.Controls.Add(this.lblTrgCount);
            this.Controls.Add(this.lblSrcCount);
            this.Controls.Add(this.lblTrgPercentage);
            this.Controls.Add(this.lblSrcPercentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "ProgressBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgressBarForm_FormClosed);
            this.Load += new System.EventHandler(this.ProgressBarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSrcPercentage;
        private System.Windows.Forms.Label lblTrgPercentage;
        private System.Windows.Forms.Label lblSrcCount;
        private System.Windows.Forms.Label lblTrgCount;
        private System.Windows.Forms.ProgressBar pbSrcProcessed;
        private System.Windows.Forms.ProgressBar pbTrgProcessed;
        private System.Windows.Forms.Button btnFinish;
    }
}