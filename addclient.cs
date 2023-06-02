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
    public partial class addclient : Form
    {
        public addclient()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // تعيين سلسلة الاتصال
            string connectionString = @"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True";


            // معرف المستخدم الذي يجب حذفه
            int userId = 1;

            // حذف بيانات المستخدم
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Users WHERE Id = @UserId";
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("تم حذف بيانات المستخدم بنجاح!");
                }
                else
                {
                    Console.WriteLine("لم يتم العثور على مستخدم بالمعرف المحدد.");
                }
            }

            Console.ReadLine();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            // تعيين سلسلة الاتصال
            string connectionString = @"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True";

            // بيانات البحث
            string searchTerm = "بحث";

            // بحث بيانات المستخدم
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string searchQuery = "SELECT * FROM Users WHERE Username LIKE '%' + @SearchTerm + '%' OR Name LIKE '%' + @SearchTerm + '%'";
                SqlCommand command = new SqlCommand(searchQuery, connection);
                command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int userId = (int)reader["Id"];
                    string username = (string)reader["Username"];
                    string name = (string)reader["Name"];
                    string email = (string)reader["Email"];

                    Console.WriteLine("معرف المستخدم: " + userId);
                    Console.WriteLine("اسم المستخدم: " + username);
                    Console.WriteLine("الاسم: " + name);
                    Console.WriteLine("البريد الإلكتروني: " + email);
                    Console.WriteLine("-----------------------------------");
                }

                reader.Close();
            }

            Console.ReadLine();
        }

        private void pro2_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True";
            // إنشاء اتصال بقاعدة البيانات
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // البيانات التي تريد إضافتها
                string value1 = "FirstName";
                string value2 = "LastName";
                string value3 = "Password";
                string value4 = "Phone";
                string value5 = "Adress";
                string value6 = "Email";

                // استعلام SQL لإدخال البيانات
                string query = "INSERT INTO client(FirstName,LastName,Password,Phone,Adress,Email) VALUES (@FirstName,@LastName,@Password,@Phone,@Adress,@Email)";

                // إعداد الاستعلام
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", t1.Text);
                    command.Parameters.AddWithValue("@LastName", t2.Text);
                    command.Parameters.AddWithValue("@Password", t3.Text);
                    command.Parameters.AddWithValue("@Phone", t4.Text);
                    command.Parameters.AddWithValue("@Adress", tbAdress.Text);
                    command.Parameters.AddWithValue("@Email", t5.Text);

                    // تنفيذ الاستعلام
                    int rowsAffected = command.ExecuteNonQuery();

                    // التحقق من عدد الصفوف المتأثرة
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("تمت إضافة البيانات بنجاح!");
                        t1.Clear();
                        t2.Clear();
                        t3.Clear();
                        t4.Clear();
                        t5.Clear();
                        tbAdress.Clear();
                    }
                    else
                    {
                        MessageBox.Show("لم يتم إضافة البيانات.");
                    }
                }

                connection.Close();
            }

            Console.ReadLine();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbNewClient_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
