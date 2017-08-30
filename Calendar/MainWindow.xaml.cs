using System;
using System.Collections.Generic;
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

namespace Calendars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DateTime Day { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            List<DateTime> allDates = new List<DateTime>();

            DateTime startingDay = new DateTime(2009, 1, 1);
            DateTime endingDay = new DateTime(2009, 1, 31);

            int starting = startingDay.Day;
            int ending = endingDay.Day;

            for (Day = startingDay; Day == endingDay; Day = Day.AddDays(1))
            {
                allDates.Add(Day);
            }

            Cal.ItemsSource = allDates;

            //Calendar calendar = new Calendar();
            //calendar.DisplayDateStart = new DateTime(2009, 1, 1);
            //calendar.DisplayDateEnd = new DateTime(2009, 1, 31);
            //calendar.SelectedDate = new DateTime(2009, 1, 2);
            //Cal.Content = calendar.SelectedDate;
        }
    }
}
