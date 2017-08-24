using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LogIn
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void accountCheck()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                "Data Source=calenderserver.database.windows.net;" +
                "Initial Catalog=Calender;" +
                "User id=MCurtis;" +
                "Password=Rock1000;";
                connection.Open();

                SqlCommand command = new SqlCommand("Select * FROM [Users] WHERE [UserName] = @username", connection);
                command.Parameters.AddWithValue("@username", UsernameTextBox.Text);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() == false)
                {
                    messages.Text = "username does not exist";
                }
                else
                {
                    string password = reader["Password"].ToString();
                    if (PasswordAccBox.Password == password)
                    {
                        messages.Text = "Logged In";
                    }
                    else
                    {
                        messages.Text = "Password is Incorrect";
                    }
                }
                connection.Close();
            }
        }

        private void click_login(object sender, RoutedEventArgs e)
        {
            accountCheck();
        }
    }
}
