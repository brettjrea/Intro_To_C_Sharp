namespace TimeCalculator
{
    partial class TimeCalculator
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
            this.txtSec = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblRslt = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(13, 30);
            this.lblSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(132, 16);
            this.lblSec.TabIndex = 0;
            this.lblSec.Text = "How many seconds?";
            // 
            // lblRslt
            // 
            this.lblRslt.AutoSize = true;
            this.lblRslt.Location = new System.Drawing.Point(13, 129);
            this.lblRslt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRslt.Name = "lblRslt";
            this.lblRslt.Size = new System.Drawing.Size(147, 16);
            this.lblRslt.TabIndex = 1;
            this.lblRslt.Text = "That many seconds is...";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(210, 155);
            this.lblDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(42, 16);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "Days.";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(210, 187);
            this.lblHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(46, 16);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "Hours.";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(210, 219);
            this.lblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(56, 16);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Minutes.";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(156, 80);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(45, 80);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(45, 243);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(46, 50);
            this.txtSec.Margin = new System.Windows.Forms.Padding(4);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(156, 22);
            this.txtSec.TabIndex = 9;
            this.txtSec.TextChanged += new System.EventHandler(this.TxtSec_TextChanged);
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(46, 149);
            this.txtDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDay.Name = "txtDay";
            this.txtDay.ReadOnly = true;
            this.txtDay.Size = new System.Drawing.Size(156, 22);
            this.txtDay.TabIndex = 10;
            this.txtDay.TextChanged += new System.EventHandler(this.TxtDay_TextChanged);
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(46, 181);
            this.txtHour.Margin = new System.Windows.Forms.Padding(4);
            this.txtHour.Name = "txtHour";
            this.txtHour.ReadOnly = true;
            this.txtHour.Size = new System.Drawing.Size(156, 22);
            this.txtHour.TabIndex = 11;
            this.txtHour.TextChanged += new System.EventHandler(this.TxtHour_TextChanged);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(46, 213);
            this.txtMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(156, 22);
            this.txtMin.TabIndex = 12;
            this.txtMin.TextChanged += new System.EventHandler(this.TxtMin_TextChanged);
            // 
            // TimeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 289);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblRslt);
     
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimeCalculator";
            this.Text = "TimeCalculator";
            this.Load += new System.EventHandler(this.TimeCalculator_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblRslt;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMin;
    }
}