using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volumes
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double RS1, RS2;
            try
            {
                RS1 = double.Parse(textBox1.Text);
                RS2 = double.Parse(textBox2.Text);
                //reading text from textboxes
            }
            catch
            {
                MessageBox.Show("stop right there bromigo");
                RS1 = 0.0;
                RS2 = 0.0;
                //catching errors
            }

            double RT1 = RS1 + RS2;
            //calculate series resistance
            textBox14.AppendText(RT1.ToString());
            //show solution in text box

        }


        private void Button2_Click(object sender, EventArgs e)
        {
            double RP1, RP2;
            try
            {
                RP1 = double.Parse(textBox3.Text);
                RP2 = double.Parse(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("stop right there bromigo");
                RP1 = 0.0;
                RP2 = 0.0;
            }

            double RT2 = 1.0 / ((1.0 / RP1) + (1.0 / RP2));
            textBox15.AppendText(RT2.ToString());


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double RS1, RS2, RS3;
            try
            {
                RS1 = double.Parse(textBox5.Text);
                RS2 = double.Parse(textBox6.Text);
                RS3 = double.Parse(textBox7.Text);
                
            }
            catch
            {
                MessageBox.Show("stop right there bromigo");
                RS1 = 0.0;
                RS2 = 0.0;
                RS3 = 0.0;
            }

            double RT3 = RS1 + RS2 + RS3;
            textBox16.AppendText(RT3.ToString());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double RP1, RP2, RP3;
            try
            {
                RP1 = double.Parse(textBox8.Text);
                RP2 = double.Parse(textBox9.Text);
                RP3 = double.Parse(textBox10.Text);
            }
            catch
            {
                MessageBox.Show("stop right there bromigo");
                RP1 = 0.0;
                RP2 = 0.0;
                RP3 = 0.0;
            }

            double RT4 = 1.0 / ((1.0 / RP1) + (1.0 / RP2) + (1.0 / RP3));
            textBox17.AppendText(RT4.ToString());
           
            // i started with the series because addition was in my case much easier to code and 
        }
    }
}

    
      


    




