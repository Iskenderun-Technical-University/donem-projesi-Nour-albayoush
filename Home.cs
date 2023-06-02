using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro_
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            addclient pr = new addclient();
            pr.ShowDialog();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            users pr = new users();
            pr.ShowDialog();
            this.Close();
        }

        private void tsClients_Click(object sender, EventArgs e)
        {
       
            client pr = new client();
            pr.ShowDialog();
            this.Close();
        }

        private void tsProducts_Click(object sender, EventArgs e)
        {
            glass pr = new glass();
            pr.ShowDialog();
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            users pr = new users();
            pr.ShowDialog();
            this.Close();
        }

        private void tsLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void tsTransactions_Click(object sender, EventArgs e)
        {
            frmTransactions frm = new frmTransactions();
            frm.Show();
        }
    }
}
