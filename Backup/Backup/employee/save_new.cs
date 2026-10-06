using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace employee
{
    public partial class save_new : Form
    {
        public save_new()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else { button1.Enabled = false; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else { button1.Enabled = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            DialogResult ms;
            ms = MessageBox.Show(basic.boodysave, basic.titlesave, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.save(" loging ",

                basic.s + textBox1.Text + basic.s,
                basic.s + textBox2.Text + basic.s,
                basic.s + basic.namecom + basic.s, basic.s + basic.s);

            }

            else
            {
                MessageBox.Show(basic.boodysaveerr, basic.titlesaveerr);
                return;
            }
        }
    }
}
