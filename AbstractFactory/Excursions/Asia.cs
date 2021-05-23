using AbstractFactory.Abstractions;
using AbstractFactory.Excursions.Destinations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Excursions
{
    public class Asia : ContinentFactory
    {
        public override List<Excursion> GetExcursions()
        {
            return new List<Excursion>()
            {
                new India()
                {
                    ID = 1,
                    Destination = "New Delhi",
                    DepartureDate = new DateTime(2021, 11, 15),
                    ReturnDate = new DateTime(2021, 11, 30),
                    Price = 4355.65,
                    TouristGuide = "George",
                    Transport = "Plane"
                }
            };
        }
    }
}
