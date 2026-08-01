using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement.Domain.Entities
{
    public class GateAssignment
    {
        public int AssignmentId { get; set; }

        public int FlightId { get; set; }

        public string GateNumber { get; set; }

        public string GateType { get; set; } // Departure / Arrival

        public DateTime ScheduledTime { get; set; }

        public DateTime? ActualTime { get; set; }

        public string Status { get; set; }

        public DateTime AssignedAt { get; set; }

        public int? AssignedBy { get; set; }

        public Flight Flight { get; set; }
    }
}
