namespace RobotManager
{
    partial class newRobotForm
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
            this.txtRobotID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArms = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVision = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHearing = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Mobile_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Stationary_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Wheels_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Legs_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Legs_Group_Box = new System.Windows.Forms.GroupBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtLegs = new System.Windows.Forms.TextBox();
            this.Legs_Group_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Robot ID:";
            // 
            // txtRobotID
            // 
            this.txtRobotID.Location = new System.Drawing.Point(97, 21);
            this.txtRobotID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRobotID.Name = "txtRobotID";
            this.txtRobotID.Size = new System.Drawing.Size(100, 22);
            this.txtRobotID.TabIndex = 1;
            this.txtRobotID.Tag = "robot ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company:";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(97, 59);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(265, 22);
            this.txtCompany.TabIndex = 3;
            this.txtCompany.Tag = "Company";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 507);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(97, 507);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 480);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(97, 477);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(99, 22);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Tag = "Price";
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(97, 97);
            this.txtSector.Margin = new System.Windows.Forms.Padding(4);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(265, 22);
            this.txtSector.TabIndex = 9;
            this.txtSector.Tag = "Sector";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sector:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(97, 135);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(265, 22);
            this.txtModel.TabIndex = 11;
            this.txtModel.Tag = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Model:";
            // 
            // txtArms
            // 
            this.txtArms.Location = new System.Drawing.Point(97, 173);
            this.txtArms.Margin = new System.Windows.Forms.Padding(4);
            this.txtArms.Name = "txtArms";
            this.txtArms.Size = new System.Drawing.Size(100, 22);
            this.txtArms.TabIndex = 13;
            this.txtArms.Tag = "Arms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Arms:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mobility:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Legs:";
            // 
            // txtVision
            // 
            this.txtVision.Location = new System.Drawing.Point(97, 287);
            this.txtVision.Margin = new System.Windows.Forms.Padding(4);
            this.txtVision.Name = "txtVision";
            this.txtVision.Size = new System.Drawing.Size(265, 22);
            this.txtVision.TabIndex = 19;
            this.txtVision.Tag = "Legs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 290);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Vision:";
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point(97, 401);
            this.txtSpecialty.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(265, 22);
            this.txtSpecialty.TabIndex = 25;
            this.txtSpecialty.Tag = "Legs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 404);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Specialty";
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.Location = new System.Drawing.Point(97, 363);
            this.txtIntelligence.Margin = new System.Windows.Forms.Padding(4);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.Size = new System.Drawing.Size(265, 22);
            this.txtIntelligence.TabIndex = 23;
            this.txtIntelligence.Tag = "Legs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 366);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Intelligence:";
            // 
            // txtHearing
            // 
            this.txtHearing.Location = new System.Drawing.Point(97, 325);
            this.txtHearing.Margin = new System.Windows.Forms.Padding(4);
            this.txtHearing.Name = "txtHearing";
            this.txtHearing.Size = new System.Drawing.Size(265, 22);
            this.txtHearing.TabIndex = 21;
            this.txtHearing.Tag = "Model";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 328);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Hearing:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(97, 439);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 27;
            this.txtQuantity.Tag = "Arms";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 442);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Quantity:";
            // 
            // Mobile_Radio_Button
            // 
            this.Mobile_Radio_Button.AutoSize = true;
            this.Mobile_Radio_Button.Location = new System.Drawing.Point(115, 214);
            this.Mobile_Radio_Button.Name = "Mobile_Radio_Button";
            this.Mobile_Radio_Button.Size = new System.Drawing.Size(72, 20);
            this.Mobile_Radio_Button.TabIndex = 28;
            this.Mobile_Radio_Button.Text = "Mobile.";
            this.Mobile_Radio_Button.UseVisualStyleBackColor = true;
            this.Mobile_Radio_Button.CheckedChanged += new System.EventHandler(this.Mobile_Radio_Button_Clicked);
            // 
            // Stationary_Radio_Button
            // 
            this.Stationary_Radio_Button.AutoSize = true;
            this.Stationary_Radio_Button.Location = new System.Drawing.Point(214, 214);
            this.Stationary_Radio_Button.Name = "Stationary_Radio_Button";
            this.Stationary_Radio_Button.Size = new System.Drawing.Size(91, 20);
            this.Stationary_Radio_Button.TabIndex = 29;
            this.Stationary_Radio_Button.Text = "Stationary.";
            this.Stationary_Radio_Button.UseVisualStyleBackColor = true;
            this.Stationary_Radio_Button.CheckedChanged += new System.EventHandler(this.Mobile_Radio_Button_Clicked);
            // 
            // Wheels_Radio_Button
            // 
            this.Wheels_Radio_Button.AutoSize = true;
            this.Wheels_Radio_Button.Location = new System.Drawing.Point(86, 23);
            this.Wheels_Radio_Button.Name = "Wheels_Radio_Button";
            this.Wheels_Radio_Button.Size = new System.Drawing.Size(77, 20);
            this.Wheels_Radio_Button.TabIndex = 30;
            this.Wheels_Radio_Button.Text = "Wheels.";
            this.Wheels_Radio_Button.UseVisualStyleBackColor = true;
            this.Wheels_Radio_Button.CheckedChanged += new System.EventHandler(this.Legs_Radio_Button_Clicked);
            // 
            // Legs_Radio_Button
            // 
            this.Legs_Radio_Button.AutoSize = true;
            this.Legs_Radio_Button.Location = new System.Drawing.Point(185, 23);
            this.Legs_Radio_Button.Name = "Legs_Radio_Button";
            this.Legs_Radio_Button.Size = new System.Drawing.Size(61, 20);
            this.Legs_Radio_Button.TabIndex = 31;
            this.Legs_Radio_Button.TabStop = true;
            this.Legs_Radio_Button.Text = "Legs.";
            this.Legs_Radio_Button.UseVisualStyleBackColor = true;
            this.Legs_Radio_Button.CheckedChanged += new System.EventHandler(this.Legs_Radio_Button_Clicked);
            // 
            // Legs_Group_Box
            // 
            this.Legs_Group_Box.Controls.Add(this.Legs_Radio_Button);
            this.Legs_Group_Box.Controls.Add(this.Wheels_Radio_Button);
            this.Legs_Group_Box.Controls.Add(this.label8);
            this.Legs_Group_Box.Location = new System.Drawing.Point(29, 233);
            this.Legs_Group_Box.Name = "Legs_Group_Box";
            this.Legs_Group_Box.Size = new System.Drawing.Size(320, 49);
            this.Legs_Group_Box.TabIndex = 34;
            this.Legs_Group_Box.TabStop = false;
            this.Legs_Group_Box.Visible = false;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(366, 214);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(100, 22);
            this.txtMobile.TabIndex = 35;
            this.txtMobile.Visible = false;
            // 
            // txtLegs
            // 
            this.txtLegs.Location = new System.Drawing.Point(366, 260);
            this.txtLegs.Name = "txtLegs";
            this.txtLegs.Size = new System.Drawing.Size(100, 22);
            this.txtLegs.TabIndex = 36;
            this.txtLegs.Visible = false;
            // 
            // newRobotForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(511, 585);
            this.ControlBox = false;
            this.Controls.Add(this.txtLegs);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.Legs_Group_Box);
            this.Controls.Add(this.Stationary_Radio_Button);
            this.Controls.Add(this.Mobile_Radio_Button);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSpecialty);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIntelligence);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtHearing);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtVision);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtArms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRobotID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newRobotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New robot Form";
            this.Load += new System.EventHandler(this.NewRobotForm_Load);
            this.Legs_Group_Box.ResumeLayout(false);
            this.Legs_Group_Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRobotID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVision;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIntelligence;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHearing;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton Mobile_Radio_Button;
        private System.Windows.Forms.RadioButton Stationary_Radio_Button;
        private System.Windows.Forms.RadioButton Wheels_Radio_Button;
        private System.Windows.Forms.RadioButton Legs_Radio_Button;
        private System.Windows.Forms.GroupBox Legs_Group_Box;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtLegs;
    }
}