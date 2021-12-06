using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTKMainProject
{
    public partial class Dice : Form
    {
        float countDown = 3000;
        float timer = 0;
        public Dice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = rnd.Next(1, 10 + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = rnd.Next(1, 20 + 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = rnd.Next(1, 100 + 1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            countDown -= timer1.Interval;
            textBox1.Text = rnd.Next(1, 201).ToString();

            if (countDown < 0)
            {

                textBox1.BackColor = Color.HotPink;
                countDown = 3000;
                timer1.Enabled = false;
            }
        }
    }
}

