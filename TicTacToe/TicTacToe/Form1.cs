using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe

{

    public partial class Form1 : Form
    {
        //Decalare our arrays.
        public int[,] gameBoard = new int[3, 3];
        public Label[] labels = new Label[9];

        public Form1()

        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Instantiate 9 labels and set ther postion in the form
            //and add them to form1
            for (int i = 0; i < 9; i++)
            {
                labels[i] = new Label();
                labels[i].Location = new Point((i / 3) * 100 + 40, (i % 3) * 50 + 50);
                labels[i].Text = "-";
                labels[i].BorderStyle = BorderStyle.Fixed3D;
                labels[i].Padding = new Padding(10, 10, 10, 10);
                labels[i].Height = 40;
                labels[i].Width = 50;
                labels[i].TextAlign = ContentAlignment.MiddleCenter;

                this.Controls.Add(labels[i]);
            }
        }

        private void newGame_Click(object sender, EventArgs e)

        {
            //create random object
            Random rnd = new Random();

            //K is the total 9 moves and will be counted as each box is labeled.
            int k = 0;
            //Rows loop
            for (int i = 0; i < 3; i++)
            {
                //Columns loop
                for (int j = 0; j < 3; j++)
                {
                    //Use random object to make next the number a 0 or 1.
                    int rand = rnd.Next(0, 2);

                    //Assign the next gameboard that random 0 or 1.
                    gameBoard[i, j] = rand;

                    //If the gameboard was assigned 0 mark a O else an X.
                    if (gameBoard[i, j] == 0)

                        //This is where the label is made and K is added up.
                        labels[k++].Text = "O";
                    else

                        labels[k++].Text = "X";
                }
            }

            //Make sure the x and y wins are initially set to false.
            bool XWin = false;
            bool YWin = false;

            //Create static columns and iterate the rows top to bottom to see if any rows are three of a kind.
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, 0] == 0 && gameBoard[i, 1] == 0 && gameBoard[i, 2] == 0)
                {
                    YWin = true;
                }

                if (gameBoard[i, 0] == 1 && gameBoard[i, 1] == 1 && gameBoard[i, 2] == 1) 
                {
                    XWin = true;
                }

            }

            //Create static Rows and iterate the columns left to right to see if any columns are three of a kind.
            for (int i = 0; i < 3; i++)
            {
            if (gameBoard[0, i] == 0 && gameBoard[1, i] == 0 && gameBoard[2, i] == 0)
            {
                YWin = true;
            }

            if (gameBoard[0, i] == 1 && gameBoard[1, i] == 1 && gameBoard[2, i] == 1)
            {
                XWin = true;
            }
            }

            //Create static rows and columns to make a step pattern from top left to bottom right.
            if (gameBoard[0, 0] == 0 && gameBoard[1, 1] == 0 && gameBoard[2, 2] == 0)
            {
                YWin = true;
            }

            if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)
            {
                XWin = true;
            }
            //Create static rows and columns to make a step pattern from top right to bottom left.
            if (gameBoard[0, 2] == 0 && gameBoard[1, 1] == 0 && gameBoard[2, 0] == 0)
            {
                YWin = true;
            }

            if (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1)
            {
                XWin = true;
            }


            //Interpret the results and display.
            if (XWin != true && YWin != true || XWin == true && YWin == true)
                winLbl.Text = "Draw!";

            else if (XWin == true)
                winLbl.Text = "Player X won!";

            else if (YWin == true)
                winLbl.Text = "Player Y won!";

             }
            //Exit Button
            private void exitButton_Click(object sender, EventArgs e)
            {
                // Close the form.
                this.Close();
            }
    }
}