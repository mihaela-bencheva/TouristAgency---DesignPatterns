using State.Interfaces;
using State.States;
using System;

namespace State
{
    public class ExcursionState
    {
        public static IExcursionState state;

        public ExcursionState()
        {
            state = OrganizedState.GetState();
        }

        public void Postpone()
        {
            state = PostponedState.GetState();
        }

        public void Organize()
        {
            state = OrganizedState.GetState();
        }

        public void PrintState()
        {
            state.PrintState();
        }
    }
}
