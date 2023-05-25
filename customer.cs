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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
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
                        command.Parameters.AddWithValue("@Id",1); // استبدل 1 بمعرّف العميل الذي ترغب في حذفه

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
    }
    }
    }
}
