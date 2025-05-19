using AirlineBookingSystem.Payments.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBookingSystem.Payments.Core.Repositories
{
    public interface IPaymantRepository
    {
        Task ProcessPaymentAsunc(Paymant payment);
        Task RefundPaymantAsync(Guid id);
    }
}
