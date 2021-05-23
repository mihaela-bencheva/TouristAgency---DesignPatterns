using Mediator.Abstractions;
using Mediator.Participants;
using System;

namespace Mediator
{
    public class ServerMediator : IServerMediator
    {
        private Staff staff;
        private Client client;

        public Staff Staff
        {
            set { staff = value; }
        }

        public Client Client
        {
            set { client = value; }
        }

        public override void Send(string message, Participant participant)
        {
            if (participant == staff)
            {
                client.Receive(message);
            }
            else

            {
                staff.Receive(message);
            }
        }
    }
}

