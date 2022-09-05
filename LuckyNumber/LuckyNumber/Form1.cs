using System;
using System.Windows.Forms;


namespace LuckyNumber
{
    public partial class Form1 : Form
    {
      
int maxDay;
        static int luckyNumber;
        public Form1()
        {
            InitializeComponent();
        }
        public int getLuckyNumber()
        {
            return luckyNumber;
        }
        public void birthDay()
        {
            //initial max day
            maxDay = 0;
            if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 2 || comboBox2.SelectedIndex == 4 || comboBox2.SelectedIndex == 6 || comboBox2.SelectedIndex == 7 || comboBox2.SelectedIndex == 9 || comboBox2.SelectedIndex == 11)
            {
                maxDay = 31;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                int year = Int32.Parse(comboBox1.Text);
                // If a year is a multiple of 400 then it is a leap year.
                if (year % 400 == 0)
                    maxDay = 29;
                // If a year is muliple of 100 then it is not a leap year.
                if (year % 100 == 0)
                    maxDay = 28;
                //If a year is muliple of 4 then is a leap year.
                if (year % 4 == 0)
                    maxDay = 29;
                else
                    maxDay = 28;
            }
            else
                maxDay = 30;
            if (comboBox2.SelectedIndex != -1)
            {
                comboBox3.Items.Clear();
                for (int i = 0; i < maxDay; i++)
                {
                    comboBox3.Items.Add(i + 1);
                }
                comboBox3.Text = maxDay.ToString();
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDay();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDay();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1)
            {
                //calculation lucky number
                luckyNumber = (comboBox1.SelectedIndex + comboBox2.SelectedIndex + comboBox3.SelectedIndex + comboBox4.SelectedIndex);
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Please Fill The Above Form");
            }
        }
    }
}
