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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fel gomb", "UP",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le gomb", "DOWN",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Balra gomb", "LEFT",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jobbra gomb", "RIGHT",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
        }
    }
}
