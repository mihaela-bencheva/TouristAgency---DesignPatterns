using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Abstractions
{
    public abstract class Participant
    {
        protected ServerMediator mediator;

        public Participant(ServerMediator server)
        {
            this.mediator = server;
        }
    }
}
