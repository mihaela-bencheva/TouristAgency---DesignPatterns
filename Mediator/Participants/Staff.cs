using AbstractFactory;
using Mediator.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Participants
{
    public class Staff : Participant
    {
        public Staff(ServerMediator server) : base(server)
        {
            
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine("You successfully reserved this trip. We'll send you an email with more details.");
        }
    }
}
