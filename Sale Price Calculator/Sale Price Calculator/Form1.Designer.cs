namespace Sale_Price_Calculator
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
            this.OriginalPricePromptLabel = new System.Windows.Forms.Label();
            this.OriginalPriceTextBox = new System.Windows.Forms.TextBox();
            this.discountPercentagePromptLabel = new System.Windows.Forms.Label();
            this.discountPercentageTextbox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.SalePriceLabel = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OriginalPricePromptLabel
            // 
            this.OriginalPricePromptLabel.AutoSize = true;
            this.OriginalPricePromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalPricePromptLabel.Location = new System.Drawing.Point(54, 35);
            this.OriginalPricePromptLabel.Name = "OriginalPricePromptLabel";
            this.OriginalPricePromptLabel.Size = new System.Drawing.Size(261, 25);
            this.OriginalPricePromptLabel.TabIndex = 0;
            this.OriginalPricePromptLabel.Text = "Enter the items original price:";
            this.OriginalPricePromptLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // OriginalPriceTextBox
            // 
            this.OriginalPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalPriceTextBox.Location = new System.Drawing.Point(401, 35);
            this.OriginalPriceTextBox.Name = "OriginalPriceTextBox";
            this.OriginalPriceTextBox.Size = new System.Drawing.Size(240, 30);
            this.OriginalPriceTextBox.TabIndex = 1;
            // 
            // discountPercentagePromptLabel
            // 
            this.discountPercentagePromptLabel.AutoSize = true;
            this.discountPercentagePromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountPercentagePromptLabel.Location = new System.Drawing.Point(38, 96);
            this.discountPercentagePromptLabel.Name = "discountPercentagePromptLabel";
            this.discountPercentagePromptLabel.Size = new System.Drawing.Size(277, 25);
            this.discountPercentagePromptLabel.TabIndex = 2;
            this.discountPercentagePromptLabel.Text = "Enter the discount percentage:";
            // 
            // discountPercentageTextbox
            // 
            this.discountPercentageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountPercentageTextbox.Location = new System.Drawing.Point(401, 91);
            this.discountPercentageTextbox.Name = "discountPercentageTextbox";
            this.discountPercentageTextbox.Size = new System.Drawing.Size(224, 30);
            this.discountPercentageTextbox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(208, 149);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(107, 25);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "Sale Price:";
            // 
            // SalePriceLabel
            // 
            this.SalePriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.SalePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalePriceLabel.Location = new System.Drawing.Point(401, 146);
            this.SalePriceLabel.Name = "SalePriceLabel";
            this.SalePriceLabel.Size = new System.Drawing.Size(100, 30);
            this.SalePriceLabel.TabIndex = 5;
            this.SalePriceLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(172, 231);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(143, 79);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Sale Price";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(401, 231);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 79);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.SalePriceLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.discountPercentageTextbox);
            this.Controls.Add(this.discountPercentagePromptLabel);
            this.Controls.Add(this.OriginalPriceTextBox);
            this.Controls.Add(this.OriginalPricePromptLabel);
            this.Name = "Form1";
            this.Text = "Sale Price Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OriginalPricePromptLabel;
        private System.Windows.Forms.TextBox OriginalPriceTextBox;
        private System.Windows.Forms.Label discountPercentagePromptLabel;
        private System.Windows.Forms.TextBox discountPercentageTextbox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox SalePriceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

