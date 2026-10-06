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
    public partial class emploee : Form
    {
        public emploee()
        {
            InitializeComponent();
        }

        private void emploee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dilowDataSet.emploee' table. You can move, or remove it, as needed.

        }

        

       

       

        private void عودهللرئيسيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void انهاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t0.Text = ""; t7.Text = "";
            t1.Text = ""; t8.Text = "";
            t2.Text = ""; t10.Text = "";
            t3.Text = ""; t11.Text = "";
            t5.Text = ""; t13.Text = "";
            t6.Text = ""; t14.Text = "";

            try
            {
                t0.Text = (Convert.ToInt32(basic.choise("emploee", null, "max(emploee.empno)").Tables[0].Rows[0][0].ToString()) + 1).ToString();
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
                basic.save(" emploee ", t0.Text,
               basic.s + t1.Text + basic.s, basic.s + t2.Text + basic.s, basic.s + t3.Text + basic.s,
               basic.s + t4.Text + basic.s, basic.s + t5.Text + basic.s, basic.s + t6.Text + basic.s,
               basic.s + t7.Text + basic.s, basic.s + t8.Text + basic.s, basic.s + t9.Text + basic.s,
               basic.s + t10.Text + basic.s, basic.s + t11.Text + basic.s, basic.s + t12.Text + basic.s,
               basic.s + t13.Text + basic.s, basic.s + t14.Text + basic.s
                );
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
                basic.edit(" emploee ", " emploee.empno = " + t0.Text ,
               " emploee.empname = " + basic.s + t1.Text + basic.s, " emploee.sex = " + basic.s + t2.Text + basic.s,
               " emploee.nationality = " + basic.s + t3.Text + basic.s, " emploee.pdate = " + basic.s + t4.Text + basic.s,
               " emploee.social = " + basic.s + t5.Text + basic.s, " emploee.address = " + basic.s + t6.Text + basic.s,
               " emploee.telno = " + basic.s + t7.Text + basic.s, " emploee.qual = " + basic.s + t8.Text + basic.s,
               " emploee.gdate = " + basic.s + t9.Text + basic.s, " emploee.dono = " + basic.s + t10.Text + basic.s,
               " emploee.dotype = " + basic.s + t11.Text + basic.s, " emploee.dodate = " + basic.s + t12.Text + basic.s,
               " emploee.doplace = " + basic.s + t13.Text + basic.s, " emploee.note = " + basic.s + t14.Text + basic.s);

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
                basic.clear(" emploee ", "emploee.empno =" +  t0.Text);

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
                ds = basic.choise("emploee ", new string[] { "emploee.empno=" + t0.Text  }, "*");
                t1.Text = ds.Tables[0].Rows[0][1].ToString();
                t2.Text = ds.Tables[0].Rows[0][2].ToString();
                t3.Text = ds.Tables[0].Rows[0][3].ToString();
                td1.Text = ds.Tables[0].Rows[0][4].ToString();
                t5.Text = ds.Tables[0].Rows[0][5].ToString();
                t6.Text = ds.Tables[0].Rows[0][6].ToString();
                t7.Text = ds.Tables[0].Rows[0][7].ToString();
                t8.Text = ds.Tables[0].Rows[0][8].ToString();
                td2.Text = ds.Tables[0].Rows[0][9].ToString();
                t10.Text = ds.Tables[0].Rows[0][10].ToString();
                t11.Text = ds.Tables[0].Rows[0][11].ToString();
                td3.Text = ds.Tables[0].Rows[0][12].ToString();
                t13.Text = ds.Tables[0].Rows[0][13].ToString();
                t14.Text = ds.Tables[0].Rows[0][14].ToString();


                td1.Visible = true;
                td2.Visible = true;
                td3.Visible = true;
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
            t0.Text = ""; t7.Text = "";
            t1.Text = ""; t8.Text = "";
            t2.Text = ""; t10.Text = "";
            t3.Text = ""; t11.Text = "";
            t5.Text = ""; t13.Text = "";
            t6.Text = ""; t14.Text = "";

            td1.Visible = false;
            td2.Visible = false;
            td3.Visible = false;
            b1.Visible = false;
            b2.Enabled = true;
        }

        

       
    }
}
