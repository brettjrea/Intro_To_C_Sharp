using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

namespace TicTacToe

{

    public partial class Form1 : Form

    {

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

            //Assign the each element in the gameboard array with 0 or 1 randomly

            int k = 0;

            for (int i = 0; i < 3; i++)

            {

                for (int j = 0; j < 3; j++)

                {

                    int rand = rnd.Next(0, 2);//generates 0 or 1

                    gameBoard[i, j] = rand;

                    //Display board

                    //Set the text of labels

                    if (gameBoard[i, j] == 0)

                        labels[k++].Text = "O";

                    else

                        labels[k++].Text = "X";

                }

            }

            //Check who win the game

            bool XWin = false;

            bool YWin = false;

            //Check rows

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

            //Check columns

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

            //Check diagnal

            if (gameBoard[0, 0] == 0 && gameBoard[1, 1] == 0 && gameBoard[2, 2] == 0)

            {

                YWin = true;

            }

            if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)

            {

                XWin = true;

            }

            //Display game result

            if (XWin != true && YWin != true)

                winLbl.Text = "Draw!";
               
            else if (XWin == true)
                winLbl.Text = "Player X won!";

            else if (YWin == true)
                winLbl.Text = "Player Y won!";

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }

}