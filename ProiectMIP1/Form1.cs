using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectMIP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult r = MessageBox.Show("Fel gomb", "UP",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            textBox1.Text = r.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Le gomb", "DOWN",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            textBox1.Text = r.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Balra gomb", "LEFT",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            textBox1.Text = r.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Jobbra gomb", "RIGHT",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            textBox1.Text = r.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
    }
}
