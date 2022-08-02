using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCalculator
{
    public partial class TimeCalculator : Form
    {
        public TimeCalculator()
        {
            InitializeComponent();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtSec.Text = "";
            txtDay.Text = "";
            txtHour.Text = "";
            txtMin.Text = "";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
           Int64 totalSeconds = Convert.ToInt64(txtSec.Text);
       
           txtMin.Text = (totalSeconds / 60).ToString();
           txtHour.Text = (totalSeconds / 3600).ToString();
           txtDay.Text = (totalSeconds / 86400).ToString();
        }

    
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeCalculator_Load(object sender, EventArgs e)
        {

        }

        private void TimeCalculator_Load_1(object sender, EventArgs e)
        {

        }
        private void TxtSec_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtHour_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtMin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}