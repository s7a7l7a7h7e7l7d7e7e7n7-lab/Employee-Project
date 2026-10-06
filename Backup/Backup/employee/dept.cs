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
    public partial class dept : Form
    {
        public dept()
        {
            InitializeComponent();
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

        private void b1_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t6.Text = "";
            
            b1.Visible = false;
            b2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t6.Text = "";
            try
            {
                t1.Text = (Convert.ToInt32(basic.choise("dept", null, "max(dept.sno)").Tables[0].Rows[0][0].ToString()) + 1).ToString();
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
                basic.save(" dept ", t1.Text,
                basic.s + t2.Text + basic.s,
               (Convert.ToInt32(t0.SelectedIndex) + 1).ToString(),
                basic.s + t6.Text + basic.s,
                t3.Text,
                basic.s + t4.Text + basic.s); dataGridView1.Refresh(); dataGridView1.RefreshEdit();
                
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
                basic.edit(" dept ", " dept.sno = " + t1.Text + " AND " +
                  " dept.empno = " + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString(),
                  " dept.sname = " + basic.s + t2.Text + basic.s,
                  " dept.wostime = " + t3.Text,
                  " dept.wotime = " + basic.s + t6.Text + basic.s,
                  " dept.note = " + basic.s + t4.Text + basic.s);
                
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
                basic.clear(" dept ", "dept.empno =" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString() + " AND " + "dept.sno =" + t1.Text);
               
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
                ds = basic.choise("dept ", new string[] { "dept.sno=" + t1.Text + " AND " + " dept.empno=" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString() }, "*");
                t1.Text = ds.Tables[0].Rows[0][0].ToString();
                t0.Text = ds.Tables[0].Rows[0][2].ToString();
                t2.Text = ds.Tables[0].Rows[0][1].ToString();
                t3.Text = ds.Tables[0].Rows[0][4].ToString();
                t6.Text = ds.Tables[0].Rows[0][3].ToString();
                t4.Text = ds.Tables[0].Rows[0][5].ToString();

                
                b2.Enabled = true;
                b1.Visible = true;
                b2.Enabled = false;



            }
            catch
            {

                MessageBox.Show(basic.boodyselect, basic.titleselect);
            }
        }

        private void dept_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dilowDataSet.dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.dilowDataSet.dept);
            // TODO: This line of code loads data into the 'dilowDataSet.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter.Fill(this.dilowDataSet.emploee);

        }

        private void عنالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {   this.deptTableAdapter.Fill(this.dilowDataSet.dept);
            this.emploeeTableAdapter.Fill(this.dilowDataSet.emploee);

            dataGridView1.Visible = true;
            
        }

        
    }
}
