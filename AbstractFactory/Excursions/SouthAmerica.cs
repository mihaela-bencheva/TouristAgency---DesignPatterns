using AbstractFactory.Abstractions;
using AbstractFactory.Excursions.Destinations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Excursions
{
    public class SouthAmerica : ContinentFactory
    {
        public override List<Excursion> GetExcursions()
        {
            return new List<Excursion>()
            {
                new Brazil()
                {
                    ID = 1,
                    Destination = "Rio De Janeiro",
                    DepartureDate = new DateTime(2021, 11, 16),
                    ReturnDate = new DateTime(2021, 11, 25),
                    Price = 4740,
                    TouristGuide = "Ameliya",
                    Transport = "Plane"
                },
                new Argentina()
                {
                    ID = 2,
                    Destination = "Buenos Aires",
                    DepartureDate = new DateTime(2022, 2, 10),
                    ReturnDate = new DateTime(2022, 2, 25),
                    Price = 5299.99,
                    TouristGuide = "Ameliya",
                    Transport = "Plane"
                }
            };
        }
    }
}
