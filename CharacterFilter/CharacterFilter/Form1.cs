using System;
using System.Collections;
using System.Windows.Forms;

namespace CharacterFilter
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


        ArrayList CharactersList = new ArrayList();

        private void UpdateListBox(ArrayList CharactersList)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = CharactersList;
            listBox1.DisplayMember = "Name";
        }

        Characters char1 = new Characters("Knight", "Human", 45, 1);
        Characters char2 = new Characters("Archer", "Human", 45, 1);
        Characters char3 = new Characters("Scout", "Human", 45, 1);
        private void Checkbox1_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox1.Checked)
            {

                CharactersList.Add(char1);
                CharactersList.Add(char2);
                CharactersList.Add(char3);
                UpdateListBox(CharactersList);
            }
            else
            {
                CharactersList.Remove(char1);
                CharactersList.Remove(char2);
                CharactersList.Remove(char3);
                UpdateListBox(CharactersList);
            }
        }

        Characters char4 = new Characters("Elven Assassin", "Mythical", 27, 99);
        Characters char5 = new Characters("Demolition Dwarf", "Mythical", 70, 30);
        Characters char6 = new Characters("Tough Troll", "Mythical", 90, 10);
        private void Checkbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                CharactersList.Add(char4);
                CharactersList.Add(char5);
                CharactersList.Add(char6);
                UpdateListBox(CharactersList);
            }
            else
            {
                CharactersList.Remove(char4);
                CharactersList.Remove(char5);
                CharactersList.Remove(char6);
                UpdateListBox(CharactersList);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton whichBox = (RadioButton)sender;

            if (whichBox.Checked == true)
            {
                if (whichBox.Name == "radioButton1")
                {
                    listBox1.DisplayMember = "GetUserDetails";
                }
                else if (whichBox.Name == "radioButton2")
                {
                    listBox1.DisplayMember = "GetStrength";
                }
                else
                {
                    listBox1.DisplayMember = "GetMagic";
                }
            }
        }


        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Get the selected item, but you have to cast it to the correct class
            var mySelectedItem = (Characters)((ListBox)sender).SelectedItem;

            if (mySelectedItem != null)
            {
                MessageBox.Show(string.Format("The Character you selected is a {0} {1},\r\nstrength level of {2}, and\r\nmagic level of {3}.", mySelectedItem.Type,
                    mySelectedItem.Name, mySelectedItem.Strength, mySelectedItem.Magic),
                    "Selected Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


// Class to be used with the ListBox
public class Characters
{
    // Properties

    public string Name { get; set; }
    public string Type { get; set; }
    public int Strength { get; set; }
    public int Magic { get; set; }

    // Constructor
    public Characters(string name, string type, int strength, int magic)
    {
        Name = name;
        Type = type;
        Strength = strength;
        Magic = magic;
    }

    // Methods
    public string GetUserDetails
    {
        get { return string.Format("Name: {0}, Type: {1}, Strength: {2}, Magic: {3}", Name, Type, Strength, Magic); }
    }

    public string GetStrength
    {
        get { return string.Format("Name: {0}, Strength: {1}", Name, Strength); }
    }
    public string GetMagic
    {
        get { return string.Format("Name: {0}, Magic: {1}", Name, Magic); }
    }
}
