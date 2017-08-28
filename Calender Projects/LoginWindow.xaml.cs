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

namespace Calender_Projects
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Page
    {
        bool LoggedIn = false;
        public LoginWindow()
        {
            InitializeComponent();
        }

        public void accountCheck()
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
                            LoggedIn = true;
                        }
                        else
                        {
                            messages.Text = "Password is Incorrect";
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("SignUpWindow.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            accountCheck();
            if(LoggedIn == true)
            {
                Uri uri = new Uri("CalenderPage.xaml", UriKind.Relative);
                this.NavigationService.Navigate(uri);
            }
        }
    }
}
