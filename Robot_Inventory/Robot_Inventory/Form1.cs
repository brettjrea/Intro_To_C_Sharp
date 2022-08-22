using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Robot_Inventory

{
    public partial class Form1 : Form
    {
        // List to hold Robot objects
        List<Robot> robotList = new List<Robot>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        // The GetRobotData method accepts a Robot object     
        // as an argument. It assigns the data entered by the        
        // user to the object's properties.

        private void GetRobotData(Robot robot)
        {
            // Temporary variable to hold the price.
            int arms;
            int quantity;
            decimal price;
            // Get the robot's company.
            robot.Company = companyTextBox.Text;
            // Get the robot's sector.
            robot.Sector = sectorTextBox.Text;
            // Get the robot's model.
            robot.Model = modelTextBox.Text;

            // Get the robot's arms.
            if (int.TryParse(armsTextBox.Text, out arms))
            {
                robot.Arms = arms;
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid number of arms.");
            }

            if (mobileRadioButton.Checked == true)
            {
                robot.Mobility = "Mobile";
            }

            if (stationaryRadioButton.Checked == true)
            {
                robot.Mobility = "Stationary";
            }

       
            if (wheelsRadioButton.Checked == true)
            {
                robot.Legs = "Wheels";
            }

            if (legsRadioButton.Checked == true)
            {
                robot.Legs = "Legs";
            }

            // Get the robot's vision.
            robot.Vision = visionTextBox.Text;
            // Get the robot's hearing.
            robot.Hearing = hearingTextBox.Text;
            // Get the robot's intelligence.
            robot.Intelligence = intelligenceTextBox.Text;
            // Get the robot's specialty.
            robot.Specialty = specialtyTextBox.Text;

            // Get the robot's arms.
            if (int.TryParse(quantityTextBox.Text, out quantity))
            {
                robot.Quantity = quantity;
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid number of arms.");
            }
            // Get the robot's price.
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                robot.Price = price;
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid price");
            }
        }

        private void addRobotButton_Click(object sender, EventArgs e)
        {
            // Create a Robot object.
            Robot myRobot = new Robot();
            // Get the robot data.
            GetRobotData(myRobot);
            // Add the Robot object to the List.
            robotList.Add(myRobot);
            // Add an entry to the list box.
            robotListBox.Items.Add(myRobot.Company + " " + myRobot.Sector);
            // Clear the TextBox controls.
            companyTextBox.Clear();
            sectorTextBox.Clear();
            modelTextBox.Clear();
            armsTextBox.Clear();
            mobileRadioButton.Checked = false;
            stationaryRadioButton.Checked = false;
            wheelsRadioButton.Checked = false;
            legsRadioButton.Checked = false;
            visionTextBox.Clear();
            hearingTextBox.Clear();
            intelligenceTextBox.Clear();
            specialtyTextBox.Clear();
            quantityTextBox.Clear();
            priceTextBox.Clear();
            // Reset the focus.
            companyTextBox.Focus();
        }
        private void removeRobotButton_Click(object sender, EventArgs e)
        {
            robotListBox.Items.Remove(robotListBox.SelectedItem);
        }

        private void robotListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = robotListBox.SelectedIndex;
            companyLabel.Text = robotList[index].Company;
            sectorLabel.Text = robotList[index].Sector;
            modelLabel.Text = robotList[index].Model;
            armsLabel.Text = robotList[index].Arms.ToString("g");
            mobilityLabel.Text = robotList[index].Mobility;
            legsLabel.Text = robotList[index].Legs;
            visionLabel.Text = robotList[index].Vision;
            hearingLabel.Text = robotList[index].Hearing;
            intelligenceLabel.Text = robotList[index].Intelligence;
            specialtyLabel.Text = robotList[index].Specialty;
            priceLabel.Text = robotList[index].Price.ToString("c");
            quantityLabel.Text = robotList[index].Quantity.ToString("g");
        }
        private void mobileButton_Click(object sender, EventArgs e)
        {
            legsGroupBox.Visible = true;
        }
        private void stationaryButton_Click(object sender, EventArgs e)
        {
            legsGroupBox.Visible = false;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}