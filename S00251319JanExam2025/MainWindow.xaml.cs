//https://github.com/ChrisLavin04/S00251319JanExam2025.git

using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace S00251319JanExam2025
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Create 2 Event objects
            Event e1 = new Event() { Name = "Oasis Croke Park", EventDate = new DateTime(2025, 06, 20), TypeOfEvent = EventType.Music };
            Event e2 = new Event() { Name = "Electric Picnic", EventDate = new DateTime(2025, 08, 20), TypeOfEvent = EventType.Music };

            Ticket t1 = new Ticket() { Name = "Early Bird", Price = 100m, AvailableTickets = 100};
            Ticket t2 = new Ticket() { Name = "Platinum", Price = 150m, AvailableTickets = 100};

            Ticket.VIPTicket vt1 = new Ticket.VIPTicket() { Name = "Ticket and Hotel Package", Price = 150m, AdditionalCost = 100m, AdditionalExtras = "4* hotel", AvailableTickets = 100};
            Ticket.VIPTicket vt2 = new Ticket.VIPTicket() { Name = "Weekend Ticket", Price = 200m, AdditionalCost = 100m, AdditionalExtras = "with camping", AvailableTickets = 100};
        }    
    }
}