using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment.Abstraction
{
    public class SmsNotificationService : INotificationService
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"SMS sent to {recipient}: {message}");
        }
    }
}
