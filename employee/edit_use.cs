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
    public partial class edit_use : Form
    {
        public edit_use()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show(basic.boodyupdate, basic.titleupdate, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.edit(" loging ", " loging.use= " + basic.s + basic.use + basic.s + " AND " + " loging.psw=" + basic.s + basic.psw + basic.s,
                  " loging.use = " + basic.s + textBox1.Text + basic.s,
                  " loging.psw = " + basic.s + textBox2.Text + basic.s,
                  " loging.namecom = " + basic.s + basic.namecom + basic.s);
                basic.use = textBox1.Text;
                basic.psw = textBox2.Text;
                new edit_use().Hide();
                this.Hide();

            }
            else
            {
                MessageBox.Show(basic.boodyupdateerr, basic.titleupdateerr);
                return;
            }
        }
    }
}
