namespace RobotManager
{
    partial class RobotManagerForm
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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRobotID = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblArms = new System.Windows.Forms.Label();
            this.lblMobility = new System.Windows.Forms.Label();
            this.lblLegs = new System.Windows.Forms.Label();
            this.lblVision = new System.Windows.Forms.Label();
            this.lblHearing = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.Plus_Button = new System.Windows.Forms.Button();
            this.Neg_Button = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 16;
            this.lstItems.Location = new System.Drawing.Point(16, 78);
            this.lstItems.Margin = new System.Windows.Forms.Padding(4);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(485, 420);
            this.lstItems.TabIndex = 10;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.LBLSpecs_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(16, 557);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(182, 506);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete robot...";
            this.btnDelete.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(342, 506);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add robot...";
            this.btnAdd.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "RobotID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Company:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sector:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Arms:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Intelligence:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Hearing:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Vision:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Legs:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(536, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mobility:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(551, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Price:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(526, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Specialty:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(534, 386);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Quantity:";
            // 
            // lblRobotID
            // 
            this.lblRobotID.AutoSize = true;
            this.lblRobotID.Location = new System.Drawing.Point(620, 34);
            this.lblRobotID.Name = "lblRobotID";
            this.lblRobotID.Size = new System.Drawing.Size(0, 16);
            this.lblRobotID.TabIndex = 25;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(620, 66);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(0, 16);
            this.lblCompany.TabIndex = 26;
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(620, 98);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(0, 16);
            this.lblSector.TabIndex = 27;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(620, 130);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 16);
            this.lblModel.TabIndex = 28;
            // 
            // lblArms
            // 
            this.lblArms.AutoSize = true;
            this.lblArms.Location = new System.Drawing.Point(620, 162);
            this.lblArms.Name = "lblArms";
            this.lblArms.Size = new System.Drawing.Size(0, 16);
            this.lblArms.TabIndex = 29;
            // 
            // lblMobility
            // 
            this.lblMobility.AutoSize = true;
            this.lblMobility.Location = new System.Drawing.Point(620, 194);
            this.lblMobility.Name = "lblMobility";
            this.lblMobility.Size = new System.Drawing.Size(0, 16);
            this.lblMobility.TabIndex = 30;
            // 
            // lblLegs
            // 
            this.lblLegs.AutoSize = true;
            this.lblLegs.Location = new System.Drawing.Point(620, 226);
            this.lblLegs.Name = "lblLegs";
            this.lblLegs.Size = new System.Drawing.Size(0, 16);
            this.lblLegs.TabIndex = 31;
            // 
            // lblVision
            // 
            this.lblVision.AutoSize = true;
            this.lblVision.Location = new System.Drawing.Point(620, 258);
            this.lblVision.Name = "lblVision";
            this.lblVision.Size = new System.Drawing.Size(0, 16);
            this.lblVision.TabIndex = 32;
            // 
            // lblHearing
            // 
            this.lblHearing.AutoSize = true;
            this.lblHearing.Location = new System.Drawing.Point(620, 290);
            this.lblHearing.Name = "lblHearing";
            this.lblHearing.Size = new System.Drawing.Size(0, 16);
            this.lblHearing.TabIndex = 33;
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(620, 322);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(0, 16);
            this.lblIntelligence.TabIndex = 34;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(620, 354);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(0, 16);
            this.lblSpecialty.TabIndex = 35;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(620, 386);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(0, 16);
            this.lblQuantity.TabIndex = 36;
            this.lblQuantity.Tag = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(620, 418);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 16);
            this.lblPrice.TabIndex = 37;
            // 
            // Plus_Button
            // 
            this.Plus_Button.Location = new System.Drawing.Point(865, 381);
            this.Plus_Button.Name = "Plus_Button";
            this.Plus_Button.Size = new System.Drawing.Size(30, 27);
            this.Plus_Button.TabIndex = 38;
            this.Plus_Button.Text = "+";
            this.Plus_Button.UseVisualStyleBackColor = true;
            this.Plus_Button.Click += new System.EventHandler(this.Plus_Button_Click);
            // 
            // Neg_Button
            // 
            this.Neg_Button.Location = new System.Drawing.Point(829, 381);
            this.Neg_Button.Name = "Neg_Button";
            this.Neg_Button.Size = new System.Drawing.Size(30, 27);
            this.Neg_Button.TabIndex = 39;
            this.Neg_Button.Text = "-";
            this.Neg_Button.UseVisualStyleBackColor = true;
            this.Neg_Button.Click += new System.EventHandler(this.Neg_Button_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(72, 37);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(286, 22);
            this.SearchBox.TabIndex = 40;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchRobotListBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = "Search:";
            // 
            // RobotManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1026, 600);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Neg_Button);
            this.Controls.Add(this.Plus_Button);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSpecialty);
            this.Controls.Add(this.lblIntelligence);
            this.Controls.Add(this.lblHearing);
            this.Controls.Add(this.lblVision);
            this.Controls.Add(this.lblLegs);
            this.Controls.Add(this.lblMobility);
            this.Controls.Add(this.lblArms);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblRobotID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RobotManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "robot Manager";
            this.Load += new System.EventHandler(this.RobotManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRobotID;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblArms;
        private System.Windows.Forms.Label lblMobility;
        private System.Windows.Forms.Label lblLegs;
        private System.Windows.Forms.Label lblVision;
        private System.Windows.Forms.Label lblHearing;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button Plus_Button;
        private System.Windows.Forms.Button Neg_Button;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label14;
    }
}
