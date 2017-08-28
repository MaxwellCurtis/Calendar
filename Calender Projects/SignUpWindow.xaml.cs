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
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace Calender_Projects
{
    /// <summary>
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : ISignUpWindow
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        public void accountData()
        {
            string userName = UsernameTextBox.Text;
            string passWord = PasswordAccBox.Password;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrWhiteSpace(userName))
            {
                messages.Text = "Username cannot be empty";
            }
            else if (string.IsNullOrEmpty(passWord) || string.IsNullOrWhiteSpace(passWord))
            {
                messages.Text = "Password cannot be empty";
            }
            else
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString =
                    "Data Source=calenderserver.database.windows.net;" +
                    "Initial Catalog=Calender;" +
                    "User id=MCurtis;" +
                    "Password=Rock1000;" +
                    "MultipleActiveResultSets = true";
                    connection.Open();

                    SqlCommand command = new SqlCommand("Select * FROM [Users] WHERE [UserName] = @username", connection);
                    command.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                    command.ExecuteNonQuery();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        messages.Text = "username is taken";
                    }

                    else
                    {
                        messages.Text = "Account Created Return To Login";
                        SqlCommand command2 = new SqlCommand("INSERT INTO [Users] VALUES (@username, @pass)", connection);
                        command2.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                        command2.Parameters.AddWithValue("@pass", PasswordAccBox.Password);
                        command2.ExecuteNonQuery();
                    }
                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void click_signin(object sender, RoutedEventArgs e)
        {
            accountData();
        }

        private void click_login(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("LoginWindow.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}
