using AbstractFactory.Abstractions;
using AbstractFactory.Excursions.Destinations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Excursions
{
    public class Australia : ContinentFactory
    {
        public override List<Excursion> GetExcursions()
        {
            return new List<Excursion>()
            {
                new AustraliaC()
                {
                    ID = 1,
                    Destination = "Sidney",
                    DepartureDate = new DateTime(2022, 4, 15),
                    ReturnDate = new DateTime(2022, 5, 15),
                    Price = 5899.99,
                    TouristGuide = "Peter",
                    Transport = "Plane"
                }
            };
        }
    }
}
