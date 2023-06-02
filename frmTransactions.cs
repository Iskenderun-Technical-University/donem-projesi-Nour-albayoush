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
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True";

        private void GETDATA()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("select *from Transaction", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Transaction");
            con.Open();
            dataGridView1.DataSource = ds.Tables["Transaction"];
            con.Close();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sunglassesisteDataSet4.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter1.Fill(this.sunglassesisteDataSet4.Transaction);
            // TODO: This line of code loads data into the 'sunglassesisteDataSet3.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.sunglassesisteDataSet3.Transaction);

        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True";
            // إنشاء اتصال بقاعدة البيانات
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // البيانات التي تريد إضافتها
                string value1 = "ClientId";
                string value2 = "ProductId";
                string value3 = "Quantity";
                string value4 = "DateTransaction";
                string value5 = "StatusTransaction";
                
                // استعلام SQL لإدخال البيانات
                string query = "INSERT INTO Transaction (ClientId,ProductId,Quantity,DateTransaction,StatusTransaction) VALUES (@ClientId,@ProductId,@Quantity,@DateTransaction,@StatusTransaction)";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientId", int.Parse(t1.Text));
                    command.Parameters.AddWithValue("@ProductId", t2.Text);
                    command.Parameters.AddWithValue("@Quantity", t3.Text);
                    command.Parameters.AddWithValue("@DateTransaction", t4.Text);

                    command.Parameters.AddWithValue("@StatusTransaction", t5.Text);


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

                GETDATA();

            }
        }
    }
}
