using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriesApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Calculate Fat Button
        private void BtnCalcFat_Click(object sender, EventArgs e)
        {
            //call method and display calories from fat
            lblFatRslt.Text = "Calories from fat : " + FatToCalories(int.Parse(txtInptFat.Text));
        }

        //Calculate Carbs Button
        private void BtnCalcCarbs_Click(object sender, EventArgs e)
        {
            //call method and display calories from carbs
            lblCarbsRslt.Text = "Calories from carbs : " + CarbsToCalories(int.Parse(txtInptCarbs.Text));
        }
   
        //method to calculate calories from fat
        public static int FatToCalories(int fat)
        {
            return fat * 9;//returns calories from fat
        }
        //method to calculate calories from carbs
        public static int CarbsToCalories(int carbs)
        {
            return carbs * 4;//returns calories from carbs
        }
    }
}