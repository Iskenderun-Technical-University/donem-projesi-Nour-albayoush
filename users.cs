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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // تعيين سلسلة الاتصال
            string connectionString = @"Data Source=DESKTOP-V9F62LB\SQLEXPRESS;Initial Catalog=sunglassesiste;Integrated Security=True";

            // بيانات المستخدم
           // string username = "اسم_المستخدم";
           // string password = "كلمة_المرور";
           // string name = "الاسم";
          //  string email = "البريد_الإلكتروني";

            // إدراج بيانات المستخدم
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Users (Username, Password, Name, Email) VALUES (@Username, @Password, @Name, @Email)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Username", guna2TextBox1);
                command.Parameters.AddWithValue("@Password", guna2TextBox2);
                command.Parameters.AddWithValue("@Name", guna2TextBox3);
                command.Parameters.AddWithValue("@Email", guna2TextBox4);
                command.ExecuteNonQuery();
            }

            Console.WriteLine("تمت إضافة بيانات المستخدم بنجاح!");

            Console.ReadLine();
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
    }
    
}
