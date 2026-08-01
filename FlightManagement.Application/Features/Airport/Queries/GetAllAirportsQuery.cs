using FlightManagement.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement.Application.Features.Airport.Queries
{
    public record GetAllAirportsQuery(AirportSearchDto dto) : IRequest<ApiResponse<PagedResultDto<AirportDto>>>;
}
