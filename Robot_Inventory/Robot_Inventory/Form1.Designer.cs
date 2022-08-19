using System;

namespace Robot_Inventory
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
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.sectorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addPhoneButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.robotListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.armsTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.visionTextBox = new System.Windows.Forms.TextBox();
            this.hearingTextBox = new System.Windows.Forms.TextBox();
            this.intelligenceTextBox = new System.Windows.Forms.TextBox();
            this.specialtyTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mobileRadioButton = new System.Windows.Forms.RadioButton();
            this.stationaryRadioButton = new System.Windows.Forms.RadioButton();
            this.mobilityGroup = new System.Windows.Forms.GroupBox();
            this.legsGroupBox = new System.Windows.Forms.GroupBox();
            this.legsRadioButton = new System.Windows.Forms.RadioButton();
            this.wheelsRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.sectorLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.armsLabel = new System.Windows.Forms.Label();
            this.mobilityLabel = new System.Windows.Forms.Label();
            this.legsLabel = new System.Windows.Forms.Label();
            this.visionLabel = new System.Windows.Forms.Label();
            this.hearingLabel = new System.Windows.Forms.Label();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.specialtyLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.mobilityGroup.SuspendLayout();
            this.legsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyTextBox
            // 
            this.companyTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.companyTextBox.Location = new System.Drawing.Point(120, 64);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(141, 22);
            this.companyTextBox.TabIndex = 0;
            // 
            // sectorTextBox
            // 
            this.sectorTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sectorTextBox.Location = new System.Drawing.Point(120, 92);
            this.sectorTextBox.Name = "sectorTextBox";
            this.sectorTextBox.Size = new System.Drawing.Size(141, 22);
            this.sectorTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sector:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(120, 436);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(141, 22);
            this.priceTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price:";
            // 
            // addPhoneButton
            // 
            this.addPhoneButton.Location = new System.Drawing.Point(326, 484);
            this.addPhoneButton.Name = "addPhoneButton";
            this.addPhoneButton.Size = new System.Drawing.Size(169, 31);
            this.addPhoneButton.TabIndex = 6;
            this.addPhoneButton.Text = "Submit Robot.";
            this.addPhoneButton.UseVisualStyleBackColor = true;
            this.addPhoneButton.Click += new System.EventHandler(this.addRobotButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(321, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current Inventory:";
            // 
            // robotListBox
            // 
            this.robotListBox.FormattingEnabled = true;
            this.robotListBox.ItemHeight = 16;
            this.robotListBox.Location = new System.Drawing.Point(326, 90);
            this.robotListBox.Name = "robotListBox";
            this.robotListBox.Size = new System.Drawing.Size(169, 388);
            this.robotListBox.TabIndex = 8;
            this.robotListBox.Click += new System.EventHandler(this.robotListBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 555);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(169, 28);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Remove Robot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.removeRobotButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(41, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Add a Robot to Inventory:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.modelTextBox.Location = new System.Drawing.Point(120, 120);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(141, 22);
            this.modelTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "# of Arms:";
            // 
            // armsTextBox
            // 
            this.armsTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.armsTextBox.Location = new System.Drawing.Point(120, 148);
            this.armsTextBox.Name = "armsTextBox";
            this.armsTextBox.Size = new System.Drawing.Size(141, 22);
            this.armsTextBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Vision:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Hearing:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 410);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Specialty:";
            // 
            // visionTextBox
            // 
            this.visionTextBox.Location = new System.Drawing.Point(120, 308);
            this.visionTextBox.Name = "visionTextBox";
            this.visionTextBox.Size = new System.Drawing.Size(141, 22);
            this.visionTextBox.TabIndex = 27;
            // 
            // hearingTextBox
            // 
            this.hearingTextBox.Location = new System.Drawing.Point(120, 340);
            this.hearingTextBox.Name = "hearingTextBox";
            this.hearingTextBox.Size = new System.Drawing.Size(141, 22);
            this.hearingTextBox.TabIndex = 28;
            // 
            // intelligenceTextBox
            // 
            this.intelligenceTextBox.Location = new System.Drawing.Point(120, 404);
            this.intelligenceTextBox.Name = "intelligenceTextBox";
            this.intelligenceTextBox.Size = new System.Drawing.Size(141, 22);
            this.intelligenceTextBox.TabIndex = 29;
            // 
            // specialtyTextBox
            // 
            this.specialtyTextBox.Location = new System.Drawing.Point(120, 372);
            this.specialtyTextBox.Name = "specialtyTextBox";
            this.specialtyTextBox.Size = new System.Drawing.Size(141, 22);
            this.specialtyTextBox.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 378);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Intelligence:";
            // 
            // mobileRadioButton
            // 
            this.mobileRadioButton.AutoSize = true;
            this.mobileRadioButton.Location = new System.Drawing.Point(13, 21);
            this.mobileRadioButton.Name = "mobileRadioButton";
            this.mobileRadioButton.Size = new System.Drawing.Size(69, 20);
            this.mobileRadioButton.TabIndex = 32;
            this.mobileRadioButton.TabStop = true;
            this.mobileRadioButton.Text = "Mobile";
            this.mobileRadioButton.UseVisualStyleBackColor = true;
            this.mobileRadioButton.Click += new System.EventHandler(this.mobileButton_Click);
            // 
            // stationaryRadioButton
            // 
            this.stationaryRadioButton.AutoSize = true;
            this.stationaryRadioButton.Location = new System.Drawing.Point(90, 21);
            this.stationaryRadioButton.Name = "stationaryRadioButton";
            this.stationaryRadioButton.Size = new System.Drawing.Size(88, 20);
            this.stationaryRadioButton.TabIndex = 33;
            this.stationaryRadioButton.TabStop = true;
            this.stationaryRadioButton.Text = "Stationary";
            this.stationaryRadioButton.UseVisualStyleBackColor = true;
            this.stationaryRadioButton.Click += new System.EventHandler(this.stationaryButton_Click);
            // 
            // mobilityGroup
            // 
            this.mobilityGroup.Controls.Add(this.mobileRadioButton);
            this.mobilityGroup.Controls.Add(this.stationaryRadioButton);
            this.mobilityGroup.Location = new System.Drawing.Point(33, 185);
            this.mobilityGroup.Name = "mobilityGroup";
            this.mobilityGroup.Size = new System.Drawing.Size(228, 54);
            this.mobilityGroup.TabIndex = 34;
            this.mobilityGroup.TabStop = false;
            this.mobilityGroup.Text = "Mobility";
            // 
            // legsGroupBox
            // 
            this.legsGroupBox.Controls.Add(this.legsRadioButton);
            this.legsGroupBox.Controls.Add(this.wheelsRadioButton);
            this.legsGroupBox.Location = new System.Drawing.Point(33, 246);
            this.legsGroupBox.Name = "legsGroupBox";
            this.legsGroupBox.Size = new System.Drawing.Size(228, 56);
            this.legsGroupBox.TabIndex = 35;
            this.legsGroupBox.TabStop = false;
            this.legsGroupBox.Text = "Legs";
            this.legsGroupBox.Visible = false;
            // 
            // legsRadioButton
            // 
            this.legsRadioButton.AutoSize = true;
            this.legsRadioButton.Location = new System.Drawing.Point(90, 22);
            this.legsRadioButton.Name = "legsRadioButton";
            this.legsRadioButton.Size = new System.Drawing.Size(58, 20);
            this.legsRadioButton.TabIndex = 1;
            this.legsRadioButton.TabStop = true;
            this.legsRadioButton.Text = "Legs";
            this.legsRadioButton.UseVisualStyleBackColor = true;
            // 
            // wheelsRadioButton
            // 
            this.wheelsRadioButton.AutoSize = true;
            this.wheelsRadioButton.Location = new System.Drawing.Point(13, 21);
            this.wheelsRadioButton.Name = "wheelsRadioButton";
            this.wheelsRadioButton.Size = new System.Drawing.Size(74, 20);
            this.wheelsRadioButton.TabIndex = 0;
            this.wheelsRadioButton.TabStop = true;
            this.wheelsRadioButton.Text = "Wheels";
            this.wheelsRadioButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(537, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Robot Specifications:";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(628, 67);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(0, 16);
            this.companyLabel.TabIndex = 37;
            // 
            // sectorLabel
            // 
            this.sectorLabel.AutoSize = true;
            this.sectorLabel.Location = new System.Drawing.Point(628, 107);
            this.sectorLabel.Name = "sectorLabel";
            this.sectorLabel.Size = new System.Drawing.Size(0, 16);
            this.sectorLabel.TabIndex = 38;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(628, 147);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(0, 16);
            this.modelLabel.TabIndex = 39;
            // 
            // armsLabel
            // 
            this.armsLabel.AutoSize = true;
            this.armsLabel.Location = new System.Drawing.Point(628, 187);
            this.armsLabel.Name = "armsLabel";
            this.armsLabel.Size = new System.Drawing.Size(0, 16);
            this.armsLabel.TabIndex = 40;
            // 
            // mobilityLabel
            // 
            this.mobilityLabel.AutoSize = true;
            this.mobilityLabel.Location = new System.Drawing.Point(628, 227);
            this.mobilityLabel.Name = "mobilityLabel";
            this.mobilityLabel.Size = new System.Drawing.Size(0, 16);
            this.mobilityLabel.TabIndex = 41;
            // 
            // legsLabel
            // 
            this.legsLabel.AutoSize = true;
            this.legsLabel.Location = new System.Drawing.Point(628, 267);
            this.legsLabel.Name = "legsLabel";
            this.legsLabel.Size = new System.Drawing.Size(0, 16);
            this.legsLabel.TabIndex = 42;
            // 
            // visionLabel
            // 
            this.visionLabel.AutoSize = true;
            this.visionLabel.Location = new System.Drawing.Point(628, 307);
            this.visionLabel.Name = "visionLabel";
            this.visionLabel.Size = new System.Drawing.Size(0, 16);
            this.visionLabel.TabIndex = 43;
            // 
            // hearingLabel
            // 
            this.hearingLabel.AutoSize = true;
            this.hearingLabel.Location = new System.Drawing.Point(628, 347);
            this.hearingLabel.Name = "hearingLabel";
            this.hearingLabel.Size = new System.Drawing.Size(0, 16);
            this.hearingLabel.TabIndex = 44;
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.Location = new System.Drawing.Point(628, 387);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(0, 16);
            this.intelligenceLabel.TabIndex = 45;
            // 
            // specialtyLabel
            // 
            this.specialtyLabel.AutoSize = true;
            this.specialtyLabel.Location = new System.Drawing.Point(628, 427);
            this.specialtyLabel.Name = "specialtyLabel";
            this.specialtyLabel.Size = new System.Drawing.Size(0, 16);
            this.specialtyLabel.TabIndex = 46;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(628, 467);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 16);
            this.priceLabel.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(540, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 51;
            this.label14.Text = "# of Arms:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(557, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 50;
            this.label15.Text = "Model:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(556, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 16);
            this.label16.TabIndex = 49;
            this.label16.Text = "Sector:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(537, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 16);
            this.label17.TabIndex = 48;
            this.label17.Text = "Company:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(527, 387);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 16);
            this.label18.TabIndex = 56;
            this.label18.Text = "Intelligence:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(539, 427);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 16);
            this.label19.TabIndex = 55;
            this.label19.Text = "Specialty:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(547, 347);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 16);
            this.label20.TabIndex = 54;
            this.label20.Text = "Hearing:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(558, 307);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 16);
            this.label21.TabIndex = 53;
            this.label21.Text = "Vision:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(564, 467);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 16);
            this.label22.TabIndex = 52;
            this.label22.Text = "Price:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(549, 227);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 16);
            this.label23.TabIndex = 57;
            this.label23.Text = "Mobility:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(605, 267);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 16);
            this.label24.TabIndex = 58;
            // 
            // searchTextBox
            // 
            this.searchTextBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchTextBox.Location = new System.Drawing.Point(326, 61);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(169, 22);
            this.searchTextBox.TabIndex = 59;
            this.searchTextBox.Text = "Search:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(120, 468);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(141, 22);
            this.quantityTextBox.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 474);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 61;
            this.label11.Text = "Quantity:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(547, 499);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 16);
            this.label25.TabIndex = 62;
            this.label25.Text = "Quantity:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(631, 499);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(0, 16);
            this.quantityLabel.TabIndex = 63;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 595);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.specialtyLabel);
            this.Controls.Add(this.intelligenceLabel);
            this.Controls.Add(this.hearingLabel);
            this.Controls.Add(this.visionLabel);
            this.Controls.Add(this.legsLabel);
            this.Controls.Add(this.mobilityLabel);
            this.Controls.Add(this.armsLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.sectorLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.legsGroupBox);
            this.Controls.Add(this.mobilityGroup);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.specialtyTextBox);
            this.Controls.Add(this.intelligenceTextBox);
            this.Controls.Add(this.hearingTextBox);
            this.Controls.Add(this.visionTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.armsTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.robotListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addPhoneButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sectorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.companyTextBox);
            this.Name = "Form1";
            this.Text = "Robot Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mobilityGroup.ResumeLayout(false);
            this.mobilityGroup.PerformLayout();
            this.legsGroupBox.ResumeLayout(false);
            this.legsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox sectorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addPhoneButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox robotListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox armsTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox visionTextBox;
        private System.Windows.Forms.TextBox hearingTextBox;
        private System.Windows.Forms.TextBox intelligenceTextBox;
        private System.Windows.Forms.TextBox specialtyTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton mobileRadioButton;
        private System.Windows.Forms.RadioButton stationaryRadioButton;
        private System.Windows.Forms.GroupBox mobilityGroup;
        private System.Windows.Forms.GroupBox legsGroupBox;
        private System.Windows.Forms.RadioButton wheelsRadioButton;
        private System.Windows.Forms.RadioButton legsRadioButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label sectorLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label armsLabel;
        private System.Windows.Forms.Label mobilityLabel;
        private System.Windows.Forms.Label legsLabel;
        private System.Windows.Forms.Label visionLabel;
        private System.Windows.Forms.Label hearingLabel;
        private System.Windows.Forms.Label intelligenceLabel;
        private System.Windows.Forms.Label specialtyLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label quantityLabel;
    }
}

