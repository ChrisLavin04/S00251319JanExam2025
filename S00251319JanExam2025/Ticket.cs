using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00251319JanExam2025
{
    public class Ticket
    {
        //Ticket class properties
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableTickets { get; set; }
    }
    public class VIPTicket
    {
        //VIPTicket class properties
        public string AdditionalExtras { get; set; }
        public decimal AdditionalCost { get; set; }
    }
}
