namespace employee
{
    partial class dept
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dept));
            this.label6 = new System.Windows.Forms.Label();
            this.t6 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t0 = new System.Windows.Forms.ListBox();
            this.emploeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dilowDataSet = new employee.dilowDataSet();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.b2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.الرئيسيهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رجوعالىالرئيسيهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انهاءالبرنامجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انهاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعلامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عنالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emploeeTableAdapter = new employee.dilowDataSetTableAdapters.emploeeTableAdapter();
            this.t3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wotimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wostimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deptTableAdapter = new employee.dilowDataSetTableAdapters.deptTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "وقت العمل";
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(326, 157);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(97, 20);
            this.t6.TabIndex = 55;
            this.t6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(155, 276);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(363, 23);
            this.b1.TabIndex = 53;
            this.b1.Text = "انهاء البحث";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Visible = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "ملاحظه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "تاريخ بدء مزاوله العمل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "اسم الاداره";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "رقم الاداره";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "رقم الموظف";
            // 
            // t0
            // 
            this.t0.DataSource = this.emploeeBindingSource;
            this.t0.DisplayMember = "empno";
            this.t0.FormattingEnabled = true;
            this.t0.Location = new System.Drawing.Point(121, 49);
            this.t0.Name = "t0";
            this.t0.Size = new System.Drawing.Size(300, 30);
            this.t0.TabIndex = 47;
            // 
            // emploeeBindingSource
            // 
            this.emploeeBindingSource.DataMember = "emploee";
            this.emploeeBindingSource.DataSource = this.dilowDataSet;
            // 
            // dilowDataSet
            // 
            this.dilowDataSet.DataSetName = "dilowDataSet";
            this.dilowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(19, 182);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(404, 20);
            this.t4.TabIndex = 45;
            this.t4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(326, 109);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(97, 20);
            this.t2.TabIndex = 44;
            this.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(326, 83);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(97, 20);
            this.t1.TabIndex = 43;
            this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(19, 249);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(61, 23);
            this.b2.TabIndex = 42;
            this.b2.Text = "بحث";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(155, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "حذف";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "حفظ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "اضافه جديد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الرئيسيهToolStripMenuItem,
            this.انهاءالبرنامجToolStripMenuItem,
            this.استعلامToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الرئيسيهToolStripMenuItem
            // 
            this.الرئيسيهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.رجوعالىالرئيسيهToolStripMenuItem});
            this.الرئيسيهToolStripMenuItem.Name = "الرئيسيهToolStripMenuItem";
            this.الرئيسيهToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.الرئيسيهToolStripMenuItem.Text = "الرئيسيه";
            // 
            // رجوعالىالرئيسيهToolStripMenuItem
            // 
            this.رجوعالىالرئيسيهToolStripMenuItem.Name = "رجوعالىالرئيسيهToolStripMenuItem";
            this.رجوعالىالرئيسيهToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.رجوعالىالرئيسيهToolStripMenuItem.Text = "رجوع الى الرئيسيه";
            this.رجوعالىالرئيسيهToolStripMenuItem.Click += new System.EventHandler(this.رجوعالىالرئيسيهToolStripMenuItem_Click);
            // 
            // انهاءالبرنامجToolStripMenuItem
            // 
            this.انهاءالبرنامجToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.انهاءToolStripMenuItem});
            this.انهاءالبرنامجToolStripMenuItem.Name = "انهاءالبرنامجToolStripMenuItem";
            this.انهاءالبرنامجToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.انهاءالبرنامجToolStripMenuItem.Text = "انهاء البرنامج";
            // 
            // انهاءToolStripMenuItem
            // 
            this.انهاءToolStripMenuItem.Name = "انهاءToolStripMenuItem";
            this.انهاءToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.انهاءToolStripMenuItem.Text = "انهاء";
            this.انهاءToolStripMenuItem.Click += new System.EventHandler(this.انهاءToolStripMenuItem_Click);
            // 
            // استعلامToolStripMenuItem
            // 
            this.استعلامToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عنالكلToolStripMenuItem});
            this.استعلامToolStripMenuItem.Name = "استعلامToolStripMenuItem";
            this.استعلامToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.استعلامToolStripMenuItem.Text = "استعلام";
            // 
            // عنالكلToolStripMenuItem
            // 
            this.عنالكلToolStripMenuItem.Name = "عنالكلToolStripMenuItem";
            this.عنالكلToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.عنالكلToolStripMenuItem.Text = "عن الكل";
            this.عنالكلToolStripMenuItem.Click += new System.EventHandler(this.عنالكلToolStripMenuItem_Click);
            // 
            // emploeeTableAdapter
            // 
            this.emploeeTableAdapter.ClearBeforeFill = true;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(326, 133);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(97, 20);
            this.t3.TabIndex = 58;
            this.t3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.empnoDataGridViewTextBoxColumn,
            this.wotimeDataGridViewTextBoxColumn,
            this.wostimeDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deptBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(532, 291);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.Visible = false;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "رقم الاداره";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.snoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "اسم الاداره";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empnoDataGridViewTextBoxColumn
            // 
            this.empnoDataGridViewTextBoxColumn.DataPropertyName = "empno";
            this.empnoDataGridViewTextBoxColumn.HeaderText = "رقم الموظف";
            this.empnoDataGridViewTextBoxColumn.Name = "empnoDataGridViewTextBoxColumn";
            this.empnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wotimeDataGridViewTextBoxColumn
            // 
            this.wotimeDataGridViewTextBoxColumn.DataPropertyName = "wotime";
            this.wotimeDataGridViewTextBoxColumn.HeaderText = "وقت العمل";
            this.wotimeDataGridViewTextBoxColumn.Name = "wotimeDataGridViewTextBoxColumn";
            this.wotimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wostimeDataGridViewTextBoxColumn
            // 
            this.wostimeDataGridViewTextBoxColumn.DataPropertyName = "wostime";
            this.wostimeDataGridViewTextBoxColumn.HeaderText = "تاريخ بدء العمل";
            this.wostimeDataGridViewTextBoxColumn.Name = "wostimeDataGridViewTextBoxColumn";
            this.wostimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "ملاحظه";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deptBindingSource
            // 
            this.deptBindingSource.DataMember = "dept";
            this.deptBindingSource.DataSource = this.dilowDataSet;
            // 
            // deptTableAdapter
            // 
            this.deptTableAdapter.ClearBeforeFill = true;
            // 
            // dept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(532, 315);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t0);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dept";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشه ادخال بيانات الادارات";
            this.Load += new System.EventHandler(this.dept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox t0;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الرئيسيهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رجوعالىالرئيسيهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انهاءالبرنامجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انهاءToolStripMenuItem;
        private dilowDataSet dilowDataSet;
        private System.Windows.Forms.BindingSource emploeeBindingSource;
        private employee.dilowDataSetTableAdapters.emploeeTableAdapter emploeeTableAdapter;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.ToolStripMenuItem استعلامToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عنالكلToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private employee.dilowDataSetTableAdapters.deptTableAdapter deptTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wotimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wostimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}