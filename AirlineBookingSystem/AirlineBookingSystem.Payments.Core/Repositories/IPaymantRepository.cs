using AirlineBookingSystem.Payments.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBookingSystem.Payments.Core.Repositories
{
    public interface IPaymentRepository
    {
        Task ProcessPaymentAsunc(Payment payment);
        Task RefundPaymantAsync(Guid Id);
    }
}
