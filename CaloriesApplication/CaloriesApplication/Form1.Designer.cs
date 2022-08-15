namespace CaloriesApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInptFat = new System.Windows.Forms.TextBox();
            this.txtInptCarbs = new System.Windows.Forms.TextBox();
            this.btnFat_Click = new System.Windows.Forms.Button();
            this.btnCarbs_Click = new System.Windows.Forms.Button();
            this.lblFatRslt = new System.Windows.Forms.Label();
            this.lblCarbsRslt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter fat in grams:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter carbohydrates in grams:";
            // 
            // txtInptFat
            // 
            this.txtInptFat.Location = new System.Drawing.Point(228, 58);
            this.txtInptFat.Name = "txtInptFat";
            this.txtInptFat.Size = new System.Drawing.Size(191, 22);
            this.txtInptFat.TabIndex = 2;
            // 
            // txtInptCarbs
            // 
            this.txtInptCarbs.Location = new System.Drawing.Point(228, 188);
            this.txtInptCarbs.Name = "txtInptCarbs";
            this.txtInptCarbs.Size = new System.Drawing.Size(191, 22);
            this.txtInptCarbs.TabIndex = 3;
            // 
            // btnFat_Click
            // 
            this.btnFat_Click.Location = new System.Drawing.Point(228, 101);
            this.btnFat_Click.Name = "btnFat_Click";
            this.btnFat_Click.Size = new System.Drawing.Size(191, 23);
            this.btnFat_Click.TabIndex = 4;
            this.btnFat_Click.Text = "Calculate calories from fat.";
            this.btnFat_Click.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFat_Click.UseVisualStyleBackColor = true;
            this.btnFat_Click.Click += new System.EventHandler(this.BtnCalcFat_Click);
            // 
            // btnCarbs_Click
            // 
            this.btnCarbs_Click.Location = new System.Drawing.Point(228, 231);
            this.btnCarbs_Click.Name = "btnCarbs_Click";
            this.btnCarbs_Click.Size = new System.Drawing.Size(191, 23);
            this.btnCarbs_Click.TabIndex = 5;
            this.btnCarbs_Click.Text = "Calculate calories from carbs.";
            this.btnCarbs_Click.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarbs_Click.UseVisualStyleBackColor = true;
            this.btnCarbs_Click.Click += new System.EventHandler(this.BtnCalcCarbs_Click);
            // 
            // lblFatRslt
            // 
            this.lblFatRslt.AutoSize = true;
            this.lblFatRslt.Location = new System.Drawing.Point(437, 64);
            this.lblFatRslt.Name = "lblFatRslt";
            this.lblFatRslt.Size = new System.Drawing.Size(0, 16);
            this.lblFatRslt.TabIndex = 6;
            // 
            // lblCarbsRslt
            // 
            this.lblCarbsRslt.AutoSize = true;
            this.lblCarbsRslt.Location = new System.Drawing.Point(437, 194);
            this.lblCarbsRslt.Name = "lblCarbsRslt";
            this.lblCarbsRslt.Size = new System.Drawing.Size(0, 16);
            this.lblCarbsRslt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 316);
            this.Controls.Add(this.lblCarbsRslt);
            this.Controls.Add(this.lblFatRslt);
            this.Controls.Add(this.btnCarbs_Click);
            this.Controls.Add(this.btnFat_Click);
            this.Controls.Add(this.txtInptCarbs);
            this.Controls.Add(this.txtInptFat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calories Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInptFat;
        private System.Windows.Forms.TextBox txtInptCarbs;
        private System.Windows.Forms.Button btnFat_Click;
        private System.Windows.Forms.Button btnCarbs_Click;
        private System.Windows.Forms.Label lblFatRslt;
        private System.Windows.Forms.Label lblCarbsRslt;
    }
}

