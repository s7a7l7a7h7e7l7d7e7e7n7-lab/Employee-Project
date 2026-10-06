namespace employee
{
    partial class agez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agez));
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
            this.t6 = new System.Windows.Forms.ComboBox();
            this.t7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emploeeTableAdapter = new employee.dilowDataSetTableAdapters.emploeeTableAdapter();
            this.gr1 = new System.Windows.Forms.DataGridView();
            this.holnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holbecuseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agezBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agezTableAdapter = new employee.dilowDataSetTableAdapters.agezTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agezBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(17, 69);
            this.t5.Name = "t5";
            this.t5.ReadOnly = true;
            this.t5.Size = new System.Drawing.Size(204, 20);
            this.t5.TabIndex = 54;
            this.t5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t5.Visible = false;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(154, 259);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(363, 23);
            this.b1.TabIndex = 53;
            this.b1.Text = "انهاء البحث";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Visible = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Location = new System.Drawing.Point(-1, 302);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(529, 26);
            this.button7.TabIndex = 52;
            this.button7.Text = "انهاء البرنامج";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "ملاحظه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "تاريخ الاجازه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "مده الاجازه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "رقم الاجازه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "رقم الموظف";
            // 
            // t0
            // 
            this.t0.DataSource = this.emploeeBindingSource;
            this.t0.DisplayMember = "empno";
            this.t0.FormattingEnabled = true;
            this.t0.Location = new System.Drawing.Point(329, 35);
            this.t0.Name = "t0";
            this.t0.Size = new System.Drawing.Size(125, 30);
            this.t0.TabIndex = 46;
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
            this.t3.Location = new System.Drawing.Point(21, 42);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(200, 20);
            this.t3.TabIndex = 45;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(12, 188);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(444, 20);
            this.t4.TabIndex = 44;
            this.t4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(346, 100);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(110, 20);
            this.t2.TabIndex = 43;
            this.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(359, 74);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(97, 20);
            this.t1.TabIndex = 42;
            this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(16, 259);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(61, 23);
            this.b2.TabIndex = 41;
            this.b2.Text = "بحث";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(156, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 40;
            this.button4.Text = "حذف";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "حفظ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "اضافه جديد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(125, -1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(402, 25);
            this.button6.TabIndex = 55;
            this.button6.Text = "عوده للرئيسيه";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // t6
            // 
            this.t6.FormattingEnabled = true;
            this.t6.Items.AddRange(new object[] {
            "مرضيه",
            "عرضيه",
            "شهريه",
            "سنويه",
            "اسبوعيه"});
            this.t6.Location = new System.Drawing.Point(332, 128);
            this.t6.Name = "t6";
            this.t6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.t6.Size = new System.Drawing.Size(121, 21);
            this.t6.TabIndex = 56;
            // 
            // t7
            // 
            this.t7.Location = new System.Drawing.Point(318, 158);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(134, 20);
            this.t7.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "نوع الاجازه";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "سبب الاجازه";
            // 
            // emploeeTableAdapter
            // 
            this.emploeeTableAdapter.ClearBeforeFill = true;
            // 
            // gr1
            // 
            this.gr1.AllowUserToAddRows = false;
            this.gr1.AllowUserToDeleteRows = false;
            this.gr1.AutoGenerateColumns = false;
            this.gr1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gr1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.holnoDataGridViewTextBoxColumn,
            this.empnoDataGridViewTextBoxColumn,
            this.holtimeDataGridViewTextBoxColumn,
            this.holdateDataGridViewTextBoxColumn,
            this.holtypeDataGridViewTextBoxColumn,
            this.holbecuseDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.gr1.DataSource = this.agezBindingSource;
            this.gr1.Location = new System.Drawing.Point(-2, 22);
            this.gr1.Name = "gr1";
            this.gr1.ReadOnly = true;
            this.gr1.Size = new System.Drawing.Size(530, 306);
            this.gr1.TabIndex = 60;
            this.gr1.Visible = false;
            // 
            // holnoDataGridViewTextBoxColumn
            // 
            this.holnoDataGridViewTextBoxColumn.DataPropertyName = "holno";
            this.holnoDataGridViewTextBoxColumn.HeaderText = "رقم الاجازه";
            this.holnoDataGridViewTextBoxColumn.Name = "holnoDataGridViewTextBoxColumn";
            this.holnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empnoDataGridViewTextBoxColumn
            // 
            this.empnoDataGridViewTextBoxColumn.DataPropertyName = "empno";
            this.empnoDataGridViewTextBoxColumn.HeaderText = "رقم الموظف";
            this.empnoDataGridViewTextBoxColumn.Name = "empnoDataGridViewTextBoxColumn";
            this.empnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // holtimeDataGridViewTextBoxColumn
            // 
            this.holtimeDataGridViewTextBoxColumn.DataPropertyName = "holtime";
            this.holtimeDataGridViewTextBoxColumn.HeaderText = "مده الاجازه";
            this.holtimeDataGridViewTextBoxColumn.Name = "holtimeDataGridViewTextBoxColumn";
            this.holtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // holdateDataGridViewTextBoxColumn
            // 
            this.holdateDataGridViewTextBoxColumn.DataPropertyName = "holdate";
            this.holdateDataGridViewTextBoxColumn.HeaderText = "تاريخ اخذ الاجازه";
            this.holdateDataGridViewTextBoxColumn.Name = "holdateDataGridViewTextBoxColumn";
            this.holdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // holtypeDataGridViewTextBoxColumn
            // 
            this.holtypeDataGridViewTextBoxColumn.DataPropertyName = "holtype";
            this.holtypeDataGridViewTextBoxColumn.HeaderText = "نوع الاجازه";
            this.holtypeDataGridViewTextBoxColumn.Name = "holtypeDataGridViewTextBoxColumn";
            this.holtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // holbecuseDataGridViewTextBoxColumn
            // 
            this.holbecuseDataGridViewTextBoxColumn.DataPropertyName = "holbecuse";
            this.holbecuseDataGridViewTextBoxColumn.HeaderText = "سبب الاجازه";
            this.holbecuseDataGridViewTextBoxColumn.Name = "holbecuseDataGridViewTextBoxColumn";
            this.holbecuseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agezBindingSource
            // 
            this.agezBindingSource.DataMember = "agez";
            this.agezBindingSource.DataSource = this.dilowDataSet;
            // 
            // agezTableAdapter
            // 
            this.agezTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(-2, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 24);
            this.button5.TabIndex = 61;
            this.button5.Text = "استعلام عن الكل";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // agez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(526, 328);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.gr1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.t6);
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
            this.Name = "agez";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشه تسجيل الاجازات";
            this.Load += new System.EventHandler(this.agez_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agezBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox t6;
        private System.Windows.Forms.TextBox t7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private dilowDataSet dilowDataSet;
        private System.Windows.Forms.BindingSource emploeeBindingSource;
        private employee.dilowDataSetTableAdapters.emploeeTableAdapter emploeeTableAdapter;
        private System.Windows.Forms.DataGridView gr1;
        private System.Windows.Forms.BindingSource agezBindingSource;
        private employee.dilowDataSetTableAdapters.agezTableAdapter agezTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn holnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holbecuseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}