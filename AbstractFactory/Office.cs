using AbstractFactory.Abstractions;
using State;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Office
    {
        private List<Excursion> _excursion;
        private ContinentFactory _continent;
        private ExcursionState state;

        public Office(ContinentFactory continentFactory)
        {
            this._continent = continentFactory;
            _excursion = continentFactory.GetExcursions();
            state = new ExcursionState();
        }

        public void GetExcursionsInfo()
        {
            Console.WriteLine("Travel around the World in: {0}", _continent.GetType().Name);
            Console.WriteLine();
            for (int i = 0; i < _excursion.Count; i++)
            {
                Console.WriteLine(_excursion[i].ID + ". " + _excursion[i].Destination);
                if (_excursion[i].DepartureDate > new DateTime(2021, 5, 1) || _excursion[i].ReturnDate > new DateTime(2021, 5, 1))
                {
                    if (_excursion[i].DepartureDate < new DateTime(2021, 6, 30) || _excursion[i].ReturnDate < new DateTime(2021, 6, 30))
                    {
                        state.Postpone();
                        state.PrintState();
                        Console.WriteLine(_excursion[i].DepartureDate);
                        Console.WriteLine("To When: {0}", _excursion[i].ReturnDate);
                    }
                    else
                    {
                        state.Organize();
                        state.PrintState();
                        Console.WriteLine(_excursion[i].DepartureDate);
                        Console.WriteLine("To When: {0}", _excursion[i].ReturnDate);
                    }
                }
                Console.WriteLine("Price: {0}", _excursion[i].Price);
                Console.WriteLine("Tourist Guide: {0}", _excursion[i].TouristGuide);
                Console.WriteLine("Transport: {0}", _excursion[i].Transport);
                Console.WriteLine();
            }
        }
    }
}
