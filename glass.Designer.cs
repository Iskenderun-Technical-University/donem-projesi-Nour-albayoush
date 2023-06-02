namespace pro_
{
    partial class glass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.glassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sunglassesisteDataSet1 = new pro_.sunglassesisteDataSet1();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.t11 = new System.Windows.Forms.TextBox();
            this.t9 = new System.Windows.Forms.TextBox();
            this.t8 = new System.Windows.Forms.TextBox();
            this.t7 = new System.Windows.Forms.TextBox();
            this.t6 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glassesTableAdapter = new pro_.sunglassesisteDataSet1TableAdapters.GlassesTableAdapter();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunglassesisteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAddTransaction);
            this.groupBox1.Controls.Add(this.t11);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.t9);
            this.groupBox1.Controls.Add(this.t8);
            this.groupBox1.Controls.Add(this.t7);
            this.groupBox1.Controls.Add(this.t6);
            this.groupBox1.Controls.Add(this.t5);
            this.groupBox1.Controls.Add(this.t4);
            this.groupBox1.Controls.Add(this.t3);
            this.groupBox1.Controls.Add(this.t2);
            this.groupBox1.Controls.Add(this.t1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 570);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "add product";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // glassesBindingSource
            // 
            this.glassesBindingSource.DataMember = "Glasses";
            this.glassesBindingSource.DataSource = this.sunglassesisteDataSet1;
            // 
            // sunglassesisteDataSet1
            // 
            this.sunglassesisteDataSet1.DataSetName = "sunglassesisteDataSet1";
            this.sunglassesisteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(424, 502);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(115, 43);
            this.btnAddTransaction.TabIndex = 1;
            this.btnAddTransaction.Text = "&Add Product\r\n";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // t11
            // 
            this.t11.Location = new System.Drawing.Point(358, 144);
            this.t11.Multiline = true;
            this.t11.Name = "t11";
            this.t11.Size = new System.Drawing.Size(178, 38);
            this.t11.TabIndex = 3;
            // 
            // t9
            // 
            this.t9.Location = new System.Drawing.Point(358, 30);
            this.t9.Multiline = true;
            this.t9.Name = "t9";
            this.t9.Size = new System.Drawing.Size(178, 38);
            this.t9.TabIndex = 3;
            this.t9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // t8
            // 
            this.t8.Location = new System.Drawing.Point(88, 376);
            this.t8.Multiline = true;
            this.t8.Name = "t8";
            this.t8.Size = new System.Drawing.Size(178, 38);
            this.t8.TabIndex = 3;
            // 
            // t7
            // 
            this.t7.Location = new System.Drawing.Point(88, 322);
            this.t7.Multiline = true;
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(178, 38);
            this.t7.TabIndex = 3;
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(88, 269);
            this.t6.Multiline = true;
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(178, 38);
            this.t6.TabIndex = 3;
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(88, 215);
            this.t5.Multiline = true;
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(178, 38);
            this.t5.TabIndex = 3;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(88, 171);
            this.t4.Multiline = true;
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(178, 38);
            this.t4.TabIndex = 3;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(88, 127);
            this.t3.Multiline = true;
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(178, 38);
            this.t3.TabIndex = 3;
            this.t3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(88, 83);
            this.t2.Multiline = true;
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(178, 38);
            this.t2.TabIndex = 3;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(88, 34);
            this.t1.Multiline = true;
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(178, 38);
            this.t1.TabIndex = 3;
            this.t1.TextChanged += new System.EventHandler(this.t1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Location = new System.Drawing.Point(298, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 32);
            this.label12.TabIndex = 2;
            this.label12.Text = "Minimum\r\nQuantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(298, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Location = new System.Drawing.Point(298, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Location = new System.Drawing.Point(7, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "ExpiryDate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Supplier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Brand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.minimumQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.glassesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(579, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(807, 622);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.Width = 125;
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            this.expiryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // minimumQuantityDataGridViewTextBoxColumn
            // 
            this.minimumQuantityDataGridViewTextBoxColumn.DataPropertyName = "MinimumQuantity";
            this.minimumQuantityDataGridViewTextBoxColumn.HeaderText = "MinimumQuantity";
            this.minimumQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minimumQuantityDataGridViewTextBoxColumn.Name = "minimumQuantityDataGridViewTextBoxColumn";
            this.minimumQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // glassesTableAdapter
            // 
            this.glassesTableAdapter.ClearBeforeFill = true;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.DarkKhaki;
            this.guna2ContainerControl1.Controls.Add(this.guna2ControlBox1);
            this.guna2ContainerControl1.FillColor = System.Drawing.Color.Teal;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(12, 12);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(1348, 63);
            this.guna2ContainerControl1.TabIndex = 41;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1266, 29);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 34;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 47);
            this.button2.TabIndex = 13;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 38);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // glass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 741);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "glass";
            this.Text = "glass";
            this.Load += new System.EventHandler(this.glass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunglassesisteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.TextBox t11;
        private System.Windows.Forms.TextBox t8;
        private System.Windows.Forms.TextBox t7;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private sunglassesisteDataSet1 sunglassesisteDataSet1;
        private System.Windows.Forms.BindingSource glassesBindingSource;
        private sunglassesisteDataSet1TableAdapters.GlassesTableAdapter glassesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumQuantityDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.ComboBox t9;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}