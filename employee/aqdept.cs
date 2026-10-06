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
    public partial class aqdept : Form
    {
        public aqdept()
        {
            InitializeComponent();
        }

        private void aqdept_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dilowDataSet.aqdept' table. You can move, or remove it, as needed.
            this.aqdeptTableAdapter.Fill(this.dilowDataSet.aqdept);
            // TODO: This line of code loads data into the 'dilowDataSet.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter.Fill(this.dilowDataSet.emploee);

        }

        private void b1_Click(object sender, EventArgs e)
        {

        }

        private void رجوعللرئيسيهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void رجوعللرئيسيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gr1.Visible == true)
            { gr1.Visible = false; }
            else
            {
                
                this.Hide();
            }
        }

        private void انهاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b1_Click_1(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t4.Text = "";
            t5.Visible = false;
            b1.Visible = false;
            b2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t4.Text = "";
            try
            {
                t1.Text = (Convert.ToInt32(basic.choise("aqdept", null, "max(aqdept.partno)").Tables[0].Rows[0][0].ToString()) + 1).ToString();
            }
            catch
            {
                t1.Text = "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(t1.Text) <= 0) { MessageBox.Show("ادخل قيمه اكبر من الصفر", "فشل"); return; }
            }
            catch { MessageBox.Show("يجب ان تكون القيمه من فئه الارقام", "فشل"); return; }

            DialogResult ms;
            ms = MessageBox.Show(basic.boodysave, basic.titlesave, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.save(" aqdept ", (Convert.ToInt32(t0.SelectedIndex) + 1).ToString(),
                t1.Text,
                basic.s + t2.Text + basic.s,
                basic.s + t3.Text + basic.s,
                basic.s + t4.Text + basic.s);
                
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
                basic.edit(" aqdept ", " aqdept.partno = " + t1.Text + " AND " +
                  " aqdept.empno = " + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString(),
                  " aqdept.spwork = " + basic.s + t2.Text + basic.s,
                  " aqdept.spswork = " + basic.s + t3.Text + basic.s,
                  " aqdept.note = " + basic.s + t4.Text + basic.s);
                
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
                basic.clear(" aqdept ", "aqdept.empno =" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString() + " AND " + "aqdept.partno =" + t1.Text);
                
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
                ds = basic.choise("aqdept ", new string[] { "aqdept.partno=" + t1.Text + " AND " + " aqdept.empno=" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString() }, "*");
                t1.Text = ds.Tables[0].Rows[0][1].ToString();
                t0.Text = ds.Tables[0].Rows[0][0].ToString();
                t2.Text = ds.Tables[0].Rows[0][2].ToString();
                t5.Text = ds.Tables[0].Rows[0][3].ToString();
                t4.Text = ds.Tables[0].Rows[0][4].ToString();

                t5.Visible = true;
                b2.Enabled = true;
                b1.Visible = true;
                b2.Enabled = false;



            }
            catch
            {

                MessageBox.Show(basic.boodyselect, basic.titleselect);
            }
        }

        private void عنالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {            this.aqdeptTableAdapter.Fill(this.dilowDataSet.aqdept);
                       this.emploeeTableAdapter.Fill(this.dilowDataSet.emploee);

            gr1.Visible = true;
        }

        
    }
}
