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
    public partial class Form1 : Form
    {
        int stuff = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            TimerForm timerform = new TimerForm();
            timerform.Show();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stuff++;
            if (stuff > 2000) 
            {
                timer1.Enabled = false;
            }
            timerButton.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stupidBilly PickerForm = new stupidBilly();
            PickerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dice Dice = new Dice();
            Dice.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualTImer timerform = new ActualTImer();
            timerform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
