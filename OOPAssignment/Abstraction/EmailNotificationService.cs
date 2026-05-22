using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment.Abstraction
{
    public class EmailNotificationService : INotificationService
    {
      // public EmailNotificationService(string amount) { }
        
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"Email sent to {recipient}: {message}");
        }
    }
}
