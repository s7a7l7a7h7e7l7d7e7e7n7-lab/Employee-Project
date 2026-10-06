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
    public partial class enter : Form
    {
        public enter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;

                ds = basic.choise("loging ", new string[] { "loging.use=" + basic.s + textBox2.Text + basic.s + " AND " + " loging.psw=" + basic.s + textBox3.Text + basic.s }, "*");
                basic.psw = ds.Tables[0].Rows[0][1].ToString();
                basic.use = ds.Tables[0].Rows[0][0].ToString();
                basic.namecom = ds.Tables[0].Rows[0][2].ToString();
                new main().Show();
                this.Hide();
            }catch   
            {
                
                MessageBox.Show("لايمكنك الدخول المعلومات المدخله غير صحيحه", "خطأ");
  
            }
            //if (textBox3.Text == "information" && textBox2.Text == "data")
            //{
            //    new main().Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("لايمكنك الدخول المعلومات المدخله غير صحيحه", "خطأ");
            //}
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                button1.Enabled = true;
            }
            else { button1.Enabled = false; }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else { button1.Enabled = false; }
        }

        private void enter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dilowDataSet.loging' table. You can move, or remove it, as needed.
            this.logingTableAdapter.Fill(this.dilowDataSet.loging);

        }

       

             
    }
}
