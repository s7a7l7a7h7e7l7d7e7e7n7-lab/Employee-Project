namespace employee
{
    partial class anth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anth));
            this.t5 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t0 = new System.Windows.Forms.ListBox();
            this.emploeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dilowDataSet = new employee.dilowDataSet();
            this.t3 = new System.Windows.Forms.DateTimePicker();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.b2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dilowDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emploeeTableAdapter = new employee.dilowDataSetTableAdapters.emploeeTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.gr1 = new System.Windows.Forms.DataGridView();
            this.warnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wardateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warbecuseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anthTableAdapter = new employee.dilowDataSetTableAdapters.anthTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anthBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(233, 139);
            this.t5.Name = "t5";
            this.t5.ReadOnly = true;
            this.t5.Size = new System.Drawing.Size(204, 20);
            this.t5.TabIndex = 36;
            this.t5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t5.Visible = false;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(150, 214);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(363, 23);
            this.b1.TabIndex = 35;
            this.b1.Text = "انهاء البحث";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Visible = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Location = new System.Drawing.Point(-4, 282);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(526, 26);
            this.button7.TabIndex = 34;
            this.button7.Text = "انهاء البرنامج";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "ملاحظه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "تاريخ الانذار";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "سبب الانذار";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "رقم الانذار";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 52);
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
            this.t0.Location = new System.Drawing.Point(136, 46);
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
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(237, 139);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(200, 20);
            this.t3.TabIndex = 27;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(10, 171);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(428, 20);
            this.t4.TabIndex = 26;
            this.t4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(79, 111);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(359, 20);
            this.t2.TabIndex = 25;
            this.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(341, 85);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(97, 20);
            this.t1.TabIndex = 24;
            this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(12, 214);
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
            this.button4.Location = new System.Drawing.Point(152, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "حذف";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "حفظ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "اضافه جديد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(100, -1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(422, 25);
            this.button6.TabIndex = 37;
            this.button6.Text = "عوده للرئيسيه";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dilowDataSetBindingSource
            // 
            this.dilowDataSetBindingSource.DataSource = this.dilowDataSet;
            this.dilowDataSetBindingSource.Position = 0;
            // 
            // emploeeTableAdapter
            // 
            this.emploeeTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(-4, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "استعلام";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gr1
            // 
            this.gr1.AllowUserToAddRows = false;
            this.gr1.AllowUserToDeleteRows = false;
            this.gr1.AutoGenerateColumns = false;
            this.gr1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gr1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warnoDataGridViewTextBoxColumn,
            this.empnoDataGridViewTextBoxColumn,
            this.wardateDataGridViewTextBoxColumn,
            this.warbecuseDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.gr1.DataSource = this.anthBindingSource;
            this.gr1.Location = new System.Drawing.Point(-4, 21);
            this.gr1.Name = "gr1";
            this.gr1.ReadOnly = true;
            this.gr1.Size = new System.Drawing.Size(522, 287);
            this.gr1.TabIndex = 39;
            this.gr1.Visible = false;
            // 
            // warnoDataGridViewTextBoxColumn
            // 
            this.warnoDataGridViewTextBoxColumn.DataPropertyName = "warno";
            this.warnoDataGridViewTextBoxColumn.HeaderText = "رقم الانذار";
            this.warnoDataGridViewTextBoxColumn.Name = "warnoDataGridViewTextBoxColumn";
            this.warnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empnoDataGridViewTextBoxColumn
            // 
            this.empnoDataGridViewTextBoxColumn.DataPropertyName = "empno";
            this.empnoDataGridViewTextBoxColumn.HeaderText = "رقم الموظف";
            this.empnoDataGridViewTextBoxColumn.Name = "empnoDataGridViewTextBoxColumn";
            this.empnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wardateDataGridViewTextBoxColumn
            // 
            this.wardateDataGridViewTextBoxColumn.DataPropertyName = "wardate";
            this.wardateDataGridViewTextBoxColumn.HeaderText = "تاريخ الانذار";
            this.wardateDataGridViewTextBoxColumn.Name = "wardateDataGridViewTextBoxColumn";
            this.wardateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // warbecuseDataGridViewTextBoxColumn
            // 
            this.warbecuseDataGridViewTextBoxColumn.DataPropertyName = "warbecuse";
            this.warbecuseDataGridViewTextBoxColumn.HeaderText = "سبب الانذار";
            this.warbecuseDataGridViewTextBoxColumn.Name = "warbecuseDataGridViewTextBoxColumn";
            this.warbecuseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "ملاحظه";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anthBindingSource
            // 
            this.anthBindingSource.DataMember = "anth";
            this.anthBindingSource.DataSource = this.dilowDataSet;
            // 
            // anthTableAdapter
            // 
            this.anthTableAdapter.ClearBeforeFill = true;
            // 
            // anth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(517, 307);
            this.Controls.Add(this.gr1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t0);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "anth";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشه_تسجيل_الانذارات";
            this.Load += new System.EventHandler(this.anth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anthBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox t0;
        private System.Windows.Forms.DateTimePicker t3;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource dilowDataSetBindingSource;
        private dilowDataSet dilowDataSet;
        private System.Windows.Forms.BindingSource emploeeBindingSource;
        private employee.dilowDataSetTableAdapters.emploeeTableAdapter emploeeTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView gr1;
        private System.Windows.Forms.BindingSource anthBindingSource;
        private employee.dilowDataSetTableAdapters.anthTableAdapter anthTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn warnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wardateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warbecuseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}