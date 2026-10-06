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
    public partial class fo_desp : Form
    {
        public fo_desp()
        {
            InitializeComponent();
        }

        private void fo_desp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dilowDataSet.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter.Fill(this.dilowDataSet.emploee);
            // TODO: This line of code loads data into the 'dilowDataSet.emploee' table. You can move, or remove it, as needed.

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع استحقاقات الموظف رقم" + (Convert.ToInt32(t0.SelectedIndex)+1), basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" asce ", "asce.empno =" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString());
                
            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع اجازات الموظف رقم" + (Convert.ToInt32(t0.SelectedIndex) + 1), basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" agez ", "agez.empno =" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString());
                
            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);

                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع غياب الموظف رقم" + (Convert.ToInt32(t0.SelectedIndex) + 1), basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" qiab ", "qiab.empno =" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString());
                
            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);

                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع انذارات الموظف رقم" + (Convert.ToInt32(t0.SelectedIndex) + 1), basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" anth ", "anth.empno =" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString());
                
            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);

                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع جزاءات الموظف رقم" + (Convert.ToInt32(t0.SelectedIndex) + 1), basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" gaza ", "gaza.empno =" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString());
                
            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);

                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع اضافي الموظف رقم" + (Convert.ToInt32(t0.SelectedIndex) + 1), basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" athaf ", "athaf.empno =" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString());
                
            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);

                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع خصومات الموظف رقم" + (Convert.ToInt32(t0.SelectedIndex) + 1), basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" ksm ", "ksm.empno =" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString());
                
            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);

                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع فصل الموظف رقم" + (Convert.ToInt32(t0.SelectedIndex) + 1), basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" fsl ", "fsl.empno =" + (Convert.ToInt32(t0.SelectedIndex) + 1).ToString());
                
            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);

                return;
            }
        }

        

        private void button11_Click_1(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد بالفعل حذف جميع بيانات الموظفين في كل الاقسام" , basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clearall(" tydept ", " dept ", " aqdept ", " byaq ", " asce ", " agez ", " qiab ", " anth ", " gaza ", " athaf ", " ksm ", " fsl ");

            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);

                return;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع الاستحقاقات لكل الموظفين" , basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" asce ",null);

            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);
                return;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع الاجازات لكل المظفين" , basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" agez ",null);

            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);
                return;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع الغياب لكل الموظفين" , basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" qiab ",null);

            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);
                return;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع الانذارت لكل الموظفين" , basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" anth ", null);

            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);
                return;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع الجزاءات لكل الموظفين" , basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" gaza ", null);

            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);
                return;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع الاضافي لكل الموظفين" , basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" athaf ", null);

            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);
                return;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع الخصم لكل الموظفين" , basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" ksm ", null);

            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);
                return;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع الفصل لكل الموظفين" , basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" fsl ", null);

            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);
                return;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            ms = MessageBox.Show("هل تريد حذف جميع الموظفين المسجلين حالياً في قسم الموظفين", basic.titledelete, MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                basic.clear(" emploee ", null);

            }
            else
            {
                MessageBox.Show(basic.boodydeleteerr, basic.titledeleteerr);
                return;
            }
        }
    }
}
