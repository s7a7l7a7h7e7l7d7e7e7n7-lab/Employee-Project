namespace employee
{
    partial class asce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(asce));
            this.t3 = new System.Windows.Forms.TextBox();
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
            this.emploeeTableAdapter = new employee.dilowDataSetTableAdapters.emploeeTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.الرئيسيهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ذهابالىالرئيسيهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعلاماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عنالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انهاءالبرنامجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انهاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gr1 = new System.Windows.Forms.DataGridView();
            this.msnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apphomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asceTableAdapter = new employee.dilowDataSetTableAdapters.asceTableAdapter();
            this.emploeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(340, 131);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(97, 20);
            this.t3.TabIndex = 35;
            this.t3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(149, 210);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(363, 23);
            this.b1.TabIndex = 34;
            this.b1.Text = "انهاء البحث";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Visible = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "ملاحظه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "الراتب الاساسي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "بدل السكن";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "رقم الاستحقاق";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "رقم الموظف";
            // 
            // t0
            // 
            this.t0.DataSource = this.emploeeBindingSource1;
            this.t0.DisplayMember = "empno";
            this.t0.FormattingEnabled = true;
            this.t0.Location = new System.Drawing.Point(230, 41);
            this.t0.Name = "t0";
            this.t0.Size = new System.Drawing.Size(205, 30);
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
            this.t4.Location = new System.Drawing.Point(9, 155);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(428, 20);
            this.t4.TabIndex = 26;
            this.t4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(340, 106);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(97, 20);
            this.t2.TabIndex = 25;
            this.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(340, 80);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(97, 20);
            this.t1.TabIndex = 24;
            this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(13, 209);
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
            this.button4.Location = new System.Drawing.Point(149, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "حذف";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(230, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "حفظ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "اضافه جديد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emploeeTableAdapter
            // 
            this.emploeeTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الرئيسيهToolStripMenuItem,
            this.استعلاماتToolStripMenuItem,
            this.انهاءالبرنامجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الرئيسيهToolStripMenuItem
            // 
            this.الرئيسيهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ذهابالىالرئيسيهToolStripMenuItem});
            this.الرئيسيهToolStripMenuItem.Name = "الرئيسيهToolStripMenuItem";
            this.الرئيسيهToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.الرئيسيهToolStripMenuItem.Text = "الرئيسيه";
            // 
            // ذهابالىالرئيسيهToolStripMenuItem
            // 
            this.ذهابالىالرئيسيهToolStripMenuItem.Name = "ذهابالىالرئيسيهToolStripMenuItem";
            this.ذهابالىالرئيسيهToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ذهابالىالرئيسيهToolStripMenuItem.Text = "ذهاب الى الرئيسيه";
            this.ذهابالىالرئيسيهToolStripMenuItem.Click += new System.EventHandler(this.ذهابالىالرئيسيهToolStripMenuItem_Click);
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
            // gr1
            // 
            this.gr1.AllowUserToAddRows = false;
            this.gr1.AllowUserToDeleteRows = false;
            this.gr1.AutoGenerateColumns = false;
            this.gr1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gr1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.msnoDataGridViewTextBoxColumn,
            this.empnoDataGridViewTextBoxColumn,
            this.apphomeDataGridViewTextBoxColumn,
            this.salprDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.gr1.DataSource = this.asceBindingSource;
            this.gr1.Location = new System.Drawing.Point(0, 24);
            this.gr1.Name = "gr1";
            this.gr1.ReadOnly = true;
            this.gr1.Size = new System.Drawing.Size(525, 252);
            this.gr1.TabIndex = 37;
            this.gr1.Visible = false;
            // 
            // msnoDataGridViewTextBoxColumn
            // 
            this.msnoDataGridViewTextBoxColumn.DataPropertyName = "msno";
            this.msnoDataGridViewTextBoxColumn.HeaderText = "رقم الاستحقاق";
            this.msnoDataGridViewTextBoxColumn.Name = "msnoDataGridViewTextBoxColumn";
            this.msnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empnoDataGridViewTextBoxColumn
            // 
            this.empnoDataGridViewTextBoxColumn.DataPropertyName = "empno";
            this.empnoDataGridViewTextBoxColumn.HeaderText = "رقم الموظف";
            this.empnoDataGridViewTextBoxColumn.Name = "empnoDataGridViewTextBoxColumn";
            this.empnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apphomeDataGridViewTextBoxColumn
            // 
            this.apphomeDataGridViewTextBoxColumn.DataPropertyName = "apphome";
            this.apphomeDataGridViewTextBoxColumn.HeaderText = "بدل السكن";
            this.apphomeDataGridViewTextBoxColumn.Name = "apphomeDataGridViewTextBoxColumn";
            this.apphomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salprDataGridViewTextBoxColumn
            // 
            this.salprDataGridViewTextBoxColumn.DataPropertyName = "salpr";
            this.salprDataGridViewTextBoxColumn.HeaderText = "الراتب الاساسي";
            this.salprDataGridViewTextBoxColumn.Name = "salprDataGridViewTextBoxColumn";
            this.salprDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "ملاحظه";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asceBindingSource
            // 
            this.asceBindingSource.DataMember = "asce";
            this.asceBindingSource.DataSource = this.dilowDataSet;
            // 
            // asceTableAdapter
            // 
            this.asceTableAdapter.ClearBeforeFill = true;
            // 
            // emploeeBindingSource1
            // 
            this.emploeeBindingSource1.DataMember = "emploee";
            this.emploeeBindingSource1.DataSource = this.dilowDataSet;
            // 
            // asce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(523, 273);
            this.Controls.Add(this.gr1);
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
            this.Name = "asce";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشه ادخال بيانات استحقاق الموظفين";
            this.Load += new System.EventHandler(this.asce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t3;
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
        private dilowDataSet dilowDataSet;
        private System.Windows.Forms.BindingSource emploeeBindingSource;
        private employee.dilowDataSetTableAdapters.emploeeTableAdapter emploeeTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الرئيسيهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ذهابالىالرئيسيهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استعلاماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عنالكلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انهاءالبرنامجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انهاءToolStripMenuItem;
        private System.Windows.Forms.DataGridView gr1;
        private System.Windows.Forms.BindingSource asceBindingSource;
        private employee.dilowDataSetTableAdapters.asceTableAdapter asceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn msnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apphomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource emploeeBindingSource1;
    }
}