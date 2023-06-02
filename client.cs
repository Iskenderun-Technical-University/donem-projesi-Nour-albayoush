using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro_
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True";

      private  void GETDATA()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("select *from client", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "client");
            con.Open();
            guna2DataGridView1.DataSource = ds.Tables["client"];
            con.Close();
        }
        private void client_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'sunglassesisteDataSet2.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.sunglassesisteDataSet2.client);
            GETDATA();

        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            addclient AD = new addclient();
            AD.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteClinet AD = new DeleteClinet();
            AD.t0.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();

            AD.t1.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            AD.t2.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            AD.t3.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            AD.t4.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            AD.tbAdress.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
            AD.t5.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
            AD.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            editclinet AD = new editclinet();
            AD.t1.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            AD.t2.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            AD.t3.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            AD.t4.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            AD.tbAdress.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
             AD.t5.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
            AD.ShowDialog();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home HO = new Home();
            HO.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
