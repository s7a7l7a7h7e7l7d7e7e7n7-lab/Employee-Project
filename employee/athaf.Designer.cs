namespace employee
{
    partial class athaf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(athaf));
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
            this.عودهللرئيسيهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انهاءالبرنامجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انهاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعلاماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عنالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emploeeTableAdapter = new employee.dilowDataSetTableAdapters.emploeeTableAdapter();
            this.t3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plusnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plushourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plustypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athafBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athafTableAdapter = new employee.dilowDataSetTableAdapters.athafTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athafBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(144, 237);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(363, 23);
            this.b1.TabIndex = 35;
            this.b1.Text = "انهاء البحث";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Visible = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "ملاحظه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "نوع الاضافي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "ساعات الاضافي";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "رقم الاضافي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "رقم الموظف";
            // 
            // t0
            // 
            this.t0.DataSource = this.emploeeBindingSource;
            this.t0.DisplayMember = "empno";
            this.t0.FormattingEnabled = true;
            this.t0.Location = new System.Drawing.Point(130, 44);
            this.t0.Name = "t0";
            this.t0.Size = new System.Drawing.Size(300, 30);
            this.t0.TabIndex = 28;
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
            this.t4.Location = new System.Drawing.Point(4, 169);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(428, 20);
            this.t4.TabIndex = 26;
            this.t4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(335, 109);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(97, 20);
            this.t2.TabIndex = 25;
            this.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(335, 83);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(97, 20);
            this.t1.TabIndex = 24;
            this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(8, 236);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(61, 23);
            this.b2.TabIndex = 23;
            this.b2.Text = "بحث";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(144, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "حذف";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "حفظ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "اضافه جديد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الرئيسيهToolStripMenuItem,
            this.انهاءالبرنامجToolStripMenuItem,
            this.استعلاماتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الرئيسيهToolStripMenuItem
            // 
            this.الرئيسيهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عودهللرئيسيهToolStripMenuItem});
            this.الرئيسيهToolStripMenuItem.Name = "الرئيسيهToolStripMenuItem";
            this.الرئيسيهToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.الرئيسيهToolStripMenuItem.Text = "الرئيسيه";
            // 
            // عودهللرئيسيهToolStripMenuItem
            // 
            this.عودهللرئيسيهToolStripMenuItem.Name = "عودهللرئيسيهToolStripMenuItem";
            this.عودهللرئيسيهToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.عودهللرئيسيهToolStripMenuItem.Text = "عوده للرئيسيه";
            this.عودهللرئيسيهToolStripMenuItem.Click += new System.EventHandler(this.عودهللرئيسيهToolStripMenuItem_Click);
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
            this.انهاءToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.انهاءToolStripMenuItem.Text = "انهاء ";
            this.انهاءToolStripMenuItem.Click += new System.EventHandler(this.انهاءToolStripMenuItem_Click);
            // 
            // استعلاماتToolStripMenuItem
            // 
            this.استعلاماتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عنالكلToolStripMenuItem});
            this.استعلاماتToolStripMenuItem.Name = "استعلاماتToolStripMenuItem";
            this.استعلاماتToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.استعلاماتToolStripMenuItem.Text = "استعلامات";
            // 
            // عنالكلToolStripMenuItem
            // 
            this.عنالكلToolStripMenuItem.Name = "عنالكلToolStripMenuItem";
            this.عنالكلToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.عنالكلToolStripMenuItem.Text = "عن الكل";
            this.عنالكلToolStripMenuItem.Click += new System.EventHandler(this.عنالكلToolStripMenuItem_Click);
            // 
            // emploeeTableAdapter
            // 
            this.emploeeTableAdapter.ClearBeforeFill = true;
            // 
            // t3
            // 
            this.t3.FormattingEnabled = true;
            this.t3.Items.AddRange(new object[] {
            "عادي ",
            "اجباري"});
            this.t3.Location = new System.Drawing.Point(261, 138);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(171, 21);
            this.t3.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empnoDataGridViewTextBoxColumn,
            this.plusnoDataGridViewTextBoxColumn,
            this.plushourDataGridViewTextBoxColumn,
            this.plustypeDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.athafBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(518, 245);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.Visible = false;
            // 
            // empnoDataGridViewTextBoxColumn
            // 
            this.empnoDataGridViewTextBoxColumn.DataPropertyName = "empno";
            this.empnoDataGridViewTextBoxColumn.HeaderText = "رقم الموظف";
            this.empnoDataGridViewTextBoxColumn.Name = "empnoDataGridViewTextBoxColumn";
            this.empnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plusnoDataGridViewTextBoxColumn
            // 
            this.plusnoDataGridViewTextBoxColumn.DataPropertyName = "plusno";
            this.plusnoDataGridViewTextBoxColumn.HeaderText = "رقم الاضافي";
            this.plusnoDataGridViewTextBoxColumn.Name = "plusnoDataGridViewTextBoxColumn";
            this.plusnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plushourDataGridViewTextBoxColumn
            // 
            this.plushourDataGridViewTextBoxColumn.DataPropertyName = "plushour";
            this.plushourDataGridViewTextBoxColumn.HeaderText = "ساعات الاضافي";
            this.plushourDataGridViewTextBoxColumn.Name = "plushourDataGridViewTextBoxColumn";
            this.plushourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plustypeDataGridViewTextBoxColumn
            // 
            this.plustypeDataGridViewTextBoxColumn.DataPropertyName = "plustype";
            this.plustypeDataGridViewTextBoxColumn.HeaderText = "نوع الاضافي";
            this.plustypeDataGridViewTextBoxColumn.Name = "plustypeDataGridViewTextBoxColumn";
            this.plustypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "ملاحظه";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // athafBindingSource
            // 
            this.athafBindingSource.DataMember = "athaf";
            this.athafBindingSource.DataSource = this.dilowDataSet;
            // 
            // athafTableAdapter
            // 
            this.athafTableAdapter.ClearBeforeFill = true;
            // 
            // athaf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(518, 270);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.t3);
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
            this.Name = "athaf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشه ادخال بيانات الاضافي";
            this.Load += new System.EventHandler(this.athaf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athafBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStripMenuItem عودهللرئيسيهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انهاءالبرنامجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انهاءToolStripMenuItem;
        private dilowDataSet dilowDataSet;
        private System.Windows.Forms.BindingSource emploeeBindingSource;
        private employee.dilowDataSetTableAdapters.emploeeTableAdapter emploeeTableAdapter;
        private System.Windows.Forms.ComboBox t3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource athafBindingSource;
        private employee.dilowDataSetTableAdapters.athafTableAdapter athafTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plusnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plushourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plustypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem استعلاماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عنالكلToolStripMenuItem;
    }
}