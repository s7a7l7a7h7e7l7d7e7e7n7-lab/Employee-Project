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
    public partial class tool_psw : Form
    {
        public tool_psw()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new edit_use().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new save_new().ShowDialog();
        }

        private void tool_psw_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dilowDataSet.loging' table. You can move, or remove it, as needed.
            this.logingTableAdapter.Fill(this.dilowDataSet.loging);
            l1.Text = basic.use; l2.Text = basic.psw;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show(basic.boodyupdate, basic.titleupdate, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.edit(" loging ",null,
                  " loging.namecom = " + basic.s + textBox1.Text + basic.s);
                basic.namecom = textBox1.Text;
                  
            }
            else
            {
                MessageBox.Show(basic.boodyupdateerr, basic.titleupdateerr);
                return;
            }
        }

       
    }
}
