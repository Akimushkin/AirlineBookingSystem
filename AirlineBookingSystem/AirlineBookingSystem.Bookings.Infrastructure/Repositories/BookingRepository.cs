using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem.Bookings.Core.Entities;
using AirlineBookingSystem.Bookings.Core.Repositories;
using Dapper;

namespace AirlineBookingSystem.Bookings.Infrastructure.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly IDbConnection _dbConnection;

        public BookingRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }


        public async Task AddBookingAsync(Booking booking)
        {
            const string sql = @"
                INSERT INTO Bookings (Id, FlightId, PassengerName, SeatNumber, BookingData)
                VALUES (@Id, @FlightId, @PassengerName, @SeatNumber, @BookingData)
            ";

            await _dbConnection.ExecuteAsync(sql, booking);
        }

        public async Task<Booking> GetBookingByIdAsync(Guid id)
        {
            const string sql = @"SELECT * FROM Bookings WHERE Id = @Id";

            return await _dbConnection.QuerySingleOrDefaultAsync<Booking>(sql, new { Id = id });
        }
    }
}
