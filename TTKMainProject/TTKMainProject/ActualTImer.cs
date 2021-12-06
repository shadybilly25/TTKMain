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
    public partial class ActualTImer : Form
    {
        float time = 0;
        public ActualTImer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time <= 0)
            {
                textBox1.Text = "0"; textBox1.BackColor = Color.Green;
                timer1.Enabled = false;
            }
            else
            {
                time -= 0.1f;
                textBox1.Text = time.ToString("0.0");

            }
           
        }
        private void startTimer()
        {
            try
            {
                time = float.Parse(textBox1.Text);
                timer1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Stinky billy boy", "get gud lmao");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            startTimer();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            time = 0;
            textBox1.Text = "0";
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startTimer();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            textBox1.Text = timer1.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            time += 300;
            textBox1.Text = time.ToString();
            timer1.Enabled = false;
        }
    }
}
