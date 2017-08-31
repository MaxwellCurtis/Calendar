using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Calender_Projects
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Page
    {
        bool LoggedIn = false;
        private int user;

        public int User
        {
            get { return user; }
            set { user = value; }
        }

        public LoginWindow()
        {
            InitializeComponent();
        }

        public void accountCheck()
        {
            string userid = UsernameTextBox.Text;
            string passWord = PasswordAccBox.Password;

            if (string.IsNullOrEmpty(userid) || string.IsNullOrWhiteSpace(userid))
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

                    SqlCommand command = new SqlCommand("Select * FROM [Users] WHERE [UserName] = @Username", connection);
                    command.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                    string username = UsernameTextBox.Text;

                    WriteToFile("C:\\Users\\krazykombat14\\Documents\\test.txt", username);


                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == false)
                    {
                        messages.Text = "Username does not exist";
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

        public static void WriteToFile(string filePath, string output)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("* FilePath Must Not Be Null*");
            }
            else if (output == null)
            {
                throw new ArgumentNullException("* Output Must Not Be Null *");
            }
            else if (!File.Exists(filePath))
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(output);
                }
            }
            else if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, output);
            }
            else
            {
                throw new DirectoryNotFoundException("* File Path Does Not Exist *");
            }
        }

        public static string ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string lines = sr.ReadToEnd();
                    Console.WriteLine("Test Print: " + lines);
                    return lines;
                }
            }
            else
            {
                throw new FileNotFoundException("*** ERROR FILE NOT FIND ***");
            }
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("SignUpWindow.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        public void Login_Click(object sender, RoutedEventArgs e)
        {
            accountCheck();
            if (LoggedIn == true)
            {
                Uri uri = new Uri("CalenderPage.xaml", UriKind.Relative);
                this.NavigationService.Navigate(uri);
            }

        }

        public void eventAndUser(string name, string description)
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

                string username = ReadFile("C:\\Users\\krazykombat14\\Documents\\test.txt");

                SqlCommand com = new SqlCommand("SELECT * FROM [Users] WHERE [Username] = @Username", connection);
                com.Parameters.AddWithValue("@Username", username);

                int userid = (int)com.ExecuteScalar();

                messages.Text = "Event Added";
                SqlCommand command = new SqlCommand("INSERT INTO [Events] VALUES (@eventname, @eventdesc, @userid)", connection);
                command.Parameters.AddWithValue("@eventname", name);
                command.Parameters.AddWithValue("@eventdesc", description);
                command.Parameters.AddWithValue("@userid", userid);
                command.ExecuteNonQuery();

                connection.Close();

            }
        }
    }
}
