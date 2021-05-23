using AbstractFactory.Abstractions;
using AbstractFactory.Excursions.Destinations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Excursions
{
    public class NorthAmerica : ContinentFactory
    {
        public override List<Excursion> GetExcursions()
        {
            return new List<Excursion>()
            {
                new USA()
                {
                    ID = 1,
                    Destination = "New York and Boston",
                    DepartureDate = new DateTime(2021, 9, 26),
                    ReturnDate = new DateTime(2021, 10, 6),
                    Price = 5995,
                    TouristGuide = "Rokey",
                    Transport = "Plane"
                },
                new Canada()
                {
                    ID = 2,
                    Destination = "Toronto",
                    DepartureDate = new DateTime(2021, 8, 8),
                    ReturnDate = new DateTime(2021, 8, 17),
                    Price = 5699,
                    TouristGuide = "John Smith",
                    Transport = "Plane"
                }
            };
        }
    }
}
