namespace FileInput
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
            this.openFileDialogLbl = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lowerCaseTxtBox = new System.Windows.Forms.TextBox();
            this.lowerCaseLbl = new System.Windows.Forms.Label();
            this.firstWrdLbl = new System.Windows.Forms.Label();
            this.lastWrdLbl = new System.Windows.Forms.Label();
            this.firstWordTxtBox = new System.Windows.Forms.TextBox();
            this.lastWordTxtBox = new System.Windows.Forms.TextBox();
            this.longestWordTxtBox = new System.Windows.Forms.TextBox();
            this.longestWrdLbl = new System.Windows.Forms.Label();
            this.mostVowels = new System.Windows.Forms.TextBox();
            this.mostVwlsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialogLbl
            // 
            this.openFileDialogLbl.AutoSize = true;
            this.openFileDialogLbl.Location = new System.Drawing.Point(33, 31);
            this.openFileDialogLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.openFileDialogLbl.Name = "openFileDialogLbl";
            this.openFileDialogLbl.Size = new System.Drawing.Size(76, 16);
            this.openFileDialogLbl.TabIndex = 0;
            this.openFileDialogLbl.Text = "Select File :";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(36, 54);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(198, 28);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select Here";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lowerCaseTxtBox
            // 
            this.lowerCaseTxtBox.Location = new System.Drawing.Point(36, 116);
            this.lowerCaseTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.lowerCaseTxtBox.Multiline = true;
            this.lowerCaseTxtBox.Name = "lowerCaseTxtBox";
            this.lowerCaseTxtBox.Size = new System.Drawing.Size(388, 156);
            this.lowerCaseTxtBox.TabIndex = 2;
            // 
            // lowerCaseLbl
            // 
            this.lowerCaseLbl.AutoSize = true;
            this.lowerCaseLbl.Location = new System.Drawing.Point(33, 96);
            this.lowerCaseLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowerCaseLbl.Name = "lowerCaseLbl";
            this.lowerCaseLbl.Size = new System.Drawing.Size(84, 16);
            this.lowerCaseLbl.TabIndex = 3;
            this.lowerCaseLbl.Text = "Lower Case :";
            // 
            // firstWrdLbl
            // 
            this.firstWrdLbl.AutoSize = true;
            this.firstWrdLbl.Location = new System.Drawing.Point(442, 116);
            this.firstWrdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstWrdLbl.Name = "firstWrdLbl";
            this.firstWrdLbl.Size = new System.Drawing.Size(71, 16);
            this.firstWrdLbl.TabIndex = 4;
            this.firstWrdLbl.Text = "First Word:";
            // 
            // lastWrdLbl
            // 
            this.lastWrdLbl.AutoSize = true;
            this.lastWrdLbl.Location = new System.Drawing.Point(442, 156);
            this.lastWrdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastWrdLbl.Name = "lastWrdLbl";
            this.lastWrdLbl.Size = new System.Drawing.Size(71, 16);
            this.lastWrdLbl.TabIndex = 5;
            this.lastWrdLbl.Text = "Last Word:";
            // 
            // firstWordTxtBox
            // 
            this.firstWordTxtBox.Location = new System.Drawing.Point(553, 116);
            this.firstWordTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstWordTxtBox.Name = "firstWordTxtBox";
            this.firstWordTxtBox.Size = new System.Drawing.Size(257, 22);
            this.firstWordTxtBox.TabIndex = 6;
            // 
            // lastWordTxtBox
            // 
            this.lastWordTxtBox.Location = new System.Drawing.Point(553, 156);
            this.lastWordTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastWordTxtBox.Name = "lastWordTxtBox";
            this.lastWordTxtBox.Size = new System.Drawing.Size(257, 22);
            this.lastWordTxtBox.TabIndex = 7;
            // 
            // longestWordTxtBox
            // 
            this.longestWordTxtBox.Location = new System.Drawing.Point(553, 203);
            this.longestWordTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.longestWordTxtBox.Name = "longestWordTxtBox";
            this.longestWordTxtBox.Size = new System.Drawing.Size(257, 22);
            this.longestWordTxtBox.TabIndex = 9;
            // 
            // longestWrdLbl
            // 
            this.longestWrdLbl.AutoSize = true;
            this.longestWrdLbl.Location = new System.Drawing.Point(442, 203);
            this.longestWrdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.longestWrdLbl.Name = "longestWrdLbl";
            this.longestWrdLbl.Size = new System.Drawing.Size(94, 16);
            this.longestWrdLbl.TabIndex = 8;
            this.longestWrdLbl.Text = "Longest Word:";
            this.longestWrdLbl.Click += new System.EventHandler(this.longestWrd_Click);
            // 
            // mostVowels
            // 
            this.mostVowels.Location = new System.Drawing.Point(553, 250);
            this.mostVowels.Margin = new System.Windows.Forms.Padding(4);
            this.mostVowels.Name = "mostVowels";
            this.mostVowels.Size = new System.Drawing.Size(257, 22);
            this.mostVowels.TabIndex = 11;
            // 
            // mostVwlsLbl
            // 
            this.mostVwlsLbl.AutoSize = true;
            this.mostVwlsLbl.Location = new System.Drawing.Point(442, 250);
            this.mostVwlsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mostVwlsLbl.Name = "mostVwlsLbl";
            this.mostVwlsLbl.Size = new System.Drawing.Size(86, 16);
            this.mostVwlsLbl.TabIndex = 10;
            this.mostVwlsLbl.Text = "Most Vowels:";
            this.mostVwlsLbl.Click += new System.EventHandler(this.mostVwls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 296);
            this.Controls.Add(this.mostVowels);
            this.Controls.Add(this.mostVwlsLbl);
            this.Controls.Add(this.longestWordTxtBox);
            this.Controls.Add(this.longestWrdLbl);
            this.Controls.Add(this.lastWordTxtBox);
            this.Controls.Add(this.firstWordTxtBox);
            this.Controls.Add(this.lastWrdLbl);
            this.Controls.Add(this.firstWrdLbl);
            this.Controls.Add(this.lowerCaseLbl);
            this.Controls.Add(this.lowerCaseTxtBox);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.openFileDialogLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label openFileDialogLbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox lowerCaseTxtBox;
        private System.Windows.Forms.Label lowerCaseLbl;
        private System.Windows.Forms.Label firstWrdLbl;
        private System.Windows.Forms.Label lastWrdLbl;
        private System.Windows.Forms.TextBox firstWordTxtBox;
        private System.Windows.Forms.TextBox lastWordTxtBox;
        private System.Windows.Forms.TextBox longestWordTxtBox;
        private System.Windows.Forms.Label longestWrdLbl;
        private System.Windows.Forms.TextBox mostVowels;
        private System.Windows.Forms.Label mostVwlsLbl;
    }
}