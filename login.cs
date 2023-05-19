using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace pro_
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        private string sqllink= @"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cn = new SqlConnection(sqllink);

                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                string cmd = "SELECT * FROM  login where user_name='" + id1.Text + "'and password= '" + id2.Text + "'";
                SqlCommand cd = new SqlCommand(cmd, cn);
                int r = Convert.ToInt32(cd.ExecuteScalar());
                if (r > 0)
                {
                    this.Hide();
                    Home hm = new Home();
                    hm.ShowDialog();
                    this.Close();

                }
                else
                    MessageBox.Show("The username or password is incorrect");
                if (cn.State == ConnectionState.Open)
                cn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); 
            Sginup sginup = new Sginup();
            sginup.Show(); 

        }

        private void id1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
