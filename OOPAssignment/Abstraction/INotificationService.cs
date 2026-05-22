using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment.Abstraction
{
    public  interface INotificationService
    {
        //NB Interface dont have any implementation 
        //WHY ?
        //Allow multiple inheritance 
        //easy to maintain if changes occurs

        public void Send(string recipient, string message);
       
    }
}
