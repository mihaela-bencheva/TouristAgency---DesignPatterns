using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Abstractions
{
    public abstract class IServerMediator
    {
        public abstract void Send(string message, Participant participant);
    }
}
