using FlightManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement.Domain.Interfaces
{
    public interface IAirportRepository
    {
        Task<(IEnumerable<Airport> Airports, int TotalRecords)> GetAllAirportsAsync(int pageNumber, int pageSize);
    }
}
