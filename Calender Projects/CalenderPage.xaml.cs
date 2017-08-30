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

        public System.Globalization.Calendar[,] calenderCells;

        public System.Globalization.Calendar calenderCell;

        public object CalendarCells { get; private set; }

        public CalenderWindow()
        {
            InitializeComponent();

            theCalender.Rows = 6;
            theCalender.Columns = 7;

            List<DateTime> allDates = new List<DateTime>();

            DateTime startingDay = new DateTime(2017, 8, 1);
            DateTime endingDay = new DateTime(2017, 8, 31);

            int starting = startingDay.Day;
            int ending = endingDay.Day;

            for (DateTime date = startingDay; date == endingDay; date = date.AddDays(1))
            {
                allDates.Add(date);
            }

            TheCalender();

            DateTimeFormatInfo fm = new DateTimeFormatInfo();
            int currentMonthNumber = DateTime.Now.Month;
            string currentMonth = fm.GetMonthName(currentMonthNumber);
            string currentYear = DateTime.Now.Year.ToString();
            string currentDay = DateTime.Now.Day.ToString();

            MonthLabel.Content = currentMonth;
            YearLabel.Content = currentYear;
            DayLabel.Content = currentDay;


        }

        private void TheCalender()
        {
            gridBorder = Brushes.Black;

            for (int i = 0; i < theCalender.Rows; i++)
            {
                for (int j = 0; j < theCalender.Columns; j++)
                {
                    Label calenderLabel = new Label();
                    
                    calenderLabel.BorderBrush = gridBorder;
                    calenderLabel.BorderThickness = new Thickness(1);
                    theCalender.Children.Add(calenderLabel);
                }
            }
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
