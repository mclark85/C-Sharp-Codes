/* Matt Clark
 * 7/26/2020
 * Assignment 8.2
 * This program allows a user to guess a number from program while providing hints here and there.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment8_2
{
    public partial class Form1 : Form
    {
        int winner; 
        int guessRadio; 

        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            guessRadio = 1;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            Check();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            guessRadio = 2;
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            Check();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            guessRadio = 3;
            radioButton2.Enabled = false;
            radioButton1.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            Check();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            guessRadio = 4;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton1.Enabled = false;
            radioButton5.Enabled = false;
            Check();
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            guessRadio = 5;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton1.Enabled = false;
            Check();
        }

        private void Label1_MouseHover(object sender, EventArgs e)
        {
            Random rand = new Random();
            int hintNumber = rand.Next(1, 6);

            while (hintNumber == winner)
            {
                hintNumber = rand.Next(1, 6);
            }
            MessageBox.Show(hintNumber + "- This button is incorrect");

            if (hintNumber == 1)
            {
                radioButton1.Enabled = false;
            }
            if (hintNumber == 2)
            {
                radioButton2.Enabled = false;
            }
            if (hintNumber == 3)
            {
                radioButton3.Enabled = false;
            }
            if (hintNumber == 4)
            {
                radioButton4.Enabled = false;
            }
            if (hintNumber == 5)
            { 
                radioButton5.Enabled = false;
            }
            hint.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            winner = rand.Next(1, 7);
        }

        private void Check()
        {
            if (winner == guessRadio)
            {
                MessageBox.Show("Correct guess");
            }
            else
            {
                MessageBox.Show("Incorrect guess");
            }
        }
    }
}
