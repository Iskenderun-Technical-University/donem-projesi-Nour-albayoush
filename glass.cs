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
    public partial class glass : Form
    {
        public glass()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True";
     private   void ConSql()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("select *from Glasses", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Glasses");
            con.Open();
            dataGridView1.DataSource = ds.Tables["Glasses"];
            con.Close();



        }

       

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // البيانات التي تريد إضافتها
                string value1 = "Code";
                string value2 = "Description";
                string value3 = "Price";
                string value4 = "Quantity";
                string value5 = "Brand";
                string value6 = "Color";
                string value7 = "Supplier";
                string value8 = "ExpiryDate";
                string value9 = "Status";
                string value10 = "Category";
                string value11 = "MinimumQuantity";


                // استعلام SQL لإدخال البيانات
                string query = "INSERT INTO Glasses(Code, Description, Price, Quantity,Brand,Color,Supplier,ExpiryDate,Status,Category,MinimumQuantity) VALUES (@Code, @Description, @Price, @Quantity,@Brand,@Color,@Supplier,@ExpiryDate,@Status,@Category,@MinimumQuantity)";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Code", t1.Text);
                    command.Parameters.AddWithValue("@Description", t2.Text);
                    command.Parameters.AddWithValue("@Price", t3.Text);
                    command.Parameters.AddWithValue("@Quantity", t4.Text);
                    command.Parameters.AddWithValue("@Brand", t1.Text);
                    command.Parameters.AddWithValue("@Color", t2.Text);
                    command.Parameters.AddWithValue("@Supplier", t3.Text);
                    command.Parameters.AddWithValue("@ExpiryDate", t4.Text);
                    command.Parameters.AddWithValue("@Status", t2.Text);
                    command.Parameters.AddWithValue("@Category", t3.Text);
                    command.Parameters.AddWithValue("@MinimumQuantity", t4.Text);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("تمت إضافة البيانات بنجاح!");
                    }
                    else
                    {
                        Console.WriteLine("لم يتم إضافة البيانات.");
                    }
                }

                connection.Close();



                ConSql();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void glass_Load(object sender, EventArgs e)
        {
            ConSql();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           //   t0.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            t1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            t2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            t3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            t4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            t5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            t6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            t7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            t8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            t9.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            t9.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            t11.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home HO = new Home();
            HO.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Glasses  where id=@id", con);

           // cmd.Parameters.AddWithValue("@id", t0.Text);





            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sucessfully Deleted ");
            ConSql();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Glasses set Status=@Status where id=@id ",con);

            cmd.Parameters.AddWithValue("@Status", t9.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
            ConSql();
        }
    }
}
