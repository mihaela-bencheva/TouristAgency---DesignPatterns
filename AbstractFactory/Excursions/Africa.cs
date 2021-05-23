using AbstractFactory.Abstractions;
using AbstractFactory.Excursions.Destinations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Excursions
{
    public class Africa : ContinentFactory
    {
        public override List<Excursion> GetExcursions()
        {
            return new List<Excursion>()
            {
                new Egypt()
                {
                    ID = 1,
                    Destination = "Cairo",
                    DepartureDate = new DateTime(2021, 9, 15),
                    ReturnDate = new DateTime(2021, 9, 20),
                    Price = 899.99,
                    TouristGuide = "Kirilka",
                    Transport = "Plane"
                },
                new Tanzania()
                {
                    ID = 2,
                    Destination = "Zanzibar",
                    DepartureDate = new DateTime(2022, 2, 10),
                    ReturnDate = new DateTime(2022, 2, 25),
                    Price = 3299.99,
                    TouristGuide = "John Smith",
                    Transport = "Plane"
                }
            };
        }
    }
}
