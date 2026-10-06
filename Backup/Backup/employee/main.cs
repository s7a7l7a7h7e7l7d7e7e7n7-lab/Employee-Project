using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace employee
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void انهاءالنظامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void الغيابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new qiab().ShowDialog();
            
        }

        private void الانذاراتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new anth().ShowDialog();
            
        }

        private void الاجازاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new agez().ShowDialog();
            
        }

        private void الاضافيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new athaf().ShowDialog();
            

        }

        private void الخصمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ksm().ShowDialog();
            
        }

        private void الجزاءاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new gaza().ShowDialog();
            
        }

        private void الاستحقاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new asce().ShowDialog();
           
        }

        private void الموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new emploee().ShowDialog();
            
        }

        private void الاداراتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new dept().ShowDialog();
            
        }

       

        private void اقسامالاداراتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new aqdept().ShowDialog();
            
        }

        private void بيانالاقسامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new byaq().ShowDialog();
            
        }

        private void ذهابالىالشاشهالفرعيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fo_desp().ShowDialog();
           
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label5.Text =Convert.ToString( dt );

        }

        

        private void الاستحقاقToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          string val = Microsoft.VisualBasic.Interaction.InputBox(
          "ادخل من فضلك رقم الموظف", 
          "ادخل رقم الموظف الذي تريد تقرير عنه", "1", -1, -1);
          
          
        }

        private void الاجازاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string val = Microsoft.VisualBasic.Interaction.InputBox(
             "ادخل من فضلك رقم الموظف",
             "ادخل رقم الموظف الذي تريد تقرير عنه", "1", -1, -1);
            
        }

        private void الغيابToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string val = Microsoft.VisualBasic.Interaction.InputBox(
             "ادخل من فضلك رقم الموظف",
             "ادخل رقم الموظف الذي تريد تقرير عنه", "1", -1, -1);
            
        }

        private void الانذاراتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string val = Microsoft.VisualBasic.Interaction.InputBox(
             "ادخل من فضلك رقم الموظف",
             "ادخل رقم الموظف الذي تريد تقرير عنه", "1", -1, -1);
            

        }

        private void الاضافيToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string val = Microsoft.VisualBasic.Interaction.InputBox(
             "ادخل من فضلك رقم الموظف",
             "ادخل رقم الموظف الذي تريد تقرير عنه", "1", -1, -1);
            
        }

        private void الخصمToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string val = Microsoft.VisualBasic.Interaction.InputBox(
             "ادخل من فضلك رقم الموظف",
             "ادخل رقم الموظف الذي تريد تقرير عنه", "1", -1, -1);
            

        }

        private void الفصلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string val = Microsoft.VisualBasic.Interaction.InputBox(
             "ادخل من فضلك رقم الموظف",
             "ادخل رقم الموظف الذي تريد تقرير عنه", "1", -1, -1);
            

        }

        private void الفصلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fsl().ShowDialog();

        }

        private void ضبــــــطالاعداداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new tool_psw().ShowDialog();
        }

        
    }
}
