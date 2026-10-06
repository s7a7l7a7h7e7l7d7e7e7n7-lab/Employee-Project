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
    public partial class anth : Form
    {
        public anth()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (gr1.Visible == true)
            { gr1.Visible = false; }
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
                t1.Text = (Convert.ToInt32(basic.choise("anth", null, "max(anth.warno)").Tables[0].Rows[0][0].ToString()) + 1).ToString();
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
                basic.save(" anth ", t1.Text,
               (Convert.ToInt32(t0.SelectedIndex) + 1).ToString(),
                basic.s + t3.Text + basic.s,
                basic.s + t2.Text + basic.s,
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
                basic.edit(" anth ", " anth.warno = " + t1.Text + " AND " +
                  " anth.empno = " + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString(),
                  " anth.warbecuse = " + basic.s + t2.Text + basic.s,
                  " anth.wardate = " + basic.s + t3.Text + basic.s,
                  " anth.note = " + basic.s + t4.Text + basic.s);
                
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
                basic.clear(" anth ", "anth.empno =" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString() + " AND " + "anth.warno =" + t1.Text);
               
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
                ds = basic.choise("anth ", new string[] { "anth.warno=" + t1.Text + " AND " + " anth.empno=" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString() }, "*");
                t1.Text = ds.Tables[0].Rows[0][0].ToString();
                t0.Text = ds.Tables[0].Rows[0][1].ToString();
                t5.Text = ds.Tables[0].Rows[0][2].ToString();
                t2.Text = ds.Tables[0].Rows[0][3].ToString();
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

        

        private void anth_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dilowDataSet.anth' table. You can move, or remove it, as needed.
            this.anthTableAdapter.Fill(this.dilowDataSet.anth);
            // TODO: This line of code loads data into the 'dilowDataSet.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter.Fill(this.dilowDataSet.emploee);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.anthTableAdapter.Fill(this.dilowDataSet.anth);
            this.emploeeTableAdapter.Fill(this.dilowDataSet.emploee);

            gr1.Visible = true;
        }

        
    }
}
