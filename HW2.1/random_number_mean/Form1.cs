using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace univariant_distribution
{
    public partial class Form1 : Form
    {
        // Random object
        Random rd = new Random();
        // Variable that holds the actual mean
        double mid =0;
        // Variable that holds the actual generated number
        int rand_num = 0;
        // Counter for the number generated numbers
        long counter = 0;
        // Sum of the random generated numbers
        long sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // Start the generation of random numbers
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // Clear the board where actual mean and actual extraction of a random number are showed
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        // Generates a new number and does the actual mean
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            rand_num = rd.Next(0, 100);
            sum += rand_num;
            mid = sum / counter;
            richTextBox1.AppendText
                (
                "Generation no. " + counter.ToString() +
                ", generated number: " + rand_num.ToString() +
                ", new mean: " + mid.ToString() + "\n"
                );

        }

        // Stop the generation of random numbers
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();  
        }

        // Exit the program
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program generate a random number between 0 and 100 (extremes inclusive) and update the current mean.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
