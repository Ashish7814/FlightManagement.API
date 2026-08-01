using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement.Domain.Entities
{
    public class MonthlyRecurrence
    {
        public int Id { get; set; }
        public int RecurrenceId { get; set; }
        public int DayOfMonth { get; set; }

        public Recurrence Recurrence { get; set; }
    }
}
