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
    public partial class stupidBilly : Form
    {
        public stupidBilly()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (listBox1.Items.Count > 0)
            {
                int studentNum = rnd.Next(0, listBox1.Items.Count);
                textBox1.Text = listBox1.Items[studentNum].ToString();

                listBox1.Items.RemoveAt(studentNum);
            }
            else
            {
                MessageBox.Show("List is empty!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            /*
            listBox1.Items.Clear();
            foreach (string item in names)
            {
                listBox1.Items.Add(item);
                Console.WriteLine(item);
            }
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            foreach (string item in listBox1.Items)
            {
                names.Append(item);
            }
            */
        }
    }


}


