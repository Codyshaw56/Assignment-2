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
            double RS1 = double.Parse(textBox1.Text);
            double RS2 = double.Parse(textBox2.Text);
            double RP1 = double.Parse(textBox3.Text);
            double RP2 = double.Parse(textBox4.Text);
            double RS1 = double.Parse(textBox5.Text);
            double RS2 = double.Parse(textBox6.Text);
            double RS3 = double.Parse(textBox7.Text);
            double RP1 = double.Parse(textBox8.Text);
            double RP2 = double.Parse(textBox9.Text);
            double RP3 = double.Parse(textBox10.Text);
        }
}
