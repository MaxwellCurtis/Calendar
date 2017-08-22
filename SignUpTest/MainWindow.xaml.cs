using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> userNames = new List<string>();
        public List<Account> AccountList = new List<Account>();

        public void SignUpTest()
        {
            InitializeComponent();
        }
        public void accountData()
        {
            string username = UsernameTextBox.Text;
            string passWord = PasswordAccBox.Password;
            Account newAcc = new Account();

            if (userNames.Contains(username))
            {
                messages.Text = "Username is taken, try again";
            }
            else
            {
                if (username.Length <= 4)
                {
                    messages.Text = "Username is too short";
                }
                else if (passWord.Length <= 6)
                {
                    messages.Text = "Password is too short";
                }
                else
                {
                    messages.Text = "Account Created";
                    Account acc = new Account(username, passWord);
                    WriteToFile("C:\\Users\\krazykombat14\\Documents\\Accounts\\accounts.txt", acc.ToString());
                    WriteToFile("C:\\Users\\krazykombat14\\Documents\\Accounts\\usernames.txt", username);
                }
            }
        }

        private void click_account(object sender, RoutedEventArgs e)
        {
            accountData();
        }

        private static string ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string lines = sr.ReadToEnd();
                    return lines;
                }
            }
            else
            {
                throw new FileNotFoundException("*** ERROR FILE NOT FIND ***");
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
    }
}

