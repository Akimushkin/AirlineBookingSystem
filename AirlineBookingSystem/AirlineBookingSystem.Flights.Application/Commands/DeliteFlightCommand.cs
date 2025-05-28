using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBookingSystem.Flights.Application.Commands
{
    public record DeliteFlightCommand (Guid Id) : IRequest;
}
