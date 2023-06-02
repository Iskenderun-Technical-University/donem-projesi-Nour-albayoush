using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pro_
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();

        }

        string connectionString = @"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True";

        private void ConSql()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("select *from Customers", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customers");
            con.Open();
            dataGridView1.DataSource = ds.Tables["Customers"];
            con.Close();



        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // تعيين سلسلة الاتصال
            string connectionString = @"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True";

            // افتح اتصال بقاعدة البيانات
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // قم بإدخال بيانات العميل
                    string insertQuery = @"
                    INSERT INTO Customers (Name, Email, Phone, Address)
                    VALUES (Name, @Email, @Phone, @Address)";

                    // استخدم SqlCommand وقم بإعداد المعاملات المتغيرة
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {

                        command.Parameters.AddWithValue("@Name", "Doe");
                        command.Parameters.AddWithValue("@Email", "johndoe@example.com");
                        command.Parameters.AddWithValue("@Phone", "1234567890");
                        command.Parameters.AddWithValue("@Address", "123 Main Street");

                        // قم بتنفيذ الاستعلام
                        command.ExecuteNonQuery();
                        Console.WriteLine("تمت إضافة بيانات العميل بنجاح.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("حدث خطأ أثناء إضافة بيانات العميل: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }



            }

            Console.ReadKey();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // تعيين سلسلة الاتصال
            string connectionString = @"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True";

            // افتح اتصال بقاعدة البيانات
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // قم بحذف بيانات العميل بناءً على الشرط المحدد
                    string deleteQuery = "DELETE FROM Customers WHERE Id = @Id";

                    // استخدم SqlCommand وقم بإعداد المعاملات المتغيرة
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // قم بتعيين قيمة المعاملة المتغيرة
                        command.Parameters.AddWithValue("@Id", 1); // استبدل 1 بمعرّف العميل الذي ترغب في حذفه

                        // قم بتنفيذ الاستعلام
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("تم حذف بيانات العميل بنجاح.");
                        }
                        else
                        {
                            Console.WriteLine("لم يتم العثور على بيانات العميل المحددة.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("حدث خطأ أثناء حذف بيانات العميل: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            Console.ReadKey();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True";
            // إنشاء اتصال بقاعدة البيانات
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // البيانات التي تريد إضافتها
                string value1 = "Name";
                string value2 = "Email";
                string value3 = "Phone";
                string value4 = "Address";

                // استعلام SQL لإدخال البيانات
                string query = "INSERT INTO Customers(Name, Email, Phone, Address) VALUES (@Name, @Email, @Phone, @Address)";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", t1.Text);
                    command.Parameters.AddWithValue("@Email", t2.Text);
                    command.Parameters.AddWithValue("@Phone", t3.Text);
                    command.Parameters.AddWithValue("@Address", t4.Text);


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

        private void dtpExpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void customer_Load(object sender, EventArgs e)
        {
            void ConSql()
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter("select *from Customers", con);
                DataSet ds = new DataSet();
                con.Open();
                dataGridView1.DataSource = ds.Tables["Customers"];
                con.Close();



            }
            // TODO: This line of code loads data into the 'sunglassesisteDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.sunglassesisteDataSet.Customers);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            t0.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            t1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            t2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            t3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            t4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home HO = new Home();
            HO.ShowDialog();
        }
    }
}
