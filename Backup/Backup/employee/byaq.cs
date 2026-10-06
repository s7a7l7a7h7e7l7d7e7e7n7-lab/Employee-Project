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
    public partial class byaq : Form
    {
        public byaq()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";


            b1.Visible = false;
            b2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";

            try
            {
                t0.Text = (Convert.ToInt32(basic.choise("byaq", null, "max(byaq.partno)").Tables[0].Rows[0][0].ToString()) + 1).ToString();
            }
            catch
            {
                t0.Text = "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(t0.Text) <= 0) { MessageBox.Show("ادخل قيمه اكبر من الصفر", "فشل"); return; }
            }
            catch { MessageBox.Show("يجب ان تكون القيمه من فئه الارقام", "فشل"); return; }

            DialogResult ms;
            ms = MessageBox.Show(basic.boodysave, basic.titlesave, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.save(" byaq ", t0.Text,
                basic.s + t1.Text + basic.s,
                basic.s + t2.Text + basic.s);
               
            }

            else
            {
                MessageBox.Show(basic.boodysaveerr, basic.titlesaveerr);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show(basic.boodyupdate, basic.titleupdate, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.edit(" byaq ", " byaq.partno = " + t0.Text,
                " byaq.partname = " + basic.s + t1.Text + basic.s,
                " byaq.not = " + basic.s + t2.Text + basic.s);
                
            }
            else
            {
                MessageBox.Show(basic.boodyupdateerr, basic.titleupdateerr);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show(basic.boodydelete, basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" byaq ", "byaq.partno =" + t0.Text);
               
            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);
                return;
            }

        }

        private void b2_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;
                ds = basic.choise("byaq ", new string[] { "byaq.partno=" + t0.Text }, "*");
                t1.Text = ds.Tables[0].Rows[0][1].ToString();
                t0.Text = ds.Tables[0].Rows[0][0].ToString();
                t2.Text = ds.Tables[0].Rows[0][2].ToString();

                b2.Enabled = true;
                b1.Visible = true;
                b2.Enabled = false;



            }
            catch
            {

                MessageBox.Show(basic.boodyselect, basic.titleselect);
            }
        }

        private void رجوعالىالرئيسيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == true)
            { dataGridView1.Visible = false; }
            else
            {
                
                this.Hide();
            }
        }

        private void انهاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void byaq_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dilowDataSet.byaq' table. You can move, or remove it, as needed.
            this.byaqTableAdapter.Fill(this.dilowDataSet.byaq);

        }

        private void عنالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {            this.byaqTableAdapter.Fill(this.dilowDataSet.byaq);

            dataGridView1.Visible = true;
        }

        
    }
}
