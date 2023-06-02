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
    public partial class DeleteClinet : Form
    {
        public DeleteClinet()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete client  where id=@id", con);

            cmd.Parameters.AddWithValue("@id", t0.Text);





            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sucessfully Deleted ");
            
        }
    }
}
