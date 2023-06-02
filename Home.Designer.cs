namespace pro_
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsProducts = new System.Windows.Forms.ToolStripButton();
            this.tsClients = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTransactions = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(832, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(745, 21);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 34;
            // 
            // tsMenu
            // 
            this.tsMenu.AutoSize = false;
            this.tsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.tsProducts,
            this.tsClients,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.tsTransactions,
            this.toolStripSeparator4,
            this.tsLogout,
            this.toolStripSeparator5});
            this.tsMenu.Location = new System.Drawing.Point(9, 115);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMenu.Size = new System.Drawing.Size(818, 147);
            this.tsMenu.Stretch = true;
            this.tsMenu.TabIndex = 36;
            this.tsMenu.TabStop = true;
            this.tsMenu.Text = "Menu";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 147);
            // 
            // tsProducts
            // 
            this.tsProducts.AutoSize = false;
            this.tsProducts.Image = ((System.Drawing.Image)(resources.GetObject("tsProducts.Image")));
            this.tsProducts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsProducts.Name = "tsProducts";
            this.tsProducts.Size = new System.Drawing.Size(104, 114);
            this.tsProducts.Text = "&Products";
            this.tsProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsProducts.Click += new System.EventHandler(this.tsProducts_Click);
            // 
            // tsClients
            // 
            this.tsClients.AutoSize = false;
            this.tsClients.Image = ((System.Drawing.Image)(resources.GetObject("tsClients.Image")));
            this.tsClients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsClients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClients.Name = "tsClients";
            this.tsClients.Size = new System.Drawing.Size(104, 114);
            this.tsClients.Text = "&Clients";
            this.tsClients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsClients.Click += new System.EventHandler(this.tsClients_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 147);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 114);
            this.toolStripButton1.Text = "&customer";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 147);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 147);
            // 
            // tsTransactions
            // 
            this.tsTransactions.AutoSize = false;
            this.tsTransactions.Image = ((System.Drawing.Image)(resources.GetObject("tsTransactions.Image")));
            this.tsTransactions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsTransactions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTransactions.Name = "tsTransactions";
            this.tsTransactions.Size = new System.Drawing.Size(104, 114);
            this.tsTransactions.Text = "&Transactions";
            this.tsTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsTransactions.Click += new System.EventHandler(this.tsTransactions_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 147);
            // 
            // tsLogout
            // 
            this.tsLogout.Image = ((System.Drawing.Image)(resources.GetObject("tsLogout.Image")));
            this.tsLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogout.Name = "tsLogout";
            this.tsLogout.Size = new System.Drawing.Size(104, 144);
            this.tsLogout.Text = "Log &out";
            this.tsLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogout.Click += new System.EventHandler(this.tsLogout_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 147);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 48);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nour Optik";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 4F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(241, 11);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(91, 48);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 38;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.DarkKhaki;
            this.guna2ContainerControl1.Controls.Add(this.guna2ControlBox1);
            this.guna2ContainerControl1.Controls.Add(this.guna2PictureBox3);
            this.guna2ContainerControl1.FillColor = System.Drawing.Color.Teal;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(-5, 21);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(813, 70);
            this.guna2ContainerControl1.TabIndex = 39;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            this.guna2ContainerControl1.Click += new System.EventHandler(this.guna2ContainerControl1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 708);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.guna2ContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsClients;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsProducts;
        private System.Windows.Forms.ToolStripButton tsTransactions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
    }
}