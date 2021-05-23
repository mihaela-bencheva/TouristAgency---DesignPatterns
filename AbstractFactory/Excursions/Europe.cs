using AbstractFactory.Abstractions;
using AbstractFactory.Excursions.Destinations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Excursions
{
    public class Europe : ContinentFactory
    {
        public override List<Excursion> GetExcursions()
        {
            return new List<Excursion>()
            {
                new Italy()
                {
                    ID = 1,
                    Destination = "Milan",
                    DepartureDate = new DateTime(2021, 7, 21),
                    ReturnDate = new DateTime(2021, 7, 26),
                    Price = 566.66,
                    TouristGuide = "Atanaska Pencheva",
                    Transport = "Bus"
                },
                new Germany()
                {
                    ID = 2,
                    Destination = "Mannheim",
                    DepartureDate = new DateTime(2021, 8, 5),
                    ReturnDate = new DateTime(2021, 8, 15),
                    Price = 800,
                    TouristGuide = "Mihaela",
                    Transport = "Plane"
                },
                new Italy()
                {
                    ID = 3,
                    Destination = "Rome",
                    DepartureDate = new DateTime(2021, 4, 29),
                    ReturnDate = new DateTime(2021, 5, 9),
                    Price = 566.66,
                    TouristGuide = "Atanaska Pencheva",
                    Transport = "Bus"
                }
            };
        }
    }
}
