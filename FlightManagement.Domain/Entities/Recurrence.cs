using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement.Domain.Entities
{
    public class Recurrence
    {
        public int RecurrenceId { get; set; }
        public int TemplateId { get; set; }

        public string RecurrenceType { get; set; }

        // 🔗 Navigation
        public FlightScheduleTemplate FlightTemplate { get; set; }
        public ICollection<RecurrenceDay> Days { get; set; }
        public MonthlyRecurrence Monthly { get; set; }
    }
}
