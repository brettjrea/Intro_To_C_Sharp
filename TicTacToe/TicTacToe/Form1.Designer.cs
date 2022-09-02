namespace TicTacToe
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
            this.button1 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.winLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.newGame_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(240, 340);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(180, 51);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // winLbl
            // 
            this.winLbl.AutoSize = true;
            this.winLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.winLbl.Location = new System.Drawing.Point(131, 297);
            this.winLbl.Name = "winLbl";
            this.winLbl.Size = new System.Drawing.Size(0, 25);
            this.winLbl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.winLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label winLbl;
    }
}

