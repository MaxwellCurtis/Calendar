using Calender_Projects.Calender;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Calender_Projects
{
    /// <summary>
    /// Interaction logic for CalenderWindow.xaml
    /// </summary>
    public partial class CalenderWindow : Page
    {
        public SolidColorBrush gridBorder = new SolidColorBrush();

        public CalenderCells[,] calenderCells;

        public CalenderWindow()
        {
            InitializeComponent();

            DateTimeFormatInfo fm = new DateTimeFormatInfo();
            int currentMonthNumber = DateTime.Now.Month;
            string currentMonth = fm.GetMonthName(currentMonthNumber);
            string currentYear = DateTime.Now.Year.ToString();

            MonthLabel.Content = currentMonth;
            YearLabel.Content = currentYear;

        }

        private void WeekDays()
        {
          
        }

        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("AddEventPage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        private void ManageList_Click(object sender, RoutedEventArgs e)
        {
            Uri uri1 = new Uri("ManageListsPage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri1);
        }

        private void AddList_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
