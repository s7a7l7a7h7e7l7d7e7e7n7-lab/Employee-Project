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
    public partial class qiab : Form
    {
        public qiab()
        {
            InitializeComponent();
        }

        private void qiab_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dilowDataSet.qiab' table. You can move, or remove it, as needed.
            this.qiabTableAdapter.Fill(this.dilowDataSet.qiab);
            // TODO: This line of code loads data into the 'dilowDataSet.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter.Fill(this.dilowDataSet.emploee);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == true)
            { dataGridView1.Visible = false; }
            else
            {
                
                this.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t4.Text = "";
            try
            {
                t1.Text = (Convert.ToInt32(basic.choise("qiab", null, "max(qiab.abno)").Tables[0].Rows[0][0].ToString()) + 1).ToString();
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
                basic.save(" qiab ", t1.Text,
               (Convert.ToInt32(t0.SelectedIndex) + 1).ToString(),
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
                basic.edit(" qiab ", " qiab.abno = " + t1.Text + " AND " +
                  " qiab.empno = " + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString(),
                  " qiab.abday = " + basic.s + t2.Text + basic.s,
                  " qiab.abdate = " + basic.s + t3.Text + basic.s,
                  " qiab.note = " + basic.s + t4.Text + basic.s);
                
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
                basic.clear(" qiab ", "qiab.empno =" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString() + " AND " + "qiab.abno =" + t1.Text);
               
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
                ds = basic.choise("qiab ", new string[] {"qiab.abno=" + t1.Text + " AND " + " qiab.empno=" + (Convert.ToInt32(t0.SelectedIndex)+1).ToString() }, "*");
                t1.Text = ds.Tables[0].Rows[0][0].ToString();
                t0.Text = ds.Tables[0].Rows[0][1].ToString();
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

        private void b1_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t4.Text = "";
            t5.Visible = false;
            b1.Visible = false;
            b2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.qiabTableAdapter.Fill(this.dilowDataSet.qiab);
            this.emploeeTableAdapter.Fill(this.dilowDataSet.emploee);

            dataGridView1.Visible = true;
        }
    }
}
