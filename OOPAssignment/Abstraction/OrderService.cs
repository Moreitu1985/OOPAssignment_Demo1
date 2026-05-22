using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment.Abstraction
{
    public  class OrderService
    {
        //Cant write the notification
        private readonly INotificationService _notificationService;

        //and order service take notification -->SMS/EMAIL
        public OrderService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void PlaceOrder(string customer)
        {
            Console.WriteLine($"Order placed for {customer}");

            _notificationService.Send(
                customer,
                "Your order has been successfully placed."
            );
        }

    }
}
