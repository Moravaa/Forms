using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtävä_8
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

        private void bt_arvoLuvut_Click(object sender, EventArgs e)
        {
            // Create an array to hold the numbers.
            const int SIZE = 9;
            int[] lotteryNumbers = new int[SIZE];

            // Create a Random object.
            Random rand = new Random();

            // Fill the array with random numbers, from 0 through 99.
            for (int index = 0; index < lotteryNumbers.Length; index++)
            {
                lotteryNumbers[index] = rand.Next(100);
            }

            // Display the array elements in the Label controls.
            label1.Text = lotteryNumbers[0].ToString();
            label2.Text = lotteryNumbers[1].ToString();
            label3.Text = lotteryNumbers[2].ToString();
            label4.Text = lotteryNumbers[3].ToString();
            label5.Text = lotteryNumbers[4].ToString();
            label6.Text = lotteryNumbers[5].ToString();
            label7.Text = lotteryNumbers[6].ToString();
            label8.Text = lotteryNumbers[7].ToString();
            label9.Text = lotteryNumbers[8].ToString();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
