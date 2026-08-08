using FlightManagement.Application.DTOs;
using FlightManagement.Application.Features.Airport.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagement.API.Controllers
{
    [Route("api/flight")]
    [ApiController]
    public class AirportsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AirportsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getAllAirports")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllAirports([FromQuery] AirportSearchDto dto)
        {
            try
            {
                var data = await _mediator.Send(new GetAllAirportsQuery(dto));
                if (data == null)
                    return NotFound("Unable to get Airports");

                return Ok(data);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
