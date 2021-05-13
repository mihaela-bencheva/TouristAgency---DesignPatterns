using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    public class PostponedState : IExcursionState
    {
        public static PostponedState state = null;
        public PostponedState()
        {

        }

        public static PostponedState GetState()
        {
            if (state == null)
            {
                state = new PostponedState();
            }
            return state;
        }
        public void PrintState()
        {
            Console.WriteLine("This excursion is postponed due to Covid-19!");
        }
    }
}
