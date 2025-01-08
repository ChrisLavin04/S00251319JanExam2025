//https://github.com/ChrisLavin04/S00251319JanExam2025.git

using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
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
        List<Event> events = new List<Event>();
        List<Ticket> tickets = new List<Ticket>();
        List<Ticket.VIPTicket> VIPtickets = new List<Ticket.VIPTicket>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Create 2 Event objects
            Event e1 = new Event() { Name = "Oasis Croke Park", EventDate = new DateTime(2025, 06, 20), TypeOfEvent = EventType.Music };
            Event e2 = new Event() { Name = "Electric Picnic", EventDate = new DateTime(2025, 08, 20), TypeOfEvent = EventType.Music };
            //Create 2 Ticket objects
            Ticket t1 = new Ticket() { Name = "Early Bird", Price = 100m, AvailableTickets = 100};
            Ticket t2 = new Ticket() { Name = "Platinum", Price = 150m, AvailableTickets = 100};
            //Create 2 VIPTicket objects
            Ticket.VIPTicket vt1 = new Ticket.VIPTicket() { Name = "Ticket and Hotel Package", Price = 150m, AdditionalCost = 100m, AdditionalExtras = "4* hotel", AvailableTickets = 100};
            Ticket.VIPTicket vt2 = new Ticket.VIPTicket() { Name = "Weekend Ticket", Price = 200m, AdditionalCost = 100m, AdditionalExtras = "with camping", AvailableTickets = 100};

            //Populate lists
            events.Add(e1);
            events.Add(e2);
            tickets.Add(t1);
            tickets.Add(t2);
            VIPtickets.Add(vt1);
            VIPtickets.Add(vt2);

            //Sort events using IComparable
            events.Sort();

            //Add content to lisboxes
            LBXEvents.ItemsSource = events;
            LBXTickets.ItemsSource.Add(tickets);
            LBXTickets.ItemSource.Add(VIPtickets);
        }

        private void BTNBook_Click(object sender, RoutedEventArgs e)
        {
            //Determine what ticket is selected
            Ticket selected = LBXTickets.SelectedItem as Ticket;
            int ticketsToPurchase = int.Parse(TBXNumberOfTickets.ItemsSource);
            if (selected != null)
                if (selected.AvailableTickets > ticketsToPurchase)
                {
                    //Take action. Remove the specified number of tickets from available tickets 
                    selected.AvailableTickets -= ticketsToPurchase;
                    MessageBox.Show("Tickets Purchased.");
                }
                else if (selected.AvailableTickets < ticketsToPurchase)
                {
                    MessageBox.Show("Not enough available tickets");
                }
            }

        private void TBXSearch_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            string searchContent = TBXSearch.Text;
            if (searchContent != null)
            {
                //Reset Events list
                LBXEvents.ItemsSource.Clear();

                foreach (Event event in events)
                {
                    //Add events that include the text in the event name
                    if (searchcontent in event.Name) 
                    {
                       events.add(event);
                    }
                }
            }
      }
}
    
        