using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControls
{
    public partial class Form1 : Form
    {
        //Controls.
        private TextBox txtBox = new TextBox();
        private Button btnAdd = new Button();
        private Button btnRemove = new Button();
        private ListBox lstBox = new ListBox();
        private CheckBox chkBox = new CheckBox();
        private Label lblCount = new Label();
        //Other code.
        public Form1()
        {
        InitializeComponent();
            EventHandler handlerAdd = new EventHandler(btncontClickAdd);
            btnAdd.Click += handlerAdd;
            this.Controls.Add(btnAdd);

            EventHandler handlerRemove = new EventHandler(btncontClickRemove);
            btnRemove.Click += handlerRemove;
            this.Controls.Add(btnRemove);

            this.Controls.Add(txtBox);

        }
        private void btncontClickAdd(object sender, EventArgs e)
        {
            this.lstBox.Items.Add(this.txtBox.Text);
        }

        private void btncontClickRemove(object sender, EventArgs e)
        {
            for (int i = 0; i < lstBox.SelectedItems.Count; i++)
                lstBox.Items.Remove(lstBox.SelectedItems[i]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set up the form.
             this.MaximizeBox = false;
             this.MinimizeBox = false;
             this.BackColor = Color.White;
             this.ForeColor = Color.Black;
             this.Size = new System.Drawing.Size(155, 265);
             this.Text = "Run-time Controls w/ Event Handler";
             this.FormBorderStyle = FormBorderStyle.FixedDialog;
             this.StartPosition = FormStartPosition.CenterScreen;
         
            //Format controls. Note: Controls inherit color from parent form.
             this.btnAdd.BackColor = Color.Gray;
             this.btnAdd.Text = "Add";
             this.btnAdd.Location = new System.Drawing.Point(160, 25);
             this.btnAdd.Size = new System.Drawing.Size(100, 25);

           this.btnRemove.BackColor = Color.Gray;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Location = new System.Drawing.Point(265, 25);
            this.btnRemove.Size = new System.Drawing.Size(100, 25);
           
            this.txtBox.Text = "Text";
             this.txtBox.Location = new System.Drawing.Point(10, 25);
             this.txtBox.Size = new System.Drawing.Size(140, 20);
            
            this.lstBox.Items.Add("Hello World!");
             this.lstBox.Sorted = true;
             this.lstBox.Location = new System.Drawing.Point(10, 55);
             this.lstBox.Size = new System.Drawing.Size(200, 95);
            
            this.chkBox.Text = "Disable";
             this.chkBox.Location = new System.Drawing.Point(15, 190);
             this.chkBox.Size = new System.Drawing.Size(110, 30);
          
            this.lblCount.Text = lstBox.Items.Count.ToString() + " items";
             this.lblCount.Location = new System.Drawing.Point(55, 160);
             this.lblCount.Size = new System.Drawing.Size(65, 15);
             //Add controls to the form.
             this.Controls.Add(btnAdd);
             this.Controls.Add(txtBox);
             this.Controls.Add(lstBox);
             this.Controls.Add(chkBox);
             this.Controls.Add(lblCount);
        
    }
    }
}