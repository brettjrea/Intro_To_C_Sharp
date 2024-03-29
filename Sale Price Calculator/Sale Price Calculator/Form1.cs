﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;// The item's original price           
            decimal discountPercentage;// The discount percentage          
            decimal discountAmount;// The amount of discount           
            decimal salePrice;// The item's sale price

            // Get the item's original price       
            originalPrice = decimal.Parse(OriginalPriceTextBox.Text);
            // Get the discount percentage.
            discountPercentage = decimal.Parse(discountPercentageTextbox.Text);
            // Move the percentage's decimal point left two spaces.
            discountPercentage = discountPercentage / 100;
            // Calculate the amount of the discount.
            discountAmount = originalPrice * discountPercentage;
            // Calculate the sale price.
            salePrice = originalPrice-discountAmount;
            // Display the sale price. 
            SalePriceLabel.Text = salePrice.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.           
            this.Close();
        }
    }
}
