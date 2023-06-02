namespace pro_
{
    partial class DeleteClinet
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grbNewClient = new System.Windows.Forms.GroupBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.t0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbNewClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(393, 620);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 51);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(246, 620);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 51);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grbNewClient
            // 
            this.grbNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbNewClient.Controls.Add(this.t3);
            this.grbNewClient.Controls.Add(this.t4);
            this.grbNewClient.Controls.Add(this.lbCity);
            this.grbNewClient.Controls.Add(this.label1);
            this.grbNewClient.Controls.Add(this.lbFirstName);
            this.grbNewClient.Controls.Add(this.tbAdress);
            this.grbNewClient.Controls.Add(this.lbAdress);
            this.grbNewClient.Controls.Add(this.lbLastName);
            this.grbNewClient.Controls.Add(this.t5);
            this.grbNewClient.Controls.Add(this.t0);
            this.grbNewClient.Controls.Add(this.t1);
            this.grbNewClient.Controls.Add(this.t2);
            this.grbNewClient.Controls.Add(this.lbEmail);
            this.grbNewClient.Controls.Add(this.lbPhone);
            this.grbNewClient.Location = new System.Drawing.Point(3, 138);
            this.grbNewClient.Name = "grbNewClient";
            this.grbNewClient.Size = new System.Drawing.Size(578, 399);
            this.grbNewClient.TabIndex = 25;
            this.grbNewClient.TabStop = false;
            this.grbNewClient.Text = "Details";
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(372, 103);
            this.t3.Multiline = true;
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(178, 43);
            this.t3.TabIndex = 5;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(91, 217);
            this.t4.Multiline = true;
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(188, 42);
            this.t4.TabIndex = 5;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(299, 116);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(67, 16);
            this.lbCity.TabIndex = 12;
            this.lbCity.Text = "Password";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(13, 114);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(72, 16);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First Name";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(91, 315);
            this.tbAdress.Multiline = true;
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(188, 64);
            this.tbAdress.TabIndex = 9;
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Location = new System.Drawing.Point(28, 327);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(50, 16);
            this.lbAdress.TabIndex = 8;
            this.lbAdress.Text = "Adress";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(13, 176);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(72, 16);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "Last Name";
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(91, 265);
            this.t5.Multiline = true;
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(188, 44);
            this.t5.TabIndex = 7;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(91, 103);
            this.t1.Multiline = true;
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(188, 51);
            this.t1.TabIndex = 3;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(91, 160);
            this.t2.Multiline = true;
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(188, 51);
            this.t2.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(37, 281);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 16);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(32, 229);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(46, 16);
            this.lbPhone.TabIndex = 4;
            this.lbPhone.Text = "Phone";
            // 
            // t0
            // 
            this.t0.Location = new System.Drawing.Point(91, 46);
            this.t0.Multiline = true;
            this.t0.Name = "t0";
            this.t0.Size = new System.Drawing.Size(188, 51);
            this.t0.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // DeleteClinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 763);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grbNewClient);
            this.Name = "DeleteClinet";
            this.Text = "DeleteClinet";
            this.grbNewClient.ResumeLayout(false);
            this.grbNewClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grbNewClient;
        public System.Windows.Forms.TextBox t3;
        public System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFirstName;
        public System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbLastName;
        public System.Windows.Forms.TextBox t5;
        public System.Windows.Forms.TextBox t0;
        public System.Windows.Forms.TextBox t1;
        public System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
    }
}