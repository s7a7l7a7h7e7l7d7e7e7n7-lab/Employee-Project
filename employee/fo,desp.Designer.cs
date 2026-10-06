namespace employee
{
    partial class fo_desp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fo_desp));
            this.t0 = new System.Windows.Forms.ListBox();
            this.emploeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dilowDataSet = new employee.dilowDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button20 = new System.Windows.Forms.Button();
            this.emploeeTableAdapter = new employee.dilowDataSetTableAdapters.emploeeTableAdapter();
            this.emploeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // t0
            // 
            this.t0.DataSource = this.emploeeBindingSource1;
            this.t0.DisplayMember = "empno";
            this.t0.ForeColor = System.Drawing.Color.Red;
            this.t0.FormattingEnabled = true;
            this.t0.Location = new System.Drawing.Point(355, 11);
            this.t0.Name = "t0";
            this.t0.Size = new System.Drawing.Size(203, 342);
            this.t0.TabIndex = 0;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(206, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "الاستحقاق";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(206, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "الاجازات";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(206, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "الغياب";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(206, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "الانذارات";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(205, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "الجزاءات";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(205, 175);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "الاضافي";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(205, 207);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "الخصم";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(206, 241);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "الفصل";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(355, 368);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(83, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "انهاء";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(478, 368);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "رجوع";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Red;
            this.button12.Location = new System.Drawing.Point(17, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(122, 23);
            this.button12.TabIndex = 14;
            this.button12.Text = "تصفير الاستحقاق";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Red;
            this.button13.Location = new System.Drawing.Point(17, 40);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(122, 23);
            this.button13.TabIndex = 15;
            this.button13.Text = "تصفير الاجازات";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Red;
            this.button14.Location = new System.Drawing.Point(17, 70);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(122, 23);
            this.button14.TabIndex = 16;
            this.button14.Text = "تصفير الغياب";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.Red;
            this.button15.Location = new System.Drawing.Point(17, 103);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(122, 23);
            this.button15.TabIndex = 17;
            this.button15.Text = "تصفير الانذارات";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.Red;
            this.button16.Location = new System.Drawing.Point(17, 140);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(122, 23);
            this.button16.TabIndex = 18;
            this.button16.Text = "تصفير الجزاءات";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.Red;
            this.button17.Location = new System.Drawing.Point(17, 175);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(122, 23);
            this.button17.TabIndex = 19;
            this.button17.Text = "تصفير الاضافي";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.Red;
            this.button18.Location = new System.Drawing.Point(17, 207);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(122, 23);
            this.button18.TabIndex = 20;
            this.button18.Text = "تصفير الخصم";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.Red;
            this.button19.Location = new System.Drawing.Point(17, 241);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(122, 23);
            this.button19.TabIndex = 21;
            this.button19.Text = "تصفير الفصل";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Location = new System.Drawing.Point(2, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 47);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تصفير قاعده البيانات";
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Red;
            this.button11.Location = new System.Drawing.Point(3, 17);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(263, 23);
            this.button11.TabIndex = 14;
            this.button11.Text = "مسح جميع بيانات الموظفين في كل الاقسام";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button20);
            this.groupBox2.Location = new System.Drawing.Point(2, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 45);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تصفير كل الموظفين";
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.Red;
            this.button20.Location = new System.Drawing.Point(3, 17);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(326, 23);
            this.button20.TabIndex = 15;
            this.button20.Text = "مسح جيمع الموظفين المسجلين حالياً في قسم الموظفين";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // emploeeTableAdapter
            // 
            this.emploeeTableAdapter.ClearBeforeFill = true;
            // 
            // emploeeBindingSource1
            // 
            this.emploeeBindingSource1.DataMember = "emploee";
            this.emploeeBindingSource1.DataSource = this.dilowDataSet;
            // 
            // fo_desp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fo_desp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشه الفرعيه";
            this.Load += new System.EventHandler(this.fo_desp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilowDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox t0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button20;
        private dilowDataSet dilowDataSet;
        private System.Windows.Forms.BindingSource emploeeBindingSource;
        private employee.dilowDataSetTableAdapters.emploeeTableAdapter emploeeTableAdapter;
        private System.Windows.Forms.BindingSource emploeeBindingSource1;
    }
}