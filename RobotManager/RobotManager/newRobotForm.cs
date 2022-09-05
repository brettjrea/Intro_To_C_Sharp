using System;
using System.Windows.Forms;

namespace RobotManager
{
    public partial class newRobotForm : Form
    {
        public newRobotForm()
        {
            InitializeComponent();
        }
      
        private robot robot = null;
       
        public robot GetNewRobot()
        {
            this.ShowDialog();
            return robot;  
        }

        private void Mobile_Radio_Button_Clicked(object sender, EventArgs e)
        {
                if (Mobile_Radio_Button.Checked == true)
                {
                    txtMobile.Text = "Mobile";
                    txtLegs.Text = "Wheels";
                    Legs_Group_Box.Visible = true;
                }
                else if (Stationary_Radio_Button.Checked == true)
                {
                    txtMobile.Text = "Stationary";
                    txtLegs.Text = "Stationary";
                    Legs_Group_Box.Visible = false;
                }      
        }

        private void Legs_Radio_Button_Clicked(object sender, EventArgs e)
        {
            if (Wheels_Radio_Button.Checked == true)
            {
                txtLegs.Text = "Wheels";
                Legs_Group_Box.Visible = true;
            }

            else if (Legs_Radio_Button.Checked == true)
            {
                txtMobile.Text = "Mobile";
                txtLegs.Text = "Legs";
                Legs_Group_Box.Visible = true;
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {                
                robot = new robot(Convert.ToInt32(txtRobotID.Text),
                txtCompany.Text, txtSector.Text, txtModel.Text, Convert.ToInt32(txtArms.Text), txtMobile.Text, txtLegs.Text, txtVision.Text, txtHearing.Text, txtIntelligence.Text, txtSpecialty.Text, Convert.ToInt32(txtQuantity.Text), Convert.ToDecimal(txtPrice.Text));
                this.Close();
            }
        }
        

        private bool IsValidData()
        {
            return Validator.IsPresent(txtRobotID) &&
            Validator.IsInt32(txtRobotID) &&
            Validator.IsPresent(txtCompany) &&
            Validator.IsPresent(txtSector) &&
            Validator.IsPresent(txtModel) &&
            Validator.IsPresent(txtArms) &&
            Validator.IsInt32(txtArms) &&
            Validator.IsPresent(txtMobile) &&
            Validator.IsPresent(txtLegs) &&
            Validator.IsPresent(txtVision) &&
            Validator.IsPresent(txtHearing) &&
            Validator.IsPresent(txtIntelligence) &&
            Validator.IsPresent(txtSpecialty) &&
            Validator.IsPresent(txtQuantity) &&
            Validator.IsInt32(txtQuantity) &&
            Validator.IsPresent(txtPrice) &&
            Validator.IsDecimal(txtPrice);
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewRobotForm_Load(object sender, EventArgs e)
        {

        }
    }
}