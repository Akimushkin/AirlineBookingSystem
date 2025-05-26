using AirlineBookingSystem.Payments.Core.Entities;
using AirlineBookingSystem.Payments.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace AirlineBookingSystem.Payments.Infrastructure.Repositories
{
    public class PaymentRepository: IPaymantRepository
    {
        private readonly IDbConnection _dbConnection;

        public PaymentRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task ProcessPaymentAsunc(Paymant payment)
        {
            const string sql = @"
                INSERT INTO [dbo].[Payments](Id,BookingId,Amount,PaymentDate)
                VALUES(@Id,@BookingId,@Amount,@PaymentDate)
            ";

            await _dbConnection.ExecuteAsync(sql, payment);
        }

        public async Task RefundPaymantAsync(Guid id)
        {
            const string sql = "DELETE FROM Pwyments WHERE Id = @Id";
            await _dbConnection.ExecuteAsync(sql, new { Id = id} );
        }
    }
}
