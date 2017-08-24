using SignUpTest;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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

namespace SignUpTest
{
    public partial class MainWindow : Window
    {
        public void SignUpTest()
        {
            InitializeComponent();
        }
        public void accountData()
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
                if (reader.Read() == true)
                {
                    messages.Text = "username is taken";
                }

                else {
                    SqlCommand command2 = new SqlCommand("INSERT INTO [Users] VALUES (@username, @pass)", connection);
                    command2.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                    command2.Parameters.AddWithValue("@pass", PasswordAccBox.Password);
                    command2.ExecuteNonQuery();
                    }
                reader.Close();
                connection.Close();
            }
        }

        private void click_account(object sender, RoutedEventArgs e)
        {
            accountData();
        }

    }
}

