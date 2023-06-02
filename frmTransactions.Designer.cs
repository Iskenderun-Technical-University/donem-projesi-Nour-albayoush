namespace pro_
{
    partial class frmTransactions
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditStatus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.t5 = new System.Windows.Forms.ComboBox();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sunglassesisteDataSet3 = new pro_.sunglassesisteDataSet3();
            this.label4 = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionTableAdapter = new pro_.sunglassesisteDataSet3TableAdapters.TransactionTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sunglassesisteDataSet4 = new pro_.sunglassesisteDataSet4();
            this.transactionTableAdapter1 = new pro_.sunglassesisteDataSet4TableAdapters.TransactionTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunglassesisteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunglassesisteDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(719, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 29);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEditStatus
            // 
            this.btnEditStatus.Location = new System.Drawing.Point(615, 256);
            this.btnEditStatus.Name = "btnEditStatus";
            this.btnEditStatus.Size = new System.Drawing.Size(98, 29);
            this.btnEditStatus.TabIndex = 9;
            this.btnEditStatus.Text = "&Edit Status";
            this.btnEditStatus.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAddTransaction);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.t5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.t4);
            this.groupBox1.Controls.Add(this.t2);
            this.groupBox1.Controls.Add(this.t1);
            this.groupBox1.Controls.Add(this.t3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 240);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Transaction";
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(658, 176);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(132, 29);
            this.btnAddTransaction.TabIndex = 1;
            this.btnAddTransaction.Text = "&Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status of Transaction";
            // 
            // t5
            // 
            this.t5.FormattingEnabled = true;
            this.t5.Location = new System.Drawing.Point(418, 85);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(147, 24);
            this.t5.TabIndex = 10;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.sunglassesisteDataSet3;
            // 
            // sunglassesisteDataSet3
            // 
            this.sunglassesisteDataSet3.DataSetName = "sunglassesisteDataSet3";
            this.sunglassesisteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date of Transaction";
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(418, 21);
            this.t4.Multiline = true;
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(176, 41);
            this.t4.TabIndex = 7;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(85, 68);
            this.t2.Multiline = true;
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(148, 41);
            this.t2.TabIndex = 7;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(85, 21);
            this.t1.Multiline = true;
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(148, 41);
            this.t1.TabIndex = 7;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(85, 117);
            this.t3.Multiline = true;
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(148, 41);
            this.t3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Id";
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.dateTransactionDataGridViewTextBoxColumn,
            this.statusTransactionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(75, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 287);
            this.dataGridView1.TabIndex = 11;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateTransactionDataGridViewTextBoxColumn
            // 
            this.dateTransactionDataGridViewTextBoxColumn.DataPropertyName = "DateTransaction";
            this.dateTransactionDataGridViewTextBoxColumn.HeaderText = "DateTransaction";
            this.dateTransactionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateTransactionDataGridViewTextBoxColumn.Name = "dateTransactionDataGridViewTextBoxColumn";
            this.dateTransactionDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusTransactionDataGridViewTextBoxColumn
            // 
            this.statusTransactionDataGridViewTextBoxColumn.DataPropertyName = "StatusTransaction";
            this.statusTransactionDataGridViewTextBoxColumn.HeaderText = "StatusTransaction";
            this.statusTransactionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusTransactionDataGridViewTextBoxColumn.Name = "statusTransactionDataGridViewTextBoxColumn";
            this.statusTransactionDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionBindingSource1
            // 
            this.transactionBindingSource1.DataMember = "Transaction";
            this.transactionBindingSource1.DataSource = this.sunglassesisteDataSet4;
            // 
            // sunglassesisteDataSet4
            // 
            this.sunglassesisteDataSet4.DataSetName = "sunglassesisteDataSet4";
            this.sunglassesisteDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTableAdapter1
            // 
            this.transactionTableAdapter1.ClearBeforeFill = true;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 669);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditStatus);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunglassesisteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunglassesisteDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox t5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private sunglassesisteDataSet3 sunglassesisteDataSet3;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private sunglassesisteDataSet3TableAdapters.TransactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private sunglassesisteDataSet4 sunglassesisteDataSet4;
        private System.Windows.Forms.BindingSource transactionBindingSource1;
        private sunglassesisteDataSet4TableAdapters.TransactionTableAdapter transactionTableAdapter1;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTransactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusTransactionDataGridViewTextBoxColumn;
    }
}