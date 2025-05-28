using AirlineBookingSystem.Notifications.Application.Interfaces;
using AirlineBookingSystem.Notifications.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBookingSystem.Notifications.Application.Services
{
    public class NotificationService : INotificationService
    {
        public async Task SendNotificationAsync(Notification notification)
        {
            // Simulate sending notification (via email or SMS)
            Console.WriteLine($"Notification sent to {notification.Recepient} : {notification.Message}" );


        }
    }
}
