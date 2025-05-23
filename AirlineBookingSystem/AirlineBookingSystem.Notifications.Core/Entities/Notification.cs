﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBookingSystem.Notifications.Core.Entities
{
    public class Notification
    {
        public Guid Id { get; set; }
        public string Recepient { get; set; }
        public string Message { get; set; }
        public string Type { get; set; } // Email, SMS, etc.
        public DateTime SentAt { get; set; }
    }
}
