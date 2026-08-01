using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement.Application.DTOs
{
    public class AirportSearchDto
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 50;
        public string? SearchTerm { get; set; }
        //public string Country { get; set; } = null;
    }
}
