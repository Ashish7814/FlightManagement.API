using Dapper;
using FlightManagement.Domain.Entities;
using FlightManagement.Domain.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FlightManagement.Infrastructure.Persistence.Repositories
{
    public class AirportRepository : IAirportRepository
    {
        private readonly string _connectionString;

        public AirportRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public async Task<(IEnumerable<Airport> Airports, int TotalRecords)> GetAllAirportsAsync(
            int pageNumber,
            int pageSize)
        {
            using var connection = CreateConnection();

            var parameters = new DynamicParameters();
            parameters.Add("@PageNumber", pageNumber);
            parameters.Add("@PageSize", pageSize);

            var airports = (await connection.QueryAsync<Airport>(
                "GetAirports",
                parameters,
                commandType: CommandType.StoredProcedure
            )).ToList();

            var totalRecords = airports.FirstOrDefault()?.TotalRecords ?? 0;

            return (airports, totalRecords);
        }
    }
}
