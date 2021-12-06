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
    public partial class TimerForm : Form
    {
        float countDown = 3000;
        float timer = 0;
        public TimerForm()
        {
            InitializeComponent();
        }

        
       



        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            countDown -= timer1.Interval;
            //textBox4.Text = rnd.Next(1, 201).ToString();

            if (countDown < 0)
            {

                //textBox4.BackColor = Color.HotPink;
                countDown = 3000;
                timer1.Enabled = false;

            }
        }

        private void button5_Click(object sender, EventArgs e) => timer2.Enabled = true;

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer += timer2.Interval * 0.001f;
            textBox5.Text = " " + timer.ToString("0.0");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
