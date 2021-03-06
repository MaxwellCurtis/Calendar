﻿using System;
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

namespace SignUpTest
{
    public partial class Window1 : Window
    {
        public Window1()
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

        private void click_login(object sender, RoutedEventArgs e)
        {
            accountCheck();
        }

        private void click_signup(object sender, RoutedEventArgs e)
        {
            Window2 win = new Window2();
            win.Show();
            this.Close();
        }
    }
}
