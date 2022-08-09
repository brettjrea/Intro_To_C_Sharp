using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String str;
        int max_val = 0, max_index = 0, vow_count = 0, vow_index;

        private void mostVwls_Click(object sender, EventArgs e)
        {

        }

        private void longestWrd_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //here we can see the open file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //string is all text from open file dialog box
                str = System.IO.File.ReadAllText(openFileDialog.FileName); 

                //display text from string as a lowercase
                lowerCaseTxtBox.Text = str.ToLower();

                //convert the string of text into an array using space as a delimiter
                string[] array = str.Split(' ');

                //show the first item of the array as the first word
                firstWordTxtBox.Text = array[0];

                //show the last item of the array as the last word
                lastWordTxtBox.Text = array[array.Length - 1];

                //create a loop of the array to find longest word and word with most vowels.
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (max_val < array[i].Length)
                    {
                        max_val = array[i].Length;
                        max_index = i;
                    }

                    if (vow_count < CountVowels(array[i]))
                    {
                        vow_count = CountVowels(array[i]);
                        vow_index = i;
                    }
                }
                //assign longest text by plugging in index
                longestWordTxtBox.Text = array[max_index];

                //assign word with most vowels by plugging in index
                mostVowels.Text = array[vow_index];


                //Write results to a file
                StreamWriter sw = new StreamWriter(Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName,"Results.txt"));

                //Write results line by line
                sw.WriteLine("String of text converted to lowercase ::" + lowerCaseTxtBox.Text);
                sw.WriteLine("The first Word found is ::" + firstWordTxtBox.Text);
                sw.WriteLine("The last Word found is ::" + lastWordTxtBox.Text);
                sw.WriteLine("The longest Word found is ::" + longestWordTxtBox.Text);
                sw.WriteLine("The word with the most vowels is ::" + mostVowels.Text);
                sw.Close();

                //Message box confirming results have been written to file.
                MessageBox.Show("Results have been written to Results.txt");
            }

        }

        //function that counts the vowels in a word and returns the word with the most
        public int CountVowels(string word)
        {
            int vowels = 0;
            for (int i = 0; i < word.Length - 1; i++)
            {
                if ((word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u') || (word[i] == 'A' || word[i] == 'E' || word[i] ==
                'I' || word[i] == 'O' || word[i] == 'U'))
                {
                    vowels = vowels + 1;
                }

            }
            return vowels;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}



