using Mediator.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Participants
{
    public class Client : Participant
    {
        public Client(ServerMediator mediator)
          : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine(message);
        }
    }
}
