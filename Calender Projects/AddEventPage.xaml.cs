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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CreateEventPage : Page
    {
        public CreateEventPage()
        {
            InitializeComponent();
        }

        private void SaveEvent_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(EventName.Text) || string.IsNullOrWhiteSpace(EventName.Text))
            {
                messages.Text = "Event Name cannot be empty";
            }
            else if (string.IsNullOrEmpty(DescriptionBox.Text) || string.IsNullOrWhiteSpace(DescriptionBox.Text))
            {
                messages.Text = "Description cannot be empty";
            }
            else
            {
                messages.Text = "Event Saved";
                LoginWindow log = new LoginWindow();
                log.eventAndUser(EventName.Text, DescriptionBox.Text);
            }
        }

        private void GoBackEvent_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("CalenderPage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        private void EndBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
