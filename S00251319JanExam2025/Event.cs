﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00251319JanExam2025
{
    internal class Event :IComparable
    {
        //Event Class Properties
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        List<Ticket> Tickets = new List<Ticket>();
        public enum EventType { Music, Comedy, Theatre }

        //IComparable function to sort Event list
        public int CompareTo(object obj)
        {
            Event that = obj as Event;

            if (this.EventDate > that.EventDate)
                return 1;
            else 
                return -1;
        }
    }
}