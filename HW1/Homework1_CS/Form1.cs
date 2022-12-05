using System;
using Microsoft.VisualBasic;

namespace Homework1_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int accumulator = 0;
        private string user = "guest";
     

        private void button3_Click(object sender, EventArgs e)
        {
            if (accumulator >= int.MinValue)
            {
                accumulator = accumulator - 1;
                label1.Text = accumulator.ToString();
            }
            else
                Interaction.MsgBox("Minumum number reached");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (accumulator <= int.MaxValue)
            {
                accumulator = accumulator + 1;
                label1.Text = accumulator.ToString();
            }
            else
                Interaction.MsgBox("Max number reached");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("Goodbye " + user);
            System.Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("Thank you!");
            user = textBox1.Text;
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    }
    }
}