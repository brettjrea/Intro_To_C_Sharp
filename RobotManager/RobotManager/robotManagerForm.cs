using System;
using System.Windows.Forms;

namespace RobotManager
{
    public partial class RobotManagerForm : Form
    {
        public RobotManagerForm()
        {
            InitializeComponent();
        }

        private RobotList robotList = new RobotList();

        private void RobotManagerForm_Load(object sender, System.EventArgs e)
        {
            robotList.Fill();
            FillRobotListBox();
        }

        private void FillRobotListBox()
        {
            robot robot;
            lstItems.Items.Clear();
            for (int i = 0; i < robotList.Count; i++)
            {
                robot = robotList.GetRobotByIndex(i);
                lstItems.Items.Add(robot.GetDisplayText());
            }
        }
        private void SearchRobotListBox_TextChanged(object sender, System.EventArgs e)
        {
            robot robot;
            lstItems.Items.Clear();
            for (int i = 0; i < robotList.Count; i++)
            {
                robot = robotList.GetRobotByIndex(i);
                if (robot.GetValues().ToString().Contains(SearchBox.Text))
                {
                   lstItems.Items.Add(robot.GetDisplayText());
                }
            }
        }

        private void Add_Button_Click(object sender, System.EventArgs e)
        {
            newRobotForm newRobotForm = new newRobotForm();
            robot robot = newRobotForm.GetNewRobot();
            if (robot != null)
            {
                robotList.Add(robot);
                robotList.Save();
                FillRobotListBox();
            }
        }
        
        private void LBLSpecs_SelectedIndexChanged(object sender, System.EventArgs e)
        {
  
            int i = lstItems.SelectedIndex; 
            if (i >= 0)
            {
                robot robot = robotList.GetRobotByIndex(i);
                lblRobotID.Text = Convert.ToString(robot.RobotID);
                lblCompany.Text = robot.Company;
                lblSector.Text = robot.Sector;
                lblModel.Text = robot.Model;
                lblArms.Text = Convert.ToString(robot.Arms);
                lblMobility.Text = robot.Mobility;
                lblLegs.Text = robot.Legs;
                lblVision.Text = robot.Vision;
                lblHearing.Text = robot.Hearing;
                lblIntelligence.Text = robot.Intelligence;
                lblSpecialty.Text = robot.Specialty;
                lblQuantity.Text = Convert.ToString(robot.Quantity);
                lblPrice.Text = Convert.ToString(robot.Price);
            }
        }
        private void Plus_Button_Click(object sender, System.EventArgs e) {

            int i = lstItems.SelectedIndex;
            robot robot = robotList.GetRobotByIndex(i);
            robot.Quantity = robot.Quantity + 1;
            lblQuantity.Text = Convert.ToString(robot.Quantity);

        }

        private void Neg_Button_Click(object sender, System.EventArgs e)
        {

            int i = lstItems.SelectedIndex;
            robot robot = robotList.GetRobotByIndex(i);
            robot.Quantity = robot.Quantity -1;
            lblQuantity.Text = Convert.ToString(robot.Quantity);
        }
        private void Delete_Button_Click(object sender, System.EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                robot robot = robotList.GetRobotByIndex(i);
                string message = "Are you sure you want to delete "
                + robot.Company + "?";
                DialogResult button =
                MessageBox.Show(message, "Confirm Delete",
                MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    robotList.Remove(robot);
                    robotList.Save();
                    FillRobotListBox();
                }
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}