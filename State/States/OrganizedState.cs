using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    public class OrganizedState : IExcursionState
    {
        public static OrganizedState state = null;
        public OrganizedState()
        {

        }

        public static OrganizedState GetState()
        {
            if (state == null)
            {
                state = new OrganizedState();
            }
            return state;
        }
        public void PrintState()
        {
            Console.WriteLine("The excursion will take place on: ");
        }
    }
}
