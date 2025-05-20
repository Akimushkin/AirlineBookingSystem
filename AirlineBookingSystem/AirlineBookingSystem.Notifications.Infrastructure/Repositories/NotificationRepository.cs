using AirlineBookingSystem.Notifications.Core.Entities;
using AirlineBookingSystem.Notifications.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace AirlineBookingSystem.Notifications.Infrastructure.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly IDbConnection _dbConnection;
        public NotificationRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task LogNotificationAsync(Notification notification)
        {
            const string sql = @"
                INSERT INTO Notifications (Id, Recepient, Message, Type)
                VALUES (@Id, @Recepient, @Message, @Type)
            ";

            await _dbConnection.ExecuteAsync(sql, notification);
        }
    }
