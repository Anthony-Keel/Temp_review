namespace Temp_review
{
    partial class mainForm
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
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.btnReportResults = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblLowTemp = new System.Windows.Forms.Label();
            this.lblHighTemp = new System.Windows.Forms.Label();
            this.lblAvergeTemp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Location = new System.Drawing.Point(13, 37);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnFileSelect.TabIndex = 0;
            this.btnFileSelect.Text = "Select a File ";
            this.btnFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnReportResults
            // 
            this.btnReportResults.Location = new System.Drawing.Point(13, 67);
            this.btnReportResults.Name = "btnReportResults";
            this.btnReportResults.Size = new System.Drawing.Size(75, 23);
            this.btnReportResults.TabIndex = 1;
            this.btnReportResults.Text = "Report Results";
            this.btnReportResults.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAvergeTemp);
            this.groupBox1.Controls.Add(this.lblHighTemp);
            this.groupBox1.Controls.Add(this.lblLowTemp);
            this.groupBox1.Location = new System.Drawing.Point(45, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Month Statisics";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(95, 46);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(167, 13);
            this.lblFilePath.TabIndex = 3;
            this.lblFilePath.Text = "<Display path and file name here>";
            // 
            // lblLowTemp
            // 
            this.lblLowTemp.AutoSize = true;
            this.lblLowTemp.Location = new System.Drawing.Point(7, 20);
            this.lblLowTemp.Name = "lblLowTemp";
            this.lblLowTemp.Size = new System.Drawing.Size(72, 13);
            this.lblLowTemp.TabIndex = 0;
            this.lblLowTemp.Text = "low temp day ";
            // 
            // lblHighTemp
            // 
            this.lblHighTemp.AutoSize = true;
            this.lblHighTemp.Location = new System.Drawing.Point(7, 37);
            this.lblHighTemp.Name = "lblHighTemp";
            this.lblHighTemp.Size = new System.Drawing.Size(80, 13);
            this.lblHighTemp.TabIndex = 1;
            this.lblHighTemp.Text = "High temp Day ";
            // 
            // lblAvergeTemp
            // 
            this.lblAvergeTemp.AutoSize = true;
            this.lblAvergeTemp.Location = new System.Drawing.Point(10, 54);
            this.lblAvergeTemp.Name = "lblAvergeTemp";
            this.lblAvergeTemp.Size = new System.Drawing.Size(73, 13);
            this.lblAvergeTemp.TabIndex = 2;
            this.lblAvergeTemp.Text = "Avarage temp";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReportResults);
            this.Controls.Add(this.btnFileSelect);
            this.Name = "mainForm";
            this.Text = "Temperature Review";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.Button btnReportResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAvergeTemp;
        private System.Windows.Forms.Label lblHighTemp;
        private System.Windows.Forms.Label lblLowTemp;
        private System.Windows.Forms.Label lblFilePath;
    }
}

